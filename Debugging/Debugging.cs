using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Debugging
{
    public partial class Debugging : Form
    {
        public Debugging()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            letterCountValueLabel.Text = countLetters(dataTextBox.Text).ToString();
            wordCountValueLabel.Text = countWords(dataTextBox.Text).ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int countWords(string textData)
        {
            int wordCount = 0;
            wordCount = Regex.Matches(textData, @"[A-Za-z0-9]+").Count;
            return wordCount;
        }

        private int countLetters(string textData)
        {
            int letterCount = 0;
            letterCount = Regex.Matches(textData, @"[A-Za-z]").Count;
            return letterCount;
        }

    }
}
