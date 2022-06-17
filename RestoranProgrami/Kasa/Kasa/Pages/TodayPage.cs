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
    public partial class TodayPage : Form
    {
        public TodayPage()
        {
            InitializeComponent();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void TodayPage_Load(object sender, EventArgs e)
        {
            var order = await ApiService.GetOrder();
            dgv.DataSource = order;
        }
    }
}
