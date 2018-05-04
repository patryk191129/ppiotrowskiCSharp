using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Dictionary _dictionary;

        public Form1()
        {
            InitializeComponent();
        }

        string _fileName;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();

            if (_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileDirectoryText.Text = _openFileDialog.FileName;
                _fileName = _openFileDialog.FileName;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            _dictionary = new Dictionary();
            ReadFileTimeValue.Text = ((double)_dictionary.InitializeDictionary(_fileName) / 1000).ToString() + " seconds";
            TwoElementsTimeValue.Text = ((double)_dictionary.CreateTwoElementsDictionary() / 1000).ToString() + " seconds";
            ThreeElementsTimeValue.Text = ((double)_dictionary.CreateThreeElementsDictionary() / 1000).ToString() + " seconds";
            TwoElementsDictionaryCountValue.Text = _dictionary.ReturnTwoElementsDictionaryCount().ToString();
            ThreeElementsDictionaryCountValue.Text = _dictionary.ReturnThreeElementsDictionaryCount().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_dictionary != null)
            {
                List<string> str = _dictionary.ReturnValues(SetValue.Text);

                if (str == null || str.Count == 0)
                {
                    comboBox.DroppedDown = false;
                    comboBox.Items.Clear();
                    return;
                }
                else
                {
                    comboBox.DroppedDown = false;
                    comboBox.Items.Clear();

                    FoundMatchesValue.Text = str.Count.ToString();

                    int i = 1;

                    foreach (string surnameValue in str)
                    {
                        comboBox.Items.Add(surnameValue);
                        i++;

                    }

                    comboBox.DroppedDown = true;

                }

            }

        }
    }
}
