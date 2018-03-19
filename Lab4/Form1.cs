using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        int[] _colorChannels = new int[3];
        int _brushSize = 5;
        Graphics g;
        Pen p = new Pen(Color.Black, 5);

        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            NewImage();
        }

        private Color ReturnBrushColor()
        {
            return Color.FromArgb(_colorChannels[0], _colorChannels[1], _colorChannels[2]);
        }

        private void NewImage()
        {

            g.Clear(Color.White);
        }

        private void OnChangeColor()
        {
            PictureBox.BackColor = ReturnBrushColor();
            p.Color = ReturnBrushColor();
            p.Width = _brushSize;
        }



        private void ColorR_Scroll(object sender, EventArgs e)
        {
            _colorChannels[0] = ColorR.Value;
            OnChangeColor();
        }

        private void ColorG_Scroll(object sender, EventArgs e)
        {
            _colorChannels[1] = ColorG.Value;
            OnChangeColor();
        }

        private void ColorB_Scroll(object sender, EventArgs e)
        {
            _colorChannels[2] = ColorB.Value;
            OnChangeColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if(e.Button==MouseButtons.Left)
            {
                k = 1;
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(k == 1)
            {
                ep = e.Location;              
                g.DrawLine(p, sp, ep);
            }
            sp = ep;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewImage();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _brushSize = trackBar1.Value;
            OnChangeColor();
        }
    }
}
