namespace Phone_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            uC_AddNewPhone2.Visible = false;
            uC_Customers1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CustomerRecords1.Visible = false;
            uC_DeletePhoneRecords1.Visible = false;

            enableDisable(false, false, false);
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone2.Visible = true;
            uC_AddNewPhone2.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            uC_Customers1.Visible = true;
            uC_Customers1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void uC_Stock1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = true;
            uC_CustomerRecords1.BringToFront();
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            enableDisable(true, true, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            enableDisable(false, false, false);
            btnAddNewPhone.PerformClick();
        }

        //***************************** REQUIRED METHOD*****************************
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123")
            {
                panel2.Visible = true;
                uC_DeletePhoneRecords1.Visible = true;
                uC_DeletePhoneRecords1.BringToFront();
                enableDisable(false, false, false);
                txtPassword.Clear();
            }
            else
            {
                txtPassword.Clear();
            }
        }

        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAddNewPhone.PerformClick();
        }
    }
}