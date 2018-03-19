using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        enum DrawMode
        {
            point,
            line,
            rectangle,
            oval
        }

        DrawMode _drawMode;
        int[] _colorChannels = new int[3];
        int _brushSize = 5;
        Graphics g;
        Pen p = new Pen(Color.Black, 5);

        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        GraphicsState state;
        Image imageTmp;
        int k = 0;


        public Form1()
        {
            _drawMode = DrawMode.point;
            
            InitializeComponent();
            g = panel1.CreateGraphics();
            NewImage();
            DrawModeValue.Text = "Point";
            imageTmp = new Bitmap(panel1.Width, panel1.Height, g);
        }

        private Color ReturnBrushColor()
        {
            return Color.FromArgb(_colorChannels[0], _colorChannels[1], _colorChannels[2]);
        }

        private void NewImage()
        {
            g.Clear(Color.White);          
        }

        void ResetImage()
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
            
            if(e.Button==MouseButtons.Left)
            {
                k = 1;

                switch(_drawMode)
                {
                    case DrawMode.point: g.FillRectangle(p.Brush, e.X - (_brushSize / 2), e.Y - (_brushSize / 2), _brushSize, _brushSize); break;
                    case DrawMode.line: sp = e.Location; state = g.Save(); break;
                    case DrawMode.rectangle: sp = e.Location; state = g.Save(); break;
                }
               
            }

        }

        private void SetDrawMode(DrawMode _drawMode)
        {
            this._drawMode = _drawMode;

            switch(_drawMode)
            {
                case DrawMode.line: DrawModeValue.Text = "Line"; break;
                case DrawMode.point: DrawModeValue.Text = "Point"; break;
                case DrawMode.rectangle: DrawModeValue.Text = "Rectangle"; break;
            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;

            switch(_drawMode)
            {
                case DrawMode.line:
                    g.DrawLine(p, sp.X, sp.Y, e.X, e.Y);
                    sp = e.Location;
                    break;
                case DrawMode.rectangle:
                    int startPointX = Math.Min(sp.X, e.X);
                    int startPointY = Math.Min(sp.Y, e.Y);

                    int lengthX = Math.Abs(e.X - sp.X);
                    int lengthY = Math.Abs(e.Y - sp.Y);


                    g.DrawRectangle(p, startPointX, startPointY, lengthX, lengthY);
                    break;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(k == 1)
            {
                switch(_drawMode)
                {
                    case DrawMode.point:
                        ep = e.Location;
                        g.FillRectangle(p.Brush, ep.X - (_brushSize / 2), ep.Y - (_brushSize / 2), _brushSize, _brushSize);
                        break;
                }
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetDrawMode(DrawMode.point);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDrawMode(DrawMode.line);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDrawMode(DrawMode.rectangle);
        }
    }
}
