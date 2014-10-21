using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BLL;
using Shop.DLL.DAO;

namespace Shop
{
    public partial class ShopUI : Form
    {
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ProductBLL aBll=new ProductBLL();
            Product aProduct=new Product();

            aProduct.Code = productCodeTextBox.Text;
            aProduct.Name = productNameTextBox.Text;
            aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);

            string message = aBll.Save(aProduct);
            MessageBox.Show(message);
        }

       
    }
}
