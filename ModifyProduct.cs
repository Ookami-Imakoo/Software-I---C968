using MatthewEvans___BFM1___Software_I___C968.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewEvans___BFM1___Software_I___C968
{
    public partial class ModifyProduct : Form
    {
        Inventory inventory = new Inventory();
        Product myProduct = new Product();

        public ModifyProduct()
        {
            InitializeComponent();

            addProductSetup();
        }

        public ModifyProduct(Product product)
        {
            ModifyProduct modifyProduct = new ModifyProduct();

            modifyProduct.idValue.Text = product.ProductID.ToString();
            modifyProduct.nameValue.Text = product.Name.ToString();
            modifyProduct.inventoryValue.Text = product.InStock.ToString();
            modifyProduct.priceCostValue.Text = product.Price.ToString();
            modifyProduct.maxValue.Text = product.Max.ToString();
            modifyProduct.minValue.Text = product.Min.ToString();

            //modifyProduct.partsAssociatedDataGridView.DataSource = Product.AssociatedParts;

            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == product.ProductID)
                {
                    inventory.removeProduct(Inventory.Products[i]);
                    inventory.addProduct(product);
                }

            }

            modifyProduct.Show();
        }

        //
        private void productSaveButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductID = int.Parse(idValue.Text),
                Name = nameValue.Text,
                Price = decimal.Parse(priceCostValue.Text),
                InStock = Int32.Parse(inventoryValue.Text),
                Min = Int32.Parse(minValue.Text),
                Max = Int32.Parse(maxValue.Text),
                //Product.AssociatedParts = product.AssociatedParts
            };

            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == product.ProductID)
                {
                    inventory.removeProduct(Inventory.Products[i]);
                    inventory.addProduct(product);
                    this.Close();

                }

            }
        }

        private void addProductSetup()
        {
            //allCandidateDataGridView.DataSource = Inventory.AllParts; //sets data for All Candidate Parts DataGrid
            //partsAssociatedDataGridView.DataSource = myProduct.AssociatedParts; //sets data for Parts Associated DataGrid


        }

        //
        private void productCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
