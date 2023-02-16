using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using RomanNumberCalculator.Models;

namespace RomanNumberCalculator.Views
{
    public partial class MainWindow : Window
    {
        private string oper;
        public MainWindow()
        {
            InitializeComponent();
            oper = String.Empty;
        }
        public void ButtonClick(object sender, RoutedEventArgs eventArgs)
        {
            Button? button = sender as Button;
            if (button?.Tag?.ToString() == "operator" && button.Name != "equals" && Screen.Text != "ERROR"
                && RomanNumber.Current != null) { Screen.Text = RomanNumber.Current.ToString(); RomanNumber.Current = null; }
            if (button?.Tag?.ToString() == "number" && button.Name != "equals" && Screen.Text != "ERROR"
                && RomanNumber.Current != null) { Screen.Text = String.Empty; RomanNumber.Current = null; }
            if (button != null && Screen.Text != "ERROR")
            {
                if (button.Tag?.ToString() == "operator" && (oper.Trim() == "+" || oper.Trim() == "-" || oper.Trim() == "*" || oper.Trim() == "/")) Screen.Text = Screen.Text.Replace(oper,String.Empty);
                oper = (button.Tag?.ToString() == "operator" ? " " : "") + button.Content.ToString() + (button.Tag?.ToString() == "operator" ? " " : "");
                Screen.Text += oper;
            }
            if (button?.Name == "equals" && Screen.Text != "ERROR")
            {
                string[] parts = Screen.Text.Trim().Split(" ");
                List<RomanNumber> numbers = new List<RomanNumber>();
                List<string> operators = new List<string>();
                for(int i = 0; i < parts.Length; i++)
                {
                    if (i % 2 == 0) numbers.Add(new RomanNumberExtend(parts[i]));
                    else operators.Add(parts[i]);
                }
                int k = 1;
                RomanNumber? n3 = numbers[0];
                try
                {
                    for(int i = 0;i < operators.Count - 1;i++)
                    {
                        switch(operators[i])
                        {
                            case "+": { n3 += numbers[k]; break; }
                            case "-": { n3 -= numbers[k]; break; }
                            case "*": { n3 *= numbers[k]; break; }
                            case "/": { n3 /= numbers[k]; break; }
                        }
                        k++;
                    }
                    Screen.Text += n3.ToString();
                    RomanNumber.Current = n3;
                }
                catch(RomanNumberException)
                {
                    Screen.Text = "ERROR";
                }
            }
            if (button?.Name == "CE") { Screen.Text = String.Empty; RomanNumber.Current = null; }
        }

    }
}
