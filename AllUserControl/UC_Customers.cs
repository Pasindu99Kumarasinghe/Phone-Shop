using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Shop.AllUserControl
{
    public partial class UC_Customers : UserControl
    {
        function fn = new function();
        String query;

        public UC_Customers()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cname = txtCompany.Text;
            query = "select mname from newMobile where cname ='" + cname + "'";
            setComboBOX(query, txtModel);

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where mname = '" + txtModel.Text + "'";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtImei.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
                String address = txtAddress.Text;
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String imei = txtImei.Text;

                query = "insert into customerPurchase (cname,gender,contact,email,caddress,company,model,imei) values ('" + name + "', '" + gender + "', " + contact + ", '" + email + "', '" + address + "', '" + company + "', '" + model + "', '" + imei + "')";
                fn.setData(query);

                txtName.Clear();
                txtGender.SelectedIndex = -1;
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtImei.Clear();

            }
            else
            {
                MessageBox.Show("Fill All the Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //*********************** REQUIRED METHODS *****************************

        public void setComboBOX(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query); // select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void UC_Customers_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            setComboBOX(query, txtCompany);
        }
    }
}
