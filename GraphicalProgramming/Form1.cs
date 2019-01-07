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
    public partial class Form1 : Form
    {
        private Boolean draw = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (draw == true)
            {
                FactoryPattern.ShapeFactory.GetShape(1, 50, 50, 200, 200, graphics);
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_draw.BackColor = Color.Yellow;
            pnl_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            String command = txt_coding.Text;
            if (command.Equals("Circle"))
            {
                draw = true;
                pnl_draw.BackColor = Color.Yellow;
                pnl_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
                txt_coding.Clear();
                txt_output.Clear();
            }
            else
            {
                txt_coding.Clear();
                txt_output.Clear();
                txt_output.AppendText(Environment.NewLine+"Command Invalid.");
            }
        }

        private void txt_coding_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
