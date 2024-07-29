namespace CSharp_BangCuuChuong
{
    public partial class lblKetQua : Form
    {
        public lblKetQua()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtSo.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i).ToString();
                listBox1.Items.Add(so.ToString() + " x " + i.ToString() + " = " + (so * i).ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
