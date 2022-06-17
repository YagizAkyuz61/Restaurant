using Kasa.Model;
using Kasa.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa.Pages
{
    public partial class FoodPage : Form
    {
       
        public FoodPage()
        {
            InitializeComponent();
        }

        private void FoodPage_Load(object sender, EventArgs e)
        {
            List();
        }

        private void FoodPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        public async void List()
        {
            var food = await ApiService.GetFood();
            fDGV.DataSource = food;

            var category = await ApiService.GetCategory();
            cDGV.DataSource = category;

            var table = await ApiService.GetTable();
            tDGV.DataSource = table;
        }

        private async void fInsertBTN_Click(object sender, EventArgs e)
        {
            var food = new FoodClass();
            food.FoodName = fFoodTXT.Text;
            food.CategoryId = Convert.ToInt32(fCategoryTXT.Text);
            food.Price = Convert.ToInt32(fPriceTXT.Text);

            var response = await ApiService.FoodAdd(food);
            if (response != null)
            {
                MessageBox.Show("Hata");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı.");
                fFoodTXT.Clear();
                fCategoryTXT.Clear();
                fPriceTXT.Clear();
            }
            List();
        }

        private async void fUpdateBTN_Click(object sender, EventArgs e)
        {
            var response = await ApiService.FoodUpdate(Convert.ToInt32(fIdTXT.Text), fFoodTXT.Text, Convert.ToInt32(fCategoryTXT.Text), Convert.ToInt32(fPriceTXT.Text));
            MessageBox.Show("Güncelleme başarılı.");
            cCategoryTXT.Clear();
            List();
        }

        private async void fDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await ApiService.FoodDelete(Convert.ToInt32(fIdTXT.Text));
                MessageBox.Show("Silme başarılı.");
                fFoodTXT.Clear();
                fCategoryTXT.Clear();
                fPriceTXT.Clear();
                List();
            }
            catch (Exception errormsg)
            {
                MessageBox.Show(errormsg.Message);
            }
        }

        private async void cInsertBTN_Click(object sender, EventArgs e)
        {
            var category = new CategoryClass();
            category.CategoryName = cCategoryTXT.Text;

            var response = await ApiService.CategoryAdd(category);
            if (response != null)
            {
                MessageBox.Show("Hata");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı.");
                cCategoryTXT.Clear();
            }
            List();
        }

        private async void cUpdateBTN_Click(object sender, EventArgs e)
        {
            var response = await ApiService.CategoryUpdate(Convert.ToInt32(cIdTXT.Text), cCategoryTXT.Text);
            MessageBox.Show("Güncelleme başarılı.");
            cCategoryTXT.Clear();
            List();
        }

        private async void cDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await ApiService.CategoryDelete(Convert.ToInt32(cIdTXT.Text));
                MessageBox.Show("Silme başarılı.");
                cIdTXT.Clear();
                cCategoryTXT.Clear();
                List();
            }
            catch (Exception errormsg)
            {
                MessageBox.Show(errormsg.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }

        private void fDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = fDGV.Rows[selected];
            fIdTXT.Text = selectedRow.Cells[0].Value.ToString();
            fFoodTXT.Text = selectedRow.Cells[1].Value.ToString();
            fCategoryTXT.Text = selectedRow.Cells[2].Value.ToString();
            fPriceTXT.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void cDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = cDGV.Rows[selected];
            cIdTXT.Text = selectedRow.Cells[0].Value.ToString();
            fCategoryTXT.Text = selectedRow.Cells[0].Value.ToString();
            cCategoryTXT.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void tDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = tDGV.Rows[selected];
            tIdTXT.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }

        private async void tInsertBTN_Click(object sender, EventArgs e)
        {
            var table = new TableClass();
            table.TableName = tAdiTXT.Text;

            var response = await ApiService.TableAdd(table);
            if (response != null)
            {
                MessageBox.Show("Hata");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı.");
                tAdiTXT.Clear();
            }
            List();
        }

        private async void tUpdateBTN_Click(object sender, EventArgs e)
        {
            var response = await ApiService.TableUpdate(Convert.ToInt32(tIdTXT.Text), tAdiTXT.Text);
            MessageBox.Show("Güncelleme başarılı.");
            cCategoryTXT.Clear();
            List();
        }

        private async void tDeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await ApiService.TableDelete(Convert.ToInt32(tIdTXT.Text));
                MessageBox.Show("Silme başarılı.");
                tIdTXT.Clear();
                tAdiTXT.Clear();
                List();
            }
            catch (Exception errormsg)
            {
                MessageBox.Show(errormsg.Message);
            }
        }
    }
}
