using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_04_Ticketing.MasterForm
{
    public partial class FormMasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FormMasterKodePromo()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_kode_promo" +
                    "(kode,berlaku_sampai,presentase_diskon,maksimum_diskon,deskripsi)" + "VALUES" + "('" + txtKode_Promo.Text + "','" + txtBerlaku_sampai.Text + "'," + "'" + txtPresentase_diskon.Text + "','" + txtMaksimum_diskon.Text + "','" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data kode promo");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_kode_promo", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_kode_promo WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil DiHapus Cuy");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil DiHapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }

        private void FormMasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void txtBerlaku_sampai_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}




