using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        int _port;
        string _directory;
        HTTPServer _server;


        public Form1()
        {
            _server = new HTTPServer();
            _port = 8000;
            _directory = "";
            InitializeComponent();
        }

        private void SetDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();
            if (_folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DirectoryLocation.Text = _folderBrowserDialog.SelectedPath;
                _directory = _folderBrowserDialog.SelectedPath;
            }
                
        }

        private void DirectoryLocation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _port = Convert.ToInt32(portValue.Text);
            _server.InitializeServer(_port, _directory);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopServerButton_Click(object sender, EventArgs e)
        {
            _server.StopServer();
        }
    }
}
