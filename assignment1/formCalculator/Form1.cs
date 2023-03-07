namespace proj2
{
    public partial class Form1 : Form
    {
        private string fiNum;
        private string seNum;
        private int fi = 0;
        private int se = 0;
        private int re = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cl_click(object sender, EventArgs e)
        {
            textBox3.Text = re.ToString();
        }

        private void plus_click(object sender, EventArgs e)
        {
            re = fi + se;
        }

        private void minus_click(object sender, EventArgs e)
        {
            re = fi - se;
        }

        private void divide_click(object sender, EventArgs e)
        {
            re = fi / se;
        }

        private void times_click(object sender, EventArgs e)
        {
            re = fi * se;
        }

        private void fiNum_changed(object sender, EventArgs e)
        {
            fiNum = textBox1.Text;
            fi = Int32.Parse(fiNum);
        }

        private void seNum_changed(object sender, EventArgs e)
        {
            seNum = textBox2.Text;
            se = Int32.Parse(seNum);
        }

        private void result(object sender, EventArgs e)
        {
            
        }
    }
}