// Copyright © Liam hill 2013
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace mazetest
{
    public partial class create : Form
    {
        public static int mazesize = 30;
        public maze[,] map = new maze[mazesize, mazesize];// fixed map size
        private int selectedpiecex;
        private int selectedpiecey;
        public int space = 15;
        public bool pathfind = false;
        public create()
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
                    map[i, j].MouseClick += new MouseEventHandler(this.showeditoptions);
                    map[i, j].BorderStyle = BorderStyle.None;
                    this.Controls.Add(map[i, j]);
                }
                locationx += space;
            }
            this.KeyPreview = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.editmode = false;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {//save
            bool hasplayer = false;
            bool hasend = false;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].player_is_on)
                    {
                        hasplayer = true;
                    }
                    if (map[i, j].end_point)
                    {
                        hasend = true;
                    }
                }
            }
            if (hasplayer && hasend)
            {
                if (cancompleatemaze() == false)
                {
                    if (MessageBox.Show("the maze is not compleatable do you want to save the maze", "save warning", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                }
                SaveFileDialog a = new SaveFileDialog();
                a.AddExtension = true;
                a.DefaultExt = "maze";
                a.Filter = "maze file (*.maze)|*.maze";
                if (a.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter b = new StreamWriter(a.FileName);
                    for (int i = 0; i < mazesize; i++)
                    {
                        for (int j = 0; j < mazesize; j++)
                        {
                            b.WriteLine(map[i, j].type);
                            b.WriteLine(map[i, j].player_is_on);
                            b.WriteLine(map[i, j].end_point);
                        }
                    }
                    b.Close();
                }
            }
            else
            {
                MessageBox.Show("please set a start and end position", "save failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {//load
            OpenFileDialog a = new OpenFileDialog();
            a.AddExtension = true;
            a.DefaultExt = "maze";
            a.Filter = "maze file (*.maze)|*.maze";
            if (a.ShowDialog() == DialogResult.OK)
            {
                StreamReader b = new StreamReader(a.FileName);
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i, j].type = (maze_piece) Enum.Parse(typeof(maze_piecr),b.ReadLine());
                        map[i, j].player_is_on = bool.Parse(b.ReadLine());
                        map[i, j].end_point = bool.Parse(b.ReadLine());
                    }
                }
                b.Close();
            }
            showbestpath();
        }
        private void button4_Click(object sender, EventArgs e)
        {//randomly generate new map
            randomstart();
            int x = 0;
            int y = 0;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].end_point)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            while (map[x, y].distance == 10000)
            {
                showbestpath();
                rerandom();
            }
        }
        private void create_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void create_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.editmode = false;
        }
        private void showeditoptions(object s, MouseEventArgs e)
        {
            if (s != null)
            {
                maze a;
                a = (maze)s;
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        if (map[i, j] == a)
                        {
                            selectedpiecex = i;
                            selectedpiecey = j;
                        }

                    }
                }
            }
            contextMenuStrip1.Show(MousePosition);
        }
        private void setFinishPiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void setPlayerPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    map[i, j].player_is_on = false;
                }
            }
            map[selectedpiecex, selectedpiecey].player_is_on = true;
            showbestpath();
        }
        private void setEndPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    map[i, j].end_point = false;

                }
            }
            map[selectedpiecex, selectedpiecey].end_point = true;
            showbestpath();
        }
        private void changepiece(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ToolStripMenuItem a;
                a = (ToolStripMenuItem)sender;
                switch (a.Text)
                {
                    case "set vertical piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.north;
                        break;
                    case "set horizontal piece":
                        map[selectedpiecex, selectedpicey].type = maze_piece.east;
                        break;
                    case "set blank piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.all;
                        break;
                    case "set u t piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.eastwastnorth;
                        break;
                    case "set t piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.eastwestsouth;
                        break;
                    case "set noenterable piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.noenterable;
                        break;
                    case "set northwest piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.northwest;
                        break;
                    case "set northeast piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.northeast;
                        break;
                    case "set southwest piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.southwest;
                        break;
                    case "set southeast piece":
                        map[selectedpiecex, selectedpiecey].type = maze_piece.southeast;
                        break;

                }
            }
            showbestpath();
        }
        private void create_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showbestpath()
        {
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    map[i, j].best_path = false;
                    map[i, j].distance = 10000;
                }
            }
            Pathfind();
            if (pathfind)
            {
                HighlightPath();
            }
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].end_point)
                    {
                        if (map[i, j].distance != 10000)
                        {
                            label2.Text = map[i, j].distance.ToString();
                        }
                        else
                        {
                            label2.Text = "imposible";
                        }
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
                        if (map[i, j].distance != 10000)
                        {
                            label2.Text = map[i, j].distance.ToString();
                        }
                        else
                        {
                            label2.Text = "imposible";
                        }
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
                case maze_piece.all:
                case maze_piece.north:
                case maze_piece.eastwastnorth:
                case maze_piece.southeast:
                case maze_piece.southwest:
                    if (tox == startx && toy == starty - 1)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_piece.all:
                            case maze_piece.north:
                            case maze_piece.eastwestsouth:
                            case maze_piece.northeast:
                            case maze_piece.northwest:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_piece.all:
                case maze_piece.east:
                case maze_piece.eastwestsouth:
                case maze_piece.eastwastnorth:
                case maze_piece.northwest:
                case maze_piece.southwest:
                    if (tox == startx - 1 && toy == starty)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_piece.all:
                            case maze_piece.east:
                            case maze_piece.eastwastnorth:
                            case maze_piece.eastwestsouth:
                            case maze_piece.southeast:
                            case maze_piece.northeast:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_piece.all:
                case maze_piece.north:
                case maze_piece.eastwestsouth:
                case maze_piece.northeast:
                case maze_piece.northwest:
                    if (tox == startx && toy == starty + 1)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_piece.all:
                            case maze_piece.north:
                            case maze_piece.eastwastnorth:
                            case maze_piece.southeast:
                            case maze_piece.southwest:
                                return true;
                        }
                    }
                    break;
            }
            switch (map[startx, starty].type)
            {
                case maze_piece.all:
                case maze_piece.east:
                case maze_piece.eastwestsouth:
                case maze_piece.eastwastnorth:
                case maze_piece.northeast:
                case maze_piece.southeast:
                    if (tox == startx + 1 && toy == starty)
                    {
                        switch (map[tox, toy].type)
                        {
                            case maze_piece.all:
                            case maze_piece.east:
                            case maze_piece.eastwastnorth:
                            case maze_piece.eastwestsouth:
                            case maze_piece.northwest:
                            case maze_piece.southwest:
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
        public bool cancompleatemaze()
        {
            Pathfind();
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].end_point && map[i, j].distance != 10000)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pathfind = true;
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i, j].drawbestpath = true;
                    }
                }
            }
            else
            {
                pathfind = false;
                for (int i = 0; i < mazesize; i++)
                {
                    for (int j = 0; j < mazesize; j++)
                    {
                        map[i, j].drawbestpath = false;
                    }
                }
            }
            showbestpath();
        }
        public void randomstart()
        {
            Random a = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    map[i, j].player_is_on = false;
                    map[i, j].end_point = false;
                }
            }
            map[a.Next(0, mazesize), a.Next(0, mazesize)].player_is_on = true;
            map[a.Next(0, mazesize), a.Next(0, mazesize)].end_point = true;
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    map[i, j].type = (maze_piece)a.Next(0, 10);
                }
            }
        }
        public void rerandom()
        {
            Random a = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < mazesize; i++)
            {
                for (int j = 0; j < mazesize; j++)
                {
                    if (map[i, j].distance == 10000)
                    {
                        map[i, j].type = (maze_piece)a.Next(1, 10);
                    }
                }
            }
        }
    }
}
