using Avalonia.Controls;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        string ing;
        string choice;
        string choice2;

        public MainWindow()
        {
            InitializeComponent();
            Null.Click += Null_Click;
            One.Click += One_Click;
            Two.Click += Two_Click;
            Three.Click += Three_Click;
            Four.Click += Four_Click;
            Five.Click += Five_Click;
            Six.Click += Six_Click;
            Seven.Click += Seven_Click;
            Eight.Click += Eight_Click;
            Nine.Click += Nine_Click;

            comma.Click += Comma_Click;
            Log.Click += Log_Click;
            step.Click += Step_Click;
            Delete.Click += Delete_Click;
            Equals.Click += Equals_Click;
            sko.Click += Sko_Click;
            skob.Click += Skob_Click;
            Plus.Click += Plus_Click;

            Minus.Click += Minus_Click;
        }
        
        private void Minus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ing = "-";
            choice = namepase.Text;
            string number = "";
            namepase.Text = number;
        }

        private void Plus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ing = "+";
            choice = namepase.Text;
            string number = "";
            namepase.Text = number; 
        }

        private void Equals_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (ing == "+")
            {
                choice2 = namepase.Text;

                int number = Convert.ToInt32(choice2) + Convert.ToInt32(choice); 
                string answer = Convert.ToString(number);
                namepase.Text = choice+" + "+choice2 +" = "+answer;
            }
            else if (ing == "-")
            {
                choice2 = namepase.Text;

                int number = Convert.ToInt32(choice) - Convert.ToInt32(choice2);
                string answer = Convert.ToString(number);
                namepase.Text = choice + " - " + choice2 + " = " + answer;
            }
            else if (ing == "*")
            {

            }
            else if (ing == "/")
            {

            }
        }
        private void Step_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

        }

        private void Log_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //int n = Convert.ToInt32(namepase);
            //namepase.Text += Math.Log(n);
        }


        private void Delete_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            namepase.Text = "";
        }
        private void Skob_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = ")";
            namepase.Text += number;
        }
        private void Sko_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "(";
            namepase.Text += number;
        }
        private void Nine_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "9";
            namepase.Text += number;
        }
        private void Eight_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "8";
            namepase.Text += number;
        }
        private void Seven_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "7";
            namepase.Text += number;
        }
        private void Six_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "6";
            namepase.Text += number;
        }
        private void Five_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "5";
            namepase.Text += number;
        }
        private void Comma_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if ((namepase.Text.IndexOf(",") == -1) && (namepase.Text.IndexOf(" ") == -1))
                namepase.Text += ",";

        }
        private void Null_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "0";
            namepase.Text += number;
        }
        private void One_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "1";
            namepase.Text += number;
        }
        private void Two_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "2";
            namepase.Text += number;
        }
        private void Three_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "3";
            namepase.Text += number;
        }
        private void Four_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string number = "4";
            namepase.Text += number;
        }
    }
}