namespace mazetest
{
    partial class create
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setPlayerPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEndPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHorizontalPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVerticalPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBlankPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUTPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNoenterableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNorthwestPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNortheastPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSouthwestPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSoutheastPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "compleatable random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPlayerPositionToolStripMenuItem,
            this.setEndPositionToolStripMenuItem,
            this.setHorizontalPieceToolStripMenuItem,
            this.setVerticalPieceToolStripMenuItem,
            this.setBlankPieceToolStripMenuItem,
            this.setTPieceToolStripMenuItem,
            this.setUTPieceToolStripMenuItem,
            this.setNoenterableToolStripMenuItem,
            this.setNorthwestPieceToolStripMenuItem,
            this.setNortheastPieceToolStripMenuItem,
            this.setSouthwestPieceToolStripMenuItem,
            this.setSoutheastPieceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 268);
            // 
            // setPlayerPositionToolStripMenuItem
            // 
            this.setPlayerPositionToolStripMenuItem.Name = "setPlayerPositionToolStripMenuItem";
            this.setPlayerPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPlayerPositionToolStripMenuItem.Text = "set player position";
            this.setPlayerPositionToolStripMenuItem.Click += new System.EventHandler(this.setPlayerPositionToolStripMenuItem_Click);
            // 
            // setEndPositionToolStripMenuItem
            // 
            this.setEndPositionToolStripMenuItem.Name = "setEndPositionToolStripMenuItem";
            this.setEndPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setEndPositionToolStripMenuItem.Text = "set end position";
            this.setEndPositionToolStripMenuItem.Click += new System.EventHandler(this.setEndPositionToolStripMenuItem_Click);
            // 
            // setHorizontalPieceToolStripMenuItem
            // 
            this.setHorizontalPieceToolStripMenuItem.Name = "setHorizontalPieceToolStripMenuItem";
            this.setHorizontalPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setHorizontalPieceToolStripMenuItem.Text = "set horizontal piece";
            this.setHorizontalPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setVerticalPieceToolStripMenuItem
            // 
            this.setVerticalPieceToolStripMenuItem.Name = "setVerticalPieceToolStripMenuItem";
            this.setVerticalPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setVerticalPieceToolStripMenuItem.Text = "set vertical piece";
            this.setVerticalPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setBlankPieceToolStripMenuItem
            // 
            this.setBlankPieceToolStripMenuItem.Name = "setBlankPieceToolStripMenuItem";
            this.setBlankPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setBlankPieceToolStripMenuItem.Text = "set blank piece";
            this.setBlankPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setTPieceToolStripMenuItem
            // 
            this.setTPieceToolStripMenuItem.Name = "setTPieceToolStripMenuItem";
            this.setTPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setTPieceToolStripMenuItem.Text = "set u t pice";
            this.setTPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setUTPieceToolStripMenuItem
            // 
            this.setUTPieceToolStripMenuItem.Name = "setUTPieceToolStripMenuItem";
            this.setUTPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setUTPieceToolStripMenuItem.Text = "set t piece";
            this.setUTPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setNoenterableToolStripMenuItem
            // 
            this.setNoenterableToolStripMenuItem.Name = "setNoenterableToolStripMenuItem";
            this.setNoenterableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNoenterableToolStripMenuItem.Text = "set noenterable piece";
            this.setNoenterableToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setNorthwestPieceToolStripMenuItem
            // 
            this.setNorthwestPieceToolStripMenuItem.Name = "setNorthwestPieceToolStripMenuItem";
            this.setNorthwestPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNorthwestPieceToolStripMenuItem.Text = "set northwest piece";
            this.setNorthwestPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setNortheastPieceToolStripMenuItem
            // 
            this.setNortheastPieceToolStripMenuItem.Name = "setNortheastPieceToolStripMenuItem";
            this.setNortheastPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNortheastPieceToolStripMenuItem.Text = "set northeast piece";
            this.setNortheastPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setSouthwestPieceToolStripMenuItem
            // 
            this.setSouthwestPieceToolStripMenuItem.Name = "setSouthwestPieceToolStripMenuItem";
            this.setSouthwestPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSouthwestPieceToolStripMenuItem.Text = "set southwest piece";
            this.setSouthwestPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // setSoutheastPieceToolStripMenuItem
            // 
            this.setSoutheastPieceToolStripMenuItem.Name = "setSoutheastPiceToolStripMenuItem";
            this.setSoutheastPieceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSoutheastPieceToolStripMenuItem.Text = "set southeast piece";
            this.setSoutheastPieceToolStripMenuItem.Click += new System.EventHandler(this.changepiece);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(371, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "show best path";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "moves:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "create";
            this.Text = "create a maze";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.create_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.create_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.create_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setPlayerPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEndPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHorizontalPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVerticalPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBlankPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUTPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNoenterableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNorthwestPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNortheastPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSouthwestPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSoutheastPieceToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
