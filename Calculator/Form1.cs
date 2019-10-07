using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        /*
         This took a while to make and implement the switching of the forms but it worked eventually. The game kind of starts to not be able to handle all the rendering 
         past a score of 15 so if you get that high bear that in mind.
         */

        Random rnd = new Random();
        int direction;
        int locationx;
        int locationy;

        // Snake block location lists
        List<int> snakeLocationx = new List<int> { 250, 240, 230 };
        List<int> snakeLocationy = new List<int> { 250, 240, 230 };

        // item block location lists
        List<int> itemLocationx = new List<int>();
        List<int> itemLocationy = new List<int>();

        int points = 0;
        bool itemTaken = true;
        bool dead;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        // resetting all values
        private void startbtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            direction = rnd.Next(0, 4);
            snakeLocationx.Clear();
            snakeLocationx.Add(250);
            snakeLocationx.Add(240);
            snakeLocationx.Add(230);
            snakeLocationy.Clear();
            snakeLocationy.Add(250);
            snakeLocationy.Add(240);
            snakeLocationy.Add(230);
            itemLocationx.Clear();
            itemLocationy.Clear();
            points = 0;
            pointstxt.Text = "Points: 0";
            itemTaken = true;
            thePanel.Visible = true;
            gameOvertxt.Visible = false;
            pointsGameOvertxt.Visible = false;
            dead = false;
        }

        // the name of there methods make it pretty self explanitory
        private void upbtn_Click(object sender, EventArgs e)
        {
            // i gave an int value numbers 1-4 corresponding to a direction
            if (direction != 2)
            {
                direction = 0;
            }
        }

        private void rightbtn_Click(object sender, EventArgs e)
        {
            if (direction != 3)
            {
                direction = 1;
            }
        }

        private void downbtn_Click(object sender, EventArgs e)
        {
            if (direction != 0)
            {
                direction = 2;
            }
        }

        private void leftbtn_Click(object sender, EventArgs e)
        {
            if (direction != 1)
            {
                direction = 3;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this switch case statement speeds up the snake as your score increases
            switch (points)
            {
                case 3:
                    timer1.Interval = 80;
                    break;
                case 5:
                    timer1.Interval = 70;
                    break;
                case 10:
                    timer1.Interval = 50;
                    break;
                case 15:
                    timer1.Interval = 30;
                    break;
                case 20:
                    timer1.Interval = 15;
                    break;
                case 25:
                    timer1.Interval = 10;
                    break;

            }

            // all the rendering stuff
            if (!dead)
            {
                Console.WriteLine("hello");

                Refresh();
                Graphics g;
                g = thePanel.CreateGraphics();
                Pen p = new Pen(Color.Blue);
                Pen p2 = new Pen(Color.Red);
                p.Width = 10;
                p2.Width = 10;

                locationx = snakeLocationx.ElementAt(0);
                locationy = snakeLocationy.ElementAt(0);

                switch (direction)
                {
                    case 0:
                        locationy -= 10;
                        break;
                    case 1:
                        locationx += 10;
                        break;
                    case 2:
                        locationy += 10;
                        break;
                    case 3:
                        locationx -= 10;
                        break;
                    default:
                        break;
                }

                // adding the new block
                snakeLocationx.Insert(0, locationx);
                snakeLocationy.Insert(0, locationy);

                checkLocation();
                checkCollisionDeath();

                // taking away the end block
                if (!itemTaken)
                {
                    snakeLocationx.RemoveAt(snakeLocationx.Count - 1);
                    snakeLocationy.RemoveAt(snakeLocationy.Count - 1);
                }
                else
                {
                    itemTaken = false;
                }

                // Drawing stuff
                for (int i = 0; i < snakeLocationx.Count; i++)
                {
                    g.DrawRectangle(p, snakeLocationx.ElementAt(i), snakeLocationy.ElementAt(i), 5, 5);
                }

                for (int i = 0; i < itemLocationx.Count; i++)
                {
                    g.DrawRectangle(p2, itemLocationx.ElementAt(i), itemLocationy.ElementAt(i), 5, 5);
                }
            }
        }

        // adds a new item point thing incrementally
        private void itemTimer_Tick(object sender, EventArgs e)
        {
            int newItemx = rnd.Next(20, thePanel.Width - 20);
            int newItemy = rnd.Next(20, thePanel.Height - 20);

            itemLocationx.Add(newItemx);
            itemLocationy.Add(newItemy);
        }

        // checks if you collide with an item - reminds me of the collision in the hardest game in the world
        private void checkLocation()
        {
            for (int i = 0; i < itemLocationx.Count; i++)
            {
                if (snakeLocationx.ElementAt(0) >= itemLocationx.ElementAt(i) - 12 && snakeLocationx.ElementAt(0) <= itemLocationx.ElementAt(i) + 12)
                {
                    if (snakeLocationy.ElementAt(0) >= itemLocationy.ElementAt(i) - 12 && snakeLocationy.ElementAt(0) <= itemLocationy.ElementAt(i) + 12)
                    {
                        itemLocationx.RemoveAt(i);
                        itemLocationy.RemoveAt(i);
                        points += 1;
                        pointstxt.Text = "Points: " + points.ToString();
                        itemTaken = true;
                    }
                }
            }
        }


        // checks f you collide with yourself or a wall
        private void checkCollisionDeath()
        {
            for (int i = 1; i < snakeLocationx.Count; i++)
            {
                if (snakeLocationx.ElementAt(0) >= snakeLocationx.ElementAt(i) - 8 && snakeLocationx.ElementAt(0) <= snakeLocationx.ElementAt(i) + 8)
                {
                    if (snakeLocationy.ElementAt(0) >= snakeLocationy.ElementAt(i) - 8 && snakeLocationy.ElementAt(0) <= snakeLocationy.ElementAt(i) + 8)
                    {
                        dead = true;
                        pointstxt.Text = "";
                        gameOvertxt.Visible = true;
                        gameOvertxt.Text = "Game Over";
                        pointsGameOvertxt.Visible = true;
                        pointsGameOvertxt.Text = "Points: " + points.ToString();
                    }
                }
            }
            if (snakeLocationx.ElementAt(0) < 0 || snakeLocationx.ElementAt(0) > thePanel.Width - 10 || snakeLocationy.ElementAt(0) < 0 || snakeLocationy.ElementAt(0) > thePanel.Height - 10)
            {
                dead = true;
                pointstxt.Text = "";
                gameOvertxt.Visible = true;
                gameOvertxt.Text = "Game Over";
                pointsGameOvertxt.Visible = true;
                pointsGameOvertxt.Text = "Points: " + points.ToString();
            }
        }

        // closes the game
        private void calcbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
