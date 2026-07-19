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
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userdata.json");

        public static void Save()
        {
            try
            {
                var state = new SaveState
                {
                    Username = AppData.Username,
                    TotalAllowance = AppData.TotalAllowance,
                    TotalExpenses = AppData.TotalExpenses,
                    CurrentBalance = AppData.CurrentBalance,
                    
                    // Convert BindingList to a standard List for easy JSON serialization
                    Expenses = new List<Expense>(ExpenseManager.Expenses),

                    GoalName = GoalPage.GoalName,
                    TargetAmount = GoalPage.TargetAmount,
                    SavedAmount = GoalPage.SavedAmount,
                    TargetDate = GoalPage.TargetDate,
                    InspirationQuote = GoalPage.InspirationQuote
                };

                string json = JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return;

                string json = File.ReadAllText(FilePath);
                var state = JsonSerializer.Deserialize<SaveState>(json);

                if (state != null)
                {
                    AppData.Username = state.Username;
                    AppData.TotalAllowance = state.TotalAllowance;
                    AppData.TotalExpenses = state.TotalExpenses;
                    AppData.CurrentBalance = state.CurrentBalance;

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class SaveState
    {
        public string Username { get; set; } = "User";
        public double TotalAllowance { get; set; } = 0;
        public double TotalExpenses { get; set; } = 0;
        public double CurrentBalance { get; set; } = 0;
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public string GoalName { get; set; } = "";
        public double TargetAmount { get; set; } = 0;
        public double SavedAmount { get; set; } = 0;
        public DateTime TargetDate { get; set; } = DateTime.Today;
        public string InspirationQuote { get; set; } = "";
    }
}
