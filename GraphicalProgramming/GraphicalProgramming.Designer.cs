namespace GraphicalProgramming
{
    partial class GraphicalProgramming
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
            this.txt_coding = new System.Windows.Forms.RichTextBox();
            this.pnl_draw = new System.Windows.Forms.Panel();
            this.btn_run = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.run_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_output = new System.Windows.Forms.RichTextBox();
            this.graphicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_draw.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_coding
            // 
            this.txt_coding.Location = new System.Drawing.Point(1, 370);
            this.txt_coding.Name = "txt_coding";
            this.txt_coding.Size = new System.Drawing.Size(442, 183);
            this.txt_coding.TabIndex = 0;
            this.txt_coding.Text = "";
            this.txt_coding.TextChanged += new System.EventHandler(this.txt_coding_TextChanged);
            // 
            // pnl_draw
            // 
            this.pnl_draw.Controls.Add(this.btn_run);
            this.pnl_draw.Controls.Add(this.menuStrip1);
            this.pnl_draw.Location = new System.Drawing.Point(1, 1);
            this.pnl_draw.Name = "pnl_draw";
            this.pnl_draw.Size = new System.Drawing.Size(880, 369);
            this.pnl_draw.TabIndex = 1;
            this.pnl_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(543, 0);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(40, 24);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.run_menu,
            this.graphicalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // run_menu
            // 
            this.run_menu.Name = "run_menu";
            this.run_menu.Size = new System.Drawing.Size(40, 20);
            this.run_menu.Text = "Run";
            this.run_menu.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(438, 370);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(442, 183);
            this.txt_output.TabIndex = 2;
            this.txt_output.Text = "";
            // 
            // graphicalToolStripMenuItem
            // 
            this.graphicalToolStripMenuItem.Name = "graphicalToolStripMenuItem";
            this.graphicalToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.graphicalToolStripMenuItem.Text = "Graphical";
            this.graphicalToolStripMenuItem.Click += new System.EventHandler(this.graphicalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 552);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.pnl_draw);
            this.Controls.Add(this.txt_coding);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_draw.ResumeLayout(false);
            this.pnl_draw.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_coding;
        private System.Windows.Forms.Panel pnl_draw;
        private System.Windows.Forms.RichTextBox txt_output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem run_menu;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ToolStripMenuItem graphicalToolStripMenuItem;
    }
}

