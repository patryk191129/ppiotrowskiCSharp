using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();

            if (_folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String[] files = Directory.GetFiles(_folderBrowserDialog.SelectedPath, "*.sln");
                LogBox.Text = "";
                if (files.Length > 0)
                {                    
                    PackProjectFiles packProjectFiles = new PackProjectFiles(files[0], Path.GetDirectoryName(files[0]), this);
                }
                else
                {
                    UpdateServerLog("Error: Invalid folder");
                }

            }
        }

        public void UpdateServerLog(string logInfo)
        {
            MethodInvoker inv = delegate
            {
                LogBox.Text += "\n" + DateTime.Now.ToString("HH:mm:ss") + ": " + logInfo;
            };

            this.Invoke(inv);
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
