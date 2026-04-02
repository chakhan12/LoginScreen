namespace LoginScreen
{
    public partial class lblAppName : Form
    {
        public lblAppName()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)

        {



        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }

        }
        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;


            }
        }

        private void lblAppName_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string myID = "1234";
            string myPW = "yuiop";

           
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

          
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("로그인 실패~", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
