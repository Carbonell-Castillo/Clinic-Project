using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class customTextbox : UserControl
    {
        private string label = "";
        private bool isPassword = false;


        private Color controlColor = Color.White;
        private Color labelForeColor = Color.Black;
        private bool multiline = false;

        private Color bottomBorderColor = Color.Black;
        public Color BottomBorderColor
        {
            get { return bottomBorderColor; }
            set
            {
                bottomBorderColor = value;
                textBox1.Invalidate(); // Invalidar el control para repintarlo
            }
        }

        public customTextbox()
        {
            InitializeComponent();
            label = label1.Text;

            textBox1.Paint += textBox1_Paint;

        }



        public bool controlMultiline
        {

            get { return multiline; }
            set
            {

                multiline = value;
                this.Invalidate();

            }
        }
        public Color label_Color
        {

            get { return labelForeColor; }
            set
            {
                labelForeColor = value;
                this.Invalidate();
            }

        }
        public Color color
        {

            get { return controlColor; }
            set
            {
                controlColor = value;
                this.Invalidate();
            }
        }
        public String labelName
        {
            get { return label; }
            set
            {
                label = value;
                this.Invalidate();
            }
        }
        public bool password
        {
            get { return isPassword; }
            set
            {

                isPassword = value;
                this.Invalidate();

            }

        }

        bool isFocused = false;
        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            label1.Enabled = true;

            if (isFocused == false)
            {

                y -= 2;


                label1.Location = new Point(label1.Location.X, y);

                if (y <= 4)
                {
                    labelTimer.Stop();
                    isFocused = true;
                    label1.Font = new Font("Segoe UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;

                }

            }
            else
            {

                y += 2;

                label1.Location = new Point(label1.Location.X, y);
                if (y >= 22)
                {

                    isFocused = false;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoe UI", 10);
                    y = 22;
                    label1.ForeColor = Color.Black;

                }
            }
        }

        private void customTextbox_Click(object sender, EventArgs e)
        {
            labelTimer.Start();
        }

        private void label1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }

        }

        private void customTextbox_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void customTextbox_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Text = labelName;

            if (password == true)
            {

                textBox1.UseSystemPasswordChar = true;

            }


        }
        private void backColor()
        {

            this.BackColor = color;
            label1.BackColor = color;
            textBox1.BackColor = color;
        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(bottomBorderColor))
            {
                int y = textBox1.Height - 1;
                e.Graphics.DrawLine(pen, 0, y, textBox1.Width, y);
            }
        }



        private void customTextbox_Paint(object sender, PaintEventArgs e)
        {

            label1.Text = labelName;
            backColor();
            label1.ForeColor = label_Color;
            if (controlMultiline == true)
            {
                textBox1.Multiline = true;
                textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                textBox1.Height = this.Height;
            }


        }
        public string text;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }
    }
}
