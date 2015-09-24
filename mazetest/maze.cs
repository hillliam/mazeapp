// Copyright © Liam hill 2013
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace mazetest
{
    public class maze : UserControl
    {
        private bool playerison = false;
        private bool endpoint = false;
        public int distance = 10000;
        private bool bestpath = false;
        public bool drawbestpath = false;
        public bool best_path
        {
            get
            {
                return bestpath;
            }
            set
            {
                bestpath = value;
                this.Invalidate();
            }
        }
        public bool player_is_on
        {
            get
            {
                return playerison;
            }
            set
            {
                playerison = value;
                this.Invalidate();
            }
        }
        public bool end_point
        {
            get
            {
                return endpoint;
            }
            set
            {
                endpoint = value;
                this.Invalidate();
            }
        }
        public int noticesize = 15; // make the end position and where the player is more noticible.
        public int normalsize = 10; // the normal size of the piece
        private GraphicsPath mazepiece = null;
        private maze_piece piecetype = maze_piece.all;
        private bool hasbeing = false;
        public bool has_being
        {
            get
            {
                return hasbeing;
            }
            set
            {
                hasbeing = value;
                this.Invalidate();
            }
        }
        public bool drawpath = false;
        private Color basecolour = Color.Wheat;
        public Color defaultcolour
        {
            get
            {
                return basecolour;
            }
            set
            {
                basecolour = value;
                this.Invalidate();
            }
        }
        public maze_piece type
        {
            get
            {
                return piecetype;
            }
            set
            {
                piecetype = value;
                this.Invalidate();// need to make the object redraw every time a varible is changed
            }
        }
        public maze()
        {
            this.Visible = true;
            this.Enabled = true;
            this.mazepiece = new GraphicsPath();
            this.Size = new Size(normalsize, normalsize);
            this.BackColor = basecolour;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (mazepiece != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                bool uselarge = false;
                if (bestpath && drawbestpath)
                {
                    if (endpoint || playerison)
                    {
                    }
                    else
                    {
                        this.BackColor = Color.Gold;
                        this.Size = new System.Drawing.Size(noticesize, noticesize);
                        uselarge = true;
                    }
                }
                if (playerison && endpoint)
                {
                    this.BackColor = Color.Plum;
                    this.Size = new System.Drawing.Size(noticesize, noticesize);
                    uselarge = true;
                }


                else if (playerison && hasbeing)
                {
                    this.BackColor = Color.Blue;
                    this.Size = new System.Drawing.Size(noticesize, noticesize);
                    uselarge = true;
                }
                else if (hasbeing && drawpath)
                {
                    this.BackColor = Color.Red;
                    this.Size = new System.Drawing.Size(noticesize, noticesize);
                    uselarge = true;
                }
                else if (playerison)
                {
                    this.BackColor = Color.Blue;
                    this.Size = new System.Drawing.Size(noticesize, noticesize);
                    uselarge = true;
                }
                else if (endpoint)
                {
                    this.BackColor = Color.Green;
                    this.Size = new System.Drawing.Size(noticesize, noticesize);
                    uselarge = true;
                }
                if (uselarge)
                {
                    switch (piecetype)
                    {
                        case maze_piece.all:
                            break;
                        case maze_piece.east:
                            Rectangle a = new Rectangle(new Point(0, 0), new Size(15, 4));
                            Rectangle b = new Rectangle(new Point(0, 11), new Size(15, 4));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), a);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), b);
                            break;
                        case maze_piece.eastwastnorth:
                            Rectangle f = new Rectangle(new Point(0, 11), new Size(15, 4));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), f);
                            break;
                        case maze_piece.eastwestsouth:
                            Rectangle g = new Rectangle(new Point(0, 0), new Size(15, 4));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), g);
                            break;
                        case maze_piece.north:
                            Rectangle c = new Rectangle(new Point(0, 0), new Size(4, 15));
                            Rectangle d = new Rectangle(new Point(11, 0), new Size(4, 15));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), c);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), d);
                            break;
                        case maze_piece.northeast:
                            Rectangle h = new Rectangle(new Point(0, 0), new Size(4, 15));
                            Rectangle i = new Rectangle(new Point(0, 0), new Size(15, 4));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), h);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), i);
                            break;
                        case maze_piece.northwest:
                            Rectangle j = new Rectangle(new Point(11, 0), new Size(4, 15));
                            Rectangle k = new Rectangle(new Point(0, 0), new Size(15, 4));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), j);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), k);
                            break;
                        case maze_piece.southeast:
                            Rectangle l = new Rectangle(new Point(0, 11), new Size(15, 4));
                            Rectangle m = new Rectangle(new Point(0, 0), new Size(4, 15));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), l);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), m);
                            break;
                        case maze_piece.southwest:
                            Rectangle n = new Rectangle(new Point(0, 11), new Size(15, 4));
                            Rectangle o = new Rectangle(new Point(11, 0), new Size(4, 15));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), n);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), o);
                            break;
                        case maze_piece.noenterable:
                            MessageBox.Show("this pice cannot be used with the player start or end position", "please use a diffrent maze pice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.piecetype = maze_piece.all;
                            break;
                    }
                }
                else
                {
                    this.BackColor = basecolour;
                    this.Size = new Size(normalsize, normalsize);
                    switch (piecetype)
                    {
                        case maze_piece.all:
                            break;
                        case maze_piece.east:
                            Rectangle a = new Rectangle(new Point(0, 0), new Size(10, 3));
                            Rectangle b = new Rectangle(new Point(0, 7), new Size(10, 3));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), a);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), b);
                            break;
                        case maze_piece.eastwastnorth:
                            Rectangle f = new Rectangle(new Point(0, 7), new Size(10, 3));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), f);
                            break;
                        case maze_piece.eastwestsouth:
                            Rectangle g = new Rectangle(new Point(0, 0), new Size(10, 3));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), g);
                            break;
                        case maze_piece.north:
                            Rectangle c = new Rectangle(new Point(0, 0), new Size(3, 10));
                            Rectangle d = new Rectangle(new Point(7, 0), new Size(3, 10));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), c);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), d);
                            break;
                        case maze_piece.northeast:
                            Rectangle h = new Rectangle(new Point(0, 0), new Size(3, 10));
                            Rectangle i = new Rectangle(new Point(0, 0), new Size(10, 3));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), h);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), i);
                            break;
                        case maze_piece.northwest:
                            Rectangle j = new Rectangle(new Point(0, 0), new Size(10, 3));
                            Rectangle k = new Rectangle(new Point(7, 0), new Size(3, 10));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), j);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), k);
                            break;
                        case maze_piece.southeast:
                            Rectangle l = new Rectangle(new Point(0, 7), new Size(10, 3));
                            Rectangle m = new Rectangle(new Point(0, 0), new Size(3, 10));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), l);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), m);
                            break;
                        case maze_piece.southwest:
                            Rectangle n = new Rectangle(new Point(0, 7), new Size(10, 3));
                            Rectangle o = new Rectangle(new Point(7, 0), new Size(3, 10));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), n);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), o);
                            break;
                        case maze_piece.noenterable:
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black),this.ClientRectangle);
                            /*Rectangle p = new Rectangle(new Point(0, 0), new Size(3, 10));
                            Rectangle q = new Rectangle(new Point(7, 0), new Size(3, 10));
                            Rectangle r = new Rectangle(new Point(0, 0), new Size(10, 3));
                            Rectangle s = new Rectangle(new Point(0, 7), new Size(10, 3));
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), p);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), q);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), r);
                            e.Graphics.FillRectangle(new SolidBrush(Color.Black), s);*/
                            break;
                    }
                }
            }
        }
        public void print(int x, int y,int size, int linethicness, bool spath,bool bpath, PrintPageEventArgs e)
        {
            if (mazepiece != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                if (playerison)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), p);
                }
                if (endpoint)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Green), p);
                }
                if (hasbeing && spath)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), p);
                }
                if (bestpath && bpath)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Gold), p);
                }
                if (hasbeing && spath && playerison)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), p);
                }
                if (bestpath && bpath && playerison)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), p);
                }
                if (playerison && endpoint)
                {
                    Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                    e.Graphics.FillRectangle(new SolidBrush(Color.Plum), p);
                }
                switch (piecetype)
                {
                    case maze_piece.all:
                        break;
                    case maze_piece.east:
                        Rectangle a = new Rectangle(new Point(x + 0, y + 0), new Size(size, linethicness));
                        Rectangle b = new Rectangle(new Point(x + 0, y + size - linethicness), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), a);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), b);
                        break;
                    case maze_piece.eastwastnorth:
                        Rectangle f = new Rectangle(new Point(x + 0, y + size - linethicness), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), f);
                        break;
                    case maze_piece.eastwestsouth:
                        Rectangle g = new Rectangle(new Point(x + 0, y + 0), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), g);
                        break;
                    case maze_piece.north:
                        Rectangle c = new Rectangle(new Point(x + 0, y + 0), new Size(linethicness, size));
                        Rectangle d = new Rectangle(new Point(x + size - linethicness, y + 0), new Size(linethicness, size));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), c);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), d);
                        break;
                    case maze_piece.northeast:
                        Rectangle h = new Rectangle(new Point(x + 0, y + 0), new Size(linethicness, size));
                        Rectangle i = new Rectangle(new Point(x + 0, y + 0), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), h);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), i);
                        break;
                    case maze_piece.northwest:
                        Rectangle j = new Rectangle(new Point(x + size - linethicness, y + 0), new Size(linethicness, size));
                        Rectangle k = new Rectangle(new Point(x + 0, y + 0), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), j);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), k);
                        break;
                    case maze_piece.southeast:
                        Rectangle l = new Rectangle(new Point(x + 0, y + size - linethicness), new Size(size, linethicness));
                        Rectangle m = new Rectangle(new Point(x + 0, y + 0), new Size(linethicness, size));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), l);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), m);
                        break;
                    case maze_piece.southwest:
                        Rectangle n = new Rectangle(new Point(x + 0, y + size - linethicness), new Size(size, linethicness));
                        Rectangle o = new Rectangle(new Point(x + size - linethicness, y + 0), new Size(linethicness, size));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), n);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), o);
                        break;
                    case maze_piece.noenterable:
                        Rectangle p = new Rectangle(new Point(x + 0, y + 0), new Size(size, size));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), p);
                        /*Rectangle q = new Rectangle(new Point(x + 0, y + 0), new Size(linethicness, size));
                        Rectangle r = new Rectangle(new Point(x + size - linethicness, y + 0), new Size(linethicness, size));
                        Rectangle s = new Rectangle(new Point(x + 0, y + 0), new Size(size, linethicness));
                        Rectangle t = new Rectangle(new Point(x + 0, y + size - linethicness), new Size(size, linethicness));
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), q);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), r);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), s);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), t);*/
                        break;
                }
            }
        }
        /* moved to inside onpaint event
        protected void setpiece()
        {
            bool uselarge = false;
            if (player_is_on)
            {
                this.BackColor = Color.Blue;
                this.Size = new System.Drawing.Size(noticesize, noticesize);
                uselarge = true;
            }
            if (end_point)
            {
                this.BackColor = Color.Green;
                this.Size = new System.Drawing.Size(noticesize, noticesize);
                uselarge = true;
            }
            if (uselarge)
            {
                switch (type)
                {
                    case maze_piece.all:
                        break;
                    case maze_piece.east:
                        Rectangle a = new Rectangle(new Point(0,0),new Size(10,3));
                        Rectangle b = new Rectangle(new Point(7,0), new Size(10, 2));
                        mazepiece.AddRectangle(a);
                        mazepiece.AddRectangle(b);
                        break;
                    case maze_piece.eastwastnorth:
                        break;
                    case maze_piece.eastwestsouth:
                        break;
                    case maze_piece.north:
                        break;
                }
            }
            else
            {
                this.Size = new Size(normalsize, normalsize);
                switch (type)
                {
                    case maze_piece.all:
                        break;
                    case maze_piece.east:
                        Rectangle a = new Rectangle(new Point(0,0),new Size(5,15));
                        Rectangle b = new Rectangle(new Point(5, 0), new Size(5, 15));
                        mazepiece.AddRectangle(a);
                        mazepiece.AddRectangle(b);
                        break;
                    case maze_piece.eastwastnorth:
                        break;
                    case maze_piece.eastwestsouth:
                        break;
                    case maze_piece.north:
                        break;
                    case maze_piece.noenterable:
                        mazepice.AddRectangle(this.ClientRectangle);
                        mazepiece.FillMode = FillMode.Winding;
                        break;
                }
            }
            
        }*/
    }
}
