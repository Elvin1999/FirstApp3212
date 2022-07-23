using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            //timer.Start();

            Label loginLbl = new Label();
            loginLbl.Location = new Point(200, 150);
            loginLbl.ForeColor = Color.DeepSkyBlue;
            loginLbl.Text = "Hello new Label";
            loginLbl.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            loginLbl.AutoSize = true;


            this.Controls.Add(loginLbl);

        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
            this.someLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
                Button newbutton = new Button();
                newbutton.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                newbutton.Text = "Click Me";
                newbutton.AutoSize = true;

                newbutton.Click += button1_Click;

                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                newbutton.Location = new Point(randomX, randomY);

                this.Controls.Add(newbutton);


            }
            //someLbl.Text = "Salam siz click elediniz";
            //this.Close();
            // MessageBox.Show("You clicked to button");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Orange;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.DeepSkyBlue;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //var x = e.X;
            //var y = e.Y;
            //someLbl.Text = $"X : {x}  Y : {y}";
            //if(x>=0 && x <= this.Width / 4)
            //{
            //    this.BackColor = Color.Red;
            //}
            //else if(x>this.Width/4 && x <= this.Width / 2)
            //{
            //    this.BackColor = Color.DeepPink;
            //}
            //else if (x > this.Width / 2 && x <= this.Width / 4 * 3)
            //{
            //    this.BackColor = Color.Yellow;
            //}
            //else
            //{
            //    this.BackColor = Color.Orange;
            //}
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.OldLace;
            //MessageBox.Show("Down Click");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            someLbl.Text = "I entered to the Form";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            someLbl.Text = "I leaved from Form";
        }
    }
}
