using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalProgramming
{
    public partial class DragDrop : Form
    {
        private bool startPaint = false;
        //nullable int for storing Null value
        private int? initX = null;
        private int? initY = null;
        private bool drawSquare = false;
        private bool drawRectangle = false;
        private bool drawCircle = false;

        public DragDrop()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }

        private Graphics g;

        //Button for Setting pen Color
        private void btn_color_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_color if user click on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_color.BackColor = c.Color;
            }
        }

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(btn_color.BackColor, float.Parse(cmb_pensize.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(btn_color.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and Heigt value from Textbox(txt_size)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_size.Text), int.Parse(txt_size.Text));
                //setting startPaint and drawSquare value to false for creating one graphic on one click.
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btn_color.BackColor);
                //setting the width twice of the height
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_size.Text), int.Parse(txt_size.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_color.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_size.Text), int.Parse(txt_size.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
