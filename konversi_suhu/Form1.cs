namespace konversi_suhu
{
    public partial class Form1 : Form
    {
        double c, f, r, k;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcelci_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkonversi_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(txtcelci.Text);
            r = (c * 4) / 5;
            f = (c * 9 / 5) + 32;
            k = (c + 273);
            txtfahrein.Text = Convert.ToString(f);
            txtream.Text = Convert.ToString(r);
            txtkelv.Text = Convert.ToString(k);
        }

        private void btnpanas_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(txtcelci.Text);
            c = c + 3;
            r = c * 4 / 5;
            f = c * 9 / 5 + 32;
            k = c + 273;
            txtcelci.Text = Convert.ToString(c);
            txtfahrein.Text = Convert.ToString(f);
            txtream.Text = Convert.ToString(r);
            txtkelv.Text = Convert.ToString(k);
        }

        private void btndingin_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(txtcelci.Text);
            c = c - 3;
            r = c * 4 / 5;
            f = c * 9 / 5 + 32;
            k = c + 273;
            txtcelci.Text = Convert.ToString(c);
            txtfahrein.Text = Convert.ToString(f);
            txtream.Text = Convert.ToString(r);
            txtkelv.Text = Convert.ToString(k);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcelci.Text = "";
            txtfahrein.Text = "";
            txtream.Text = "";
            txtkelv.Text = "";
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Pilihan anda ?", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                result = MessageBox.Show("Anda yakin ingin keluar", "pilihan", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {

                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
