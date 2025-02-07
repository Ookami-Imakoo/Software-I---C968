using MatthewEvans___BFM1___Software_I___C968.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewEvans___BFM1___Software_I___C968
{
    public partial class ModifyPart : Form
    {
        Inventory inventory =  new Inventory();

        public ModifyPart()
        {
            InitializeComponent();
        }

        //constoructor for ModifyParts page if an inhouse object is passed in
        public ModifyPart(Inhouse myInhouse)
        {
            //calls for defualt constructor to initialize components
            ModifyPart modifyPart = new ModifyPart();

            //sets Inhouse Radio Button to true
            modifyPart.inhouseRadioButton.Checked = true;

            //shows Machine ID Label/Value and hides Company Name Label/Value
            modifyPart.machineIDLabel.Show();
            modifyPart.machineIDValue.Show();
            modifyPart.companyNameLabel.Hide();
            modifyPart.companyNameValue.Hide();

            //sets data from the passed in inhouse object
            modifyPart.idValue.Text = myInhouse.PartID.ToString();
            modifyPart.nameValue.Text = myInhouse.Name.ToString();
            modifyPart.inventoryValue.Text = myInhouse.InStock.ToString();
            modifyPart.priceCostValue.Text = myInhouse.Price.ToString();
            modifyPart. maxValue.Text = myInhouse.Max.ToString();
            modifyPart.minValue.Text = myInhouse.Min.ToString();
            modifyPart.machineIDValue.Text = myInhouse.MachineID.ToString();
            
            modifyPart.Show();
        }

        public ModifyPart(Outsourced myOutsourced)
        {
            //call for defualt constructor
            ModifyPart modifyPart = new ModifyPart();

            //sets Outsourced Radio Button to true
            modifyPart.outsourcedRadioButton.Checked = true;

            //shows Company Name Label/Value and hides Machine ID Label/Value
            modifyPart.machineIDLabel.Hide();
            modifyPart.machineIDValue.Hide();
            modifyPart.companyNameLabel.Show();
            modifyPart.companyNameValue.Show();

            //sets data from passed in outsourced object
            modifyPart.idValue.Text = myOutsourced.PartID.ToString();
            modifyPart.nameValue.Text = myOutsourced.Name.ToString();
            modifyPart.inventoryValue.Text = myOutsourced.InStock.ToString();
            modifyPart.priceCostValue.Text = myOutsourced.Price.ToString();
            modifyPart.maxValue.Text = myOutsourced.Max.ToString();
            modifyPart.minValue.Text = myOutsourced.Min.ToString();
            modifyPart.companyNameValue.Text = myOutsourced.CompanyName.ToString();

            modifyPart.Show();
        }

        private void inhouseRadioButton_CheckedChanged_ModifyPart(object sender, EventArgs e)
        {
            machineIDLabel.Show();
            machineIDValue.Show();

            companyNameLabel.Hide();
            companyNameValue.Hide();
        }

        private void outsourcedRadioButton_CheckedChanged_ModifyPart(object sender, EventArgs e)
        {
            //Hides Machine Lable and Value
            machineIDLabel.Hide();
            machineIDValue.Hide();

            companyNameLabel.Show();
            companyNameValue.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (inhouseRadioButton.Checked == true)
            {
                saveModifiedInhouse();
            }

            else
            {
                saveModifiedOutsourced();
            }
        }

        //closes Modify Part screen
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveModifiedInhouse()
        {
            Inhouse inhouse = new Inhouse(int.Parse(idValue.Text), nameValue.Text, decimal.Parse(priceCostValue.Text), Int32.Parse(inventoryValue.Text), Int32.Parse(minValue.Text), Int32.Parse(maxValue.Text), Int32.Parse(machineIDValue.Text));
            //{
            //    PartID = int.Parse(idValue.Text),
            //    Name = nameValue.Text,
            //    Price = decimal.Parse(priceCostValue.Text),
            //    InStock = Int32.Parse(inventoryValue.Text),
            //    Min = Int32.Parse(minValue.Text),
            //    Max = Int32.Parse(maxValue.Text),
            //    MachineID = Int32.Parse(machineIDValue.Text)
            //};

            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == inhouse.PartID)
                {
                    inventory.deletePart(Inventory.AllParts[i]);
                    inventory.addPart(inhouse);
                    this.Close();

                }

            }
        }

        private void saveModifiedOutsourced()
        {
            Outsourced outsourced = new Outsourced(int.Parse(idValue.Text), nameValue.Text, decimal.Parse(priceCostValue.Text), Int32.Parse(inventoryValue.Text), Int32.Parse(minValue.Text), Int32.Parse(maxValue.Text), companyNameValue.Text);

            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == outsourced.PartID)
                {
                    inventory.deletePart(Inventory.AllParts[i]);
                    inventory.addPart(outsourced);
                    this.Close();

                }

            }
        }
    }
}
