using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMangementSystem.AllUserControl
{
    public partial class UC_CustomerChechOut : UserControl
    {
        function fn = new function();
        String query;

        public UC_CustomerChechOut()
        {
            InitializeComponent();
        }

        private void UC_CustomerChechOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join  rooms on customer.roomid = rooms.roomid where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join  rooms on customer.roomid = rooms.roomid where cname like '"+txtName.Text+"%' and chekout = 'No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(); 
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "")
            {
                if(MessageBox.Show("Bu işlemi gerçekleştirmek istediğinizden emin misiniz?","Onay Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES',checkout = '"+cdate+"' where cid = "+id+" update rooms set booked='NO' where roomNo = '"+txtRoomNo.Text+"' ";
                    fn.setData(query, "Check Out işlemi başarılı.");
                    UC_CustomerChechOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerChechOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

    }
}
