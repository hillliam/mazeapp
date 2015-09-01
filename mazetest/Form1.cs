// Copyright © Liam hill 2013
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace mazetest
{
    public enum maze_pices 
        {
            north,
            east,
            all,
            eastwastnorth,
            eastwestsouth,
            noenterable,
            southeast,
            southwest,
            northeast,
            northwest
        }
    public partial class Form1 : Form
    {
        /* no longer needed
        public static Image inorth = Image.FromFile(Environment.CurrentDirectory + "\\1.png", true); // images working but only on one pice
        public static Image ieast = Image.FromFile(Environment.CurrentDirectory + "\\2.png", true);
        public static Image iall = Image.FromFile(Environment.CurrentDirectory + "\\3.png", true);
        public static Image ieastwestnorth = Image.FromFile(Environment.CurrentDirectory + "\\4.png", true);
        public static Image ieastwestsouth = Image.FromFile(Environment.CurrentDirectory + "\\5.png",true);
        public static Image ifull = Image.FromFile(Environment.CurrentDirectory + "\\6.png", true);
        public static Image inorthl = Image.FromFile(Environment.CurrentDirectory + "\\1l.png", true);
        public static Image ieastl = Image.FromFile(Environment.CurrentDirectory + "\\2l.png", true);
        public static Image ialll = Image.FromFile(Environment.CurrentDirectory + "\\3l.png", true);
        public static Image ieastwestnorthl = Image.FromFile(Environment.CurrentDirectory + "\\4l.png", true);
        public static Image ieastwestsouthl = Image.FromFile(Environment.CurrentDirectory + "\\5l.png", true);*/
        public static bool editmode = false;
        public static int mazesize = 30;
        private int moves = 0;
        public bool win = false;
        public int space = 15;
        public bool spath = false;
        public static maze[,] map = new maze[mazesize, mazesize];// fixed map size
        public Form1()
        {
            InitializeComponent();
            int locationx = 20;
            int locationy = 30;
            for (int i = 0; i < mazesize; i++)
            {
                locationy = 30;
                for (int j = 0; j < mazesize; j++)
                {
                    locationy += space;
                    map[i, j] = new maze();
                    map[i, j].Location = new Point(locationx, locationy);
                    map[i, j].BorderStyle = BorderStyle.None;
                    this.Controls.Add(map[i, j]);
                }
                locationx += space;
            }
            this.KeyPreview = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {//Load map
            OpenFileDialog a = new OpenFileDialog();
            a.AddExtension = true;
            a.DefaultExt = "maze";
            a.Filter = "maze file (*.maze)|*.maze";
            if (a.ShowDialog() == DialogResult.OK)
            {
                win = false;
                StreamReader b = new StreamReader(a.FileName);
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize;j++)
                    {
                        map[i, j].type = (maze_pices)Enum.Parse(typeof(maze_pices), b.ReadLine());
                        map[i,j].player_is_on = bool.Parse(b.ReadLine());
                        map[i, j].end_point = bool.Parse(b.ReadLine());
                    }
                }
                b.Close();
                moves = 0;
                Pathfind();
                HighlightPath();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {//open new form
            create a = new create();
            editmode = true;
            a.Show();
        }
        /* debuging code arrow keys wont work
        protected override bool ProcessCmdKey(ref Message msg, Keys e)
        {
            return base.ProcessCmdKey(ref msg, e);
        }*/
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = moves.ToString();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = 0;
            int y = 0;
            bool canmove = false;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].player_is_on)
                    {
                        x = i;
                        y = j;
                        canmove = true;
                        map[i, j].has_being = true;
                    }
                    if (map[i, j].player_is_on && map[i, j].end_point)
                    {
                        canmove = false;
                        MessageBox.Show("you have already compleated this maze please open a new maze");
                    }
                }
            }
            if (canmove)
            {
                if (e.KeyData == Keys.Up | e.KeyData == Keys.W)
                {
                    if (y != 0)
                    {
                        switch (map[x, y].type)
                        { 
                            case maze_pices.all:
                            case maze_pices.north:
                            case maze_pices.eastwastnorth:
                            case maze_pices.southeast:
                            case maze_pices.southwest:
                                switch(map[x, y - 1].type)
                                {
                                    case maze_pices.all:
                                    case maze_pices.north:
                                    case maze_pices.eastwestsouth:
                                    case maze_pices.northeast:
                                    case maze_pices.northwest:
                                        map[x, y].player_is_on = false;
                                        map[x, y - 1].player_is_on = true;
                                        moves++;
                                        break;
                                }
                                break;
                        }
                        
                    }
                }
                if (e.KeyData == Keys.Left | e.KeyData == Keys.A)
                {
                    if (x != 0)
                    {
                        switch (map[x, y].type)
                        {
                            case maze_pices.all:
                            case maze_pices.east:
                            case maze_pices.eastwestsouth:
                            case maze_pices.eastwastnorth:
                            case maze_pices.northwest:
                            case maze_pices.southwest:
                                switch (map[x - 1, y].type)
                                {
                                    case maze_pices.all:
                                    case maze_pices.east:
                                    case maze_pices.eastwastnorth:
                                    case maze_pices.eastwestsouth:
                                    case maze_pices.southeast:
                                    case maze_pices.northeast:
                                        map[x, y].player_is_on = false;
                                        map[x - 1, y].player_is_on = true;
                                        moves++;
                                        break;
                                }
                                break;
                        }
                    }
                }
                if (e.KeyData == Keys.Down | e.KeyData == Keys.S)
                {
                    if (y != mazesize - 1)
                    {
                        switch (map[x, y].type)
                        {
                            case maze_pices.all:
                            case maze_pices.north:
                            case maze_pices.eastwestsouth:
                            case maze_pices.northeast:
                            case maze_pices.northwest:
                                switch (map[x, y + 1].type)
                                {
                                    case maze_pices.all:
                                    case maze_pices.north:
                                    case maze_pices.eastwastnorth:
                                    case maze_pices.southeast:
                                    case maze_pices.southwest:
                                        map[x, y].player_is_on = false;
                                        map[x, y + 1].player_is_on = true;
                                        moves++;
                                        break;
                                }
                                break;
                        }
                    }
                }
                if (e.KeyData == Keys.Right | e.KeyData == Keys.D)
                {
                    if (x != mazesize - 1)
                    {
                        switch (map[x, y].type)
                        {
                            case maze_pices.all:
                            case maze_pices.east:
                            case maze_pices.eastwestsouth:
                            case maze_pices.eastwastnorth:
                            case maze_pices.northeast:
                            case maze_pices.southeast:
                                switch (map[x + 1, y].type)
                                {
                                    case maze_pices.all:
                                    case maze_pices.east:
                                    case maze_pices.eastwastnorth:
                                    case maze_pices.eastwestsouth:
                                    case maze_pices.northwest:
                                    case maze_pices.southwest:
                                        map[x, y].player_is_on = false;
                                        map[x + 1, y].player_is_on = true;
                                        moves++;
                                        break;
                                }
                                break;
                        }
                    }
                }
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        if (map[i, j].player_is_on && map[i, j].end_point)
                        {
                            win = true;
                            MessageBox.Show("you have reatched the end of the maze in " + moves.ToString() + " moves" + Environment.NewLine + "why not try compleating the maze in " + getbestmoves().ToString() + " moves");
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            a.AllowFullOpen = true;
            a.AnyColor = true;
            if (a.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i,j].defaultcolour = a.Color;
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            print_form a = new print_form();
            a.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int locationx = 20;
            int locationy = 30;
            space = 15;
            for (int i = 0; i < mazesize; i++)
            {
                locationy = 30;
                for (int j = 0; j < mazesize; j++)
                {
                    locationy += space;
                    map[i, j].Location = new Point(locationx, locationy);
                    map[i, j].noticesize = space;
                    map[i, j].normalsize = space;
                }
                locationx += space;
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                spath = true;
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i, j].drawpath = true;
                    }
                }
            }
            else
            {
                spath = false;
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i, j].drawpath = false;
                    }
                }
            }
        }
        public void HighlightPath()
        {
            bool found = false;
            int exitx = 0;
            int exity = 0;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].end_point)
                    {
                        exitx = i;
                        exity = j;
                        found = true;
                    }
                }
            }
            while (found)
            {
                int lowestx = 0;
                int lowesty = 0;
                int lowest = 10000;
                for (int i = 1; i < 5; i++)
                {
                    Point newmove = getmoves(exitx, exity, i);
                    if (ValidMoves(exitx, exity, newmove.X, newmove.Y))
                    {
                        int count = map[newmove.X, newmove.Y].distance;
                        if (count < lowest)
                        {
                            lowest = count;
                            lowestx = newmove.X;
                            lowesty = newmove.Y;
                        }
                    }
                }
                if (lowest != 10000)
                {
                    map[lowestx, lowesty].best_path = true;
                    exitx = lowestx;
                    exity = lowesty;
                }
                else
                {
                    break;
                }
                if (map[exitx, exity].player_is_on == true)
                {
                    break;
                }
            }
        }
        public void Pathfind()
        {
            int startx = 0;
            int starty = 0;
            bool found = false;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].player_is_on)
                    {
                        startx = i;
                        starty = j;
                        found = true;
                        break;
                    }
                }
            }
            if (found)
            {
                map[startx, starty].distance = 0;
                while (true)
                {
                    bool madeProgress = false;

                    for (int i = 0; i < mazesize; i++)
                    {
                        for (int j = 0; j < mazesize; j++)
                        {
                            int x = i;
                            int y = j;
                            int passHere = map[x, y].distance;
                            for (int a = 1; a < 5; a++)
                            {
                                Point newmove = getmoves(x, y, a);
                                if (ValidMoves(x, y, newmove.X, newmove.Y))
                                {
                                    int newPass = passHere + 1;
                                    if (map[newmove.X, newmove.Y].distance > newPass)
                                    {
                                        map[newmove.X, newmove.Y].distance = newPass;
                                        madeProgress = true;
                                    }
                                }
                            }
                        }
                    }
                    if (!madeProgress)
                    {
                        break;
                    }
                }
            }
        }
        private bool ValidMoves(int startx, int starty, int tox, int toy)
        {
            if (tox < 0 || tox > mazesize - 1 || toy < 0 || toy > mazesize - 1)
            {
                return false;
            }
            switch (map[startx, starty].type)
            {
                case maze_pices.all:
                case maze_pices.north:
                case maze_pices.eastwastnorth:
                case maze_pices.southeast:
                case maze_pices.southwest:
                    if (tox == startx && toy == starty - 1)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_pices.all:
                            case maze_pices.north:
                            case maze_pices.eastwestsouth:
                            case maze_pices.northeast:
                            case maze_pices.northwest:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_pices.all:
                case maze_pices.east:
                case maze_pices.eastwestsouth:
                case maze_pices.eastwastnorth:
                case maze_pices.northwest:
                case maze_pices.southwest:
                    if (tox == startx - 1 && toy == starty)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_pices.all:
                            case maze_pices.east:
                            case maze_pices.eastwastnorth:
                            case maze_pices.eastwestsouth:
                            case maze_pices.southeast:
                            case maze_pices.northeast:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_pices.all:
                case maze_pices.north:
                case maze_pices.eastwestsouth:
                case maze_pices.northeast:
                case maze_pices.northwest:
                    if (tox == startx && toy == starty + 1)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_pices.all:
                            case maze_pices.north:
                            case maze_pices.eastwastnorth:
                            case maze_pices.southeast:
                            case maze_pices.southwest:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_pices.all:
                case maze_pices.east:
                case maze_pices.eastwestsouth:
                case maze_pices.eastwastnorth:
                case maze_pices.northeast:
                case maze_pices.southeast:
                    if (tox == startx + 1 && toy == starty)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_pices.all:
                            case maze_pices.east:
                            case maze_pices.eastwastnorth:
                            case maze_pices.eastwestsouth:
                            case maze_pices.northwest:
                            case maze_pices.southwest:
                                return true;
                        }
                    }
                    break;
            }
            return false;
        }
        public Point getmoves(int startx, int starty, int direction)
        {
            switch (direction)
            {
                case 1:
                    return new Point(startx, starty - 1);
                case 2:
                    return new Point(startx - 1, starty);
                case 3:
                    return new Point(startx, starty + 1);
                case 4:
                    return new Point(startx + 1, starty);
            }
            return new Point();
        }
        public int getbestmoves()
        {
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].end_point)
                    {
                        return map[i, j].distance;
                    }
                }
            }
            return 0;
        }
    }
}
