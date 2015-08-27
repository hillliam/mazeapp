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
            this.setHorizontalPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setVerticalPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBlankPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUTPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNoenterableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNorthwestPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNortheastPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSouthwestPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSoutheastPiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.setHorizontalPiceToolStripMenuItem,
            this.setVerticalPiceToolStripMenuItem,
            this.setBlankPiceToolStripMenuItem,
            this.setTPiceToolStripMenuItem,
            this.setUTPiceToolStripMenuItem,
            this.setNoenterableToolStripMenuItem,
            this.setNorthwestPiceToolStripMenuItem,
            this.setNortheastPiceToolStripMenuItem,
            this.setSouthwestPiceToolStripMenuItem,
            this.setSoutheastPiceToolStripMenuItem});
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
            // setHorizontalPiceToolStripMenuItem
            // 
            this.setHorizontalPiceToolStripMenuItem.Name = "setHorizontalPiceToolStripMenuItem";
            this.setHorizontalPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setHorizontalPiceToolStripMenuItem.Text = "set horizontal pice";
            this.setHorizontalPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setVerticalPiceToolStripMenuItem
            // 
            this.setVerticalPiceToolStripMenuItem.Name = "setVerticalPiceToolStripMenuItem";
            this.setVerticalPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setVerticalPiceToolStripMenuItem.Text = "set vertical pice";
            this.setVerticalPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setBlankPiceToolStripMenuItem
            // 
            this.setBlankPiceToolStripMenuItem.Name = "setBlankPiceToolStripMenuItem";
            this.setBlankPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setBlankPiceToolStripMenuItem.Text = "set blank pice";
            this.setBlankPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setTPiceToolStripMenuItem
            // 
            this.setTPiceToolStripMenuItem.Name = "setTPiceToolStripMenuItem";
            this.setTPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setTPiceToolStripMenuItem.Text = "set u t pice";
            this.setTPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setUTPiceToolStripMenuItem
            // 
            this.setUTPiceToolStripMenuItem.Name = "setUTPiceToolStripMenuItem";
            this.setUTPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setUTPiceToolStripMenuItem.Text = "set t pice";
            this.setUTPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setNoenterableToolStripMenuItem
            // 
            this.setNoenterableToolStripMenuItem.Name = "setNoenterableToolStripMenuItem";
            this.setNoenterableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNoenterableToolStripMenuItem.Text = "set noenterable pice";
            this.setNoenterableToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setNorthwestPiceToolStripMenuItem
            // 
            this.setNorthwestPiceToolStripMenuItem.Name = "setNorthwestPiceToolStripMenuItem";
            this.setNorthwestPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNorthwestPiceToolStripMenuItem.Text = "set northwest pice";
            this.setNorthwestPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setNortheastPiceToolStripMenuItem
            // 
            this.setNortheastPiceToolStripMenuItem.Name = "setNortheastPiceToolStripMenuItem";
            this.setNortheastPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setNortheastPiceToolStripMenuItem.Text = "set northeast pice";
            this.setNortheastPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setSouthwestPiceToolStripMenuItem
            // 
            this.setSouthwestPiceToolStripMenuItem.Name = "setSouthwestPiceToolStripMenuItem";
            this.setSouthwestPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSouthwestPiceToolStripMenuItem.Text = "set southwest pice";
            this.setSouthwestPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
            // 
            // setSoutheastPiceToolStripMenuItem
            // 
            this.setSoutheastPiceToolStripMenuItem.Name = "setSoutheastPiceToolStripMenuItem";
            this.setSoutheastPiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSoutheastPiceToolStripMenuItem.Text = "set southeast pice";
            this.setSoutheastPiceToolStripMenuItem.Click += new System.EventHandler(this.changepice);
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
        private System.Windows.Forms.ToolStripMenuItem setHorizontalPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setVerticalPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBlankPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUTPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNoenterableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNorthwestPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNortheastPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSouthwestPiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSoutheastPiceToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}