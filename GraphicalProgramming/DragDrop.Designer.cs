namespace GraphicalProgramming
{
    partial class DragDrop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.cmb_pensize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.run_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txt_size);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_square);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.cmb_pensize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 423);
            this.panel1.TabIndex = 0;
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(3, 302);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(143, 20);
            this.txt_size.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shape size";
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(5, 221);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(143, 35);
            this.btn_square.TabIndex = 6;
            this.btn_square.Text = "Square";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Location = new System.Drawing.Point(3, 180);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(143, 35);
            this.btn_rect.TabIndex = 5;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(3, 139);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(143, 35);
            this.btn_circle.TabIndex = 4;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shapes";
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(5, 60);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(143, 35);
            this.btn_color.TabIndex = 2;
            this.btn_color.Text = "Choose color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // cmb_pensize
            // 
            this.cmb_pensize.FormattingEnabled = true;
            this.cmb_pensize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_pensize.Location = new System.Drawing.Point(3, 33);
            this.cmb_pensize.Name = "cmb_pensize";
            this.cmb_pensize.Size = new System.Drawing.Size(145, 21);
            this.cmb_pensize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pen Tool";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.run_menu,
            this.graphicalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // run_menu
            // 
            this.run_menu.Name = "run_menu";
            this.run_menu.Size = new System.Drawing.Size(40, 20);
            this.run_menu.Text = "Run";
            // 
            // graphicalToolStripMenuItem
            // 
            this.graphicalToolStripMenuItem.Name = "graphicalToolStripMenuItem";
            this.graphicalToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.graphicalToolStripMenuItem.Text = "Graphical";
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.Location = new System.Drawing.Point(154, 27);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(646, 423);
            this.pnl_Draw.TabIndex = 2;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "DragDrop";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.ComboBox cmb_pensize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem run_menu;
        private System.Windows.Forms.ToolStripMenuItem graphicalToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}