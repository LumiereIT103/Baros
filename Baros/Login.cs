﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Baros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void fullname_txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void signin_Btn_Click(object sender, EventArgs e)
        {
            string username = cNum_tb.Text;
            string password = pass_tb.Text;


            if (IsValidUsername(username) && IsValidPassword(password))
            {
                LoggedinUser.uname = cNum_tb.Text;
                Home dB = new Home();
                dB.Show();
                this.Hide(); 

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            
        }
        

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear2_btn_Click(object sender, EventArgs e)
        {
            cNum_tb.Clear();
            pass_tb.Clear();
        }

        private void pass_tb_TextChanged(object sender, EventArgs e)
        {

        }






        private bool IsValidUsername(string username)
        {
            
            return !string.IsNullOrEmpty(username);
        }

        private bool IsValidPassword(string password)
        {
            
            if (password.Length < 12)
            {
                MessageBox.Show("Password must be at least 12 characters long.");
                return false;
            }

            // Regex to check for uppercase, lowercase, number, and symbol
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";
            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Password must contain uppercase, lowercase, numbers, and symbols.");
                return false;
            }

            // Check if the password is a common word (simple example)
            if (IsCommonPassword(password))
            {
                MessageBox.Show("Password must not be a common word or easily guessable.");
                return false;
            }

            return true;
        }

        private bool IsCommonPassword(string password)
        {
            
            string[] commonPasswords = { "password", "123456", "qwerty", "admin" };
            foreach (string common in commonPasswords)
            {
                if (password.ToLower().Contains(common))
                    return true;
            }
            return false;
        }
    }
}
