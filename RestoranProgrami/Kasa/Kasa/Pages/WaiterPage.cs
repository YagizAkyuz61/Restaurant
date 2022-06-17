using Kasa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa.Pages
{
    public partial class WaiterPage : Form
    {
        public WaiterPage()
        {
            InitializeComponent();
            List();
        }

        public async void List()
        {
            var waiter = await ApiService.GetWaiter();
            dataGridView1.DataSource = waiter;
        }

        public void ClearTXT()
        {
            nameTXT.Clear();
            surTXT.Clear();
            nickTXT.Clear();
            passTXT.Clear();
            genderCB.Text = "Cinsiyet seçin...";
        }

        private async void addBTN_Click(object sender, EventArgs e)
        {
            var response = await ApiService.RegisterWaiter(nameTXT.Text, surTXT.Text, nickTXT.Text, passTXT.Text, genderCB.Text);
            {
                if(response)
                {
                    MessageBox.Show("Kayıt başarılı.", "TAMAMDIR");
                    ClearTXT();
                    List();
                }
                else
                    MessageBox.Show("BAŞARISIZ", "BAŞARISIZ");
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            ClearTXT();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void updateBTN_Click(object sender, EventArgs e)
        {
            var response = await ApiService.WaiterUpdate(Convert.ToInt32(idTXT.Text), nameTXT.Text, surTXT.Text, nickTXT.Text, genderCB.Text);
            MessageBox.Show("Güncelleme başarılı.");
            //ClearTXT();
            //idTXT.Clear();
            List();
        }

        private async void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await ApiService.WaiterDelete(Convert.ToInt32(idTXT.Text));
                MessageBox.Show("Silme başarılı.");
                ClearTXT();
                idTXT.Clear();
                List();
            }
            catch (Exception errormsg)
            {
                MessageBox.Show(errormsg.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            idTXT.Text = selectedRow.Cells[0].Value.ToString();
            nameTXT.Text = selectedRow.Cells[1].Value.ToString();
            surTXT.Text = selectedRow.Cells[2].Value.ToString();
            nickTXT.Text = selectedRow.Cells[3].Value.ToString();
            genderCB.Text = selectedRow.Cells[5].Value.ToString();
        }
    }
}
