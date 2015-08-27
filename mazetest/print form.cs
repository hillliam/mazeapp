using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace mazetest
{
    public partial class print_form : Form
    {
        public int space = 25;
        public int linethicness = 4;
        public bool spath = false;
		public bool bpath = false;
        public print_form()
        {
            InitializeComponent();
            this.printPreviewControl1.Document = printDocument1;
            this.textBox1.Text = space.ToString();
            this.textBox2.Text = linethicness.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog a = new PrintDialog();
            a.Document = printDocument1;
            if (a.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.DocumentName = "maze map";
                this.printDocument1.PrinterSettings = a.PrinterSettings;
                this.printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int locationx = 20;
            int locationy = 30;
            for (int i = 0; i < Form1.mazesize; i++)
            {
                locationy = 30;
                for (int j = 0; j < Form1.mazesize; j++)
                {
                    locationy += space;
                    Form1.map[i, j].print(locationx, locationy, space, linethicness, spath, bpath, e);
                }
                locationx += space;
            }
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), 20, locationy + space + 10, space, space);
            e.Graphics.DrawString("this is the piece the player starts at", Font, new SolidBrush(Color.Black), 20 + space, locationx + space + 10);
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), 20, locationy + space * 2 + 10, space, space);
            e.Graphics.DrawString("this is the piece you have to reach", Font, new SolidBrush(Color.Black), 20 + space, locationx + space * 2 + 10);
            if (spath)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), 20, locationy + space * 3 + 10, space, space);
                e.Graphics.DrawString("this is the piece where you have being", Font, new SolidBrush(Color.Black), 20 + space, locationx + space * 3 + 10);
            }
			if (bpath)
			{
				e.Graphics.FillRectangle(new SolidBrush(Color.Gold), 20, locationy + space * 4 + 10, space, space);
				e.Graphics.DrawString("this is the piece where you have being", Font, new SolidBrush(Color.Black), 20 + space, locationx + space * 4 + 10);
			}
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.space = int.Parse(textBox1.Text);
                this.printPreviewControl1.Document = printDocument1;
            }
            catch (Exception exception)
            { 
                
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.linethicness = int.Parse(textBox2.Text);
                this.printPreviewControl1.Document = printDocument1;
            }
            catch (Exception exception)
            {

            }
        }
        private void print_form_Resize(object sender, EventArgs e)
        {
            this.printPreviewControl1.Size = new Size (this.Size.Width - this.printPreviewControl1.Location.Y, this.Size.Height - 100 - this.printPreviewControl1.Location.X);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "landscape")
            {
                this.printDocument1.DefaultPageSettings.Landscape = true;
                this.button2.Text = "portrait";
                this.printPreviewControl1.Document = printDocument1;
            }
            else if (this.button2.Text == "portrait")
            {
                this.printDocument1.DefaultPageSettings.Landscape = false;
                this.button2.Text = "landscape";
                this.printPreviewControl1.Document = printDocument1;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                spath = true;
            }
            else
            {
                spath = false;
            }
            this.printPreviewControl1.Document = printDocument1;
        }
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				bpath = true;
			}
			else
			{
				bpath = false;
			}
			this.printPreviewControl1.Document = printDocument1;
		}
    }
}
