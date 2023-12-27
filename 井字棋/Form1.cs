namespace 井字棋
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*this.FormBorderStyle = FormBorderStyle.None;*/
            this.BackColor = Color.White; // 背景颜色为黑色
            this.Opacity = 0.9; // 设置窗口透明度为90%
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
            clickedTimes++;
            button1.Enabled = false;
        }

        int clickedTimes = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            clickedTimes++;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            clickedTimes++;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            clickedTimes++;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            clickedTimes++;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            clickedTimes++;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            clickedTimes++;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            clickedTimes++;
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clickedTimes % 2 == 1)
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            clickedTimes++;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Controls["button" + (i + 1)].Text = "";
                Controls["button" + (i + 1)].Enabled = true;
            }
            label1.Text = "开始游戏";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
