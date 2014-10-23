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
        private ProductBLL aBll;

        List<Product>products=new List<Product>(); 

        public ShopUI()
        {
            InitializeComponent();
        }

       

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            aBll = new ProductBLL();
            Product aProduct = new Product();

            aProduct.Code = productCodeTextBox.Text;
            aProduct.Name = productNameTextBox.Text;
            aProduct.Quantity =Convert.ToInt32((quantityTextBox.Text));

            string message = aBll.Save(aProduct);
            MessageBox.Show(message);
        }

       


        private void GetTottalProductInfo()
        {
            products = aBll.GetTottalProductInfo();
            productInfoGridView.DataSource = products;

        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            GetTottalProductInfo();
            totalTextBox.Text = aBll.GetTotalQuantiy().ToString();
        }


       
    }
}
