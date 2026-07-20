using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MobileAppDesign
{
    public static class PersistenceManager
    {
        private static readonly string LastUserFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lastuser.json");

        private static string GetFilePathForUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                username = "default_user";
            }
            // Clean the username to make it a safe filename
            string safeUsername = string.Join("_", username.Split(Path.GetInvalidFileNameChars()));
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"userdata_{safeUsername}.json");
        }

        public static void Save()
        {
            try
            {
                string filePath = GetFilePathForUser(AppData.Username);
                var state = new SaveState
                {
                    Username = AppData.Username,
                    TotalAllowance = AppData.TotalAllowance,
                    TotalExpenses = AppData.TotalExpenses,
                    CurrentBalance = AppData.CurrentBalance,
                    LastResetDate = AppData.LastResetDate,
                    
                    // Convert BindingList to standard List for JSON
                    Expenses = new List<Expense>(ExpenseManager.Expenses),

                    GoalName = GoalPage.GoalName,
                    TargetAmount = GoalPage.TargetAmount,
                    SavedAmount = GoalPage.SavedAmount,
                    TargetDate = GoalPage.TargetDate,
                    InspirationQuote = GoalPage.InspirationQuote
                };

                string json = JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Save this user as the last logged in user
                SaveLastUsername(AppData.Username);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadForUser(string username)
        {
            try
            {
                string filePath = GetFilePathForUser(username);
                if (!File.Exists(filePath))
                {
                    // Initialize a clean, empty state for a new user
                    AppData.Username = username;
                    AppData.TotalAllowance = 0;
                    AppData.TotalExpenses = 0;
                    AppData.CurrentBalance = 0;
                    AppData.LastResetDate = DateTime.Now; // Start tracking their weekly cycle today

                    ExpenseManager.Expenses.Clear();

                    GoalPage.GoalName = "";
                    GoalPage.TargetAmount = 0;
                    GoalPage.SavedAmount = 0;
                    GoalPage.TargetDate = DateTime.Today;
                    GoalPage.InspirationQuote = "";

                    // Save this fresh profile immediately
                    Save();
                    return;
                }

                string json = File.ReadAllText(filePath);
                var state = JsonSerializer.Deserialize<SaveState>(json);

                if (state != null)
                {
                    AppData.Username = state.Username;
                    AppData.TotalAllowance = state.TotalAllowance;
                    AppData.TotalExpenses = state.TotalExpenses;
                    AppData.CurrentBalance = state.CurrentBalance;
                    // If file has MinValue, initialize to Now
                    AppData.LastResetDate = state.LastResetDate == DateTime.MinValue ? DateTime.Now : state.LastResetDate;

                    ExpenseManager.Expenses.Clear();
                    foreach (var expense in state.Expenses)
                    {
                        ExpenseManager.Expenses.Add(expense);
                    }

                    GoalPage.GoalName = state.GoalName;
                    GoalPage.TargetAmount = state.TargetAmount;
                    GoalPage.SavedAmount = state.SavedAmount;
                    GoalPage.TargetDate = state.TargetDate;
                    GoalPage.InspirationQuote = state.InspirationQuote;

                    // Immediately run the check to see if their week has rolled over
                    CheckWeeklyReset(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CheckWeeklyReset(bool quiet = true)
        {
            if (AppData.LastResetDate != DateTime.MinValue && DateTime.Now >= AppData.LastResetDate.AddDays(7))
            {
                // Reset weekly allowance counters
                AppData.TotalAllowance = 0;
                AppData.TotalExpenses = 0;
                AppData.CurrentBalance = 0;
                AppData.LastResetDate = DateTime.Now;

                // Save the new reset state immediately
                Save();

                if (!quiet)
                {
                    MessageBox.Show("A week has passed! Your weekly allowance counters have been reset.", 
                                    "Weekly Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void SaveLastUsername(string username)
        {
            try
            {
                File.WriteAllText(LastUserFilePath, username);
            }
            catch { }
        }

        public static string LoadLastUsername()
        {
            try
            {
                if (File.Exists(LastUserFilePath))
                {
                    return File.ReadAllText(LastUserFilePath);
                }
            }
            catch { }
            return "";
        }
    }

    public class SaveState
    {
        public string Username { get; set; } = "User";
        public double TotalAllowance { get; set; } = 0;
        public double TotalExpenses { get; set; } = 0;
        public double CurrentBalance { get; set; } = 0;
        public DateTime LastResetDate { get; set; } = DateTime.MinValue;
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public string GoalName { get; set; } = "";
        public double TargetAmount { get; set; } = 0;
        public double SavedAmount { get; set; } = 0;
        public DateTime TargetDate { get; set; } = DateTime.Today;
        public string InspirationQuote { get; set; } = "";
    }
}
