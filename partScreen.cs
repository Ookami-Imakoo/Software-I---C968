using MatthewEvans___BFM1___Software_I___C968.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace MatthewEvans___BFM1___Software_I___C968
{
    public partial class partScreen : Form
    {
        //Initialize instance of Inventory class
        Inventory inventory = new Inventory();

        //Defualt Constructor
        public partScreen()
        {
            InitializeComponent();

            //partScreenSetup();

            idValue.Text = inventory.partIDGenerator().ToString();
        }

        //Constructor called when modifying a part
        public partScreen(Part part) // takes a part as input (Origin: mainScreen.partsModifyButton_Click)
        {
            partScreen modifyPartScreen = new partScreen(); //Inizializeing new Parts Screen

            modifyPartsScreenSetup(part, modifyPartScreen); //Function that sets up the Partscreen with data from the passed in part

            modifyPartScreen.Show(); //Displays the screen

        }


        ////////////////
        /// Buttons ///
        ///////////////
        private void saveButton_Click(object sender, EventArgs e)
        {
            inventoryLogicTest();
        }

        //closes Add Part screen
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ////////////////
        //// Events ////
        ///////////////

        /// <summary>
        /// Event that handels what to do when the inhouse radio button is checked
        /// </summary>
        private void inhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Show(); //Shows the Machine ID Label and Value text boxes
            machineIDValue.Show();

            companyNameLabel.Hide(); //Hides the Company Name Label and Value text boxes
            companyNameValue.Hide();
        }

        /// <summary>
        /// Event that handels what to do when the outsourced radio button is checked
        /// </summary>
        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            //Hides Machine Lable and Value
            machineIDLabel.Hide(); //Hides the Machine ID Label and Value text boxes
            machineIDValue.Hide();

            companyNameLabel.Show(); //Shows the Company Name Label and Value text boxes
            companyNameValue.Show();
        }

        /// <summary>
        /// Event for conroling input to only Digits and Backspace
        /// </summary>
        private void keyPress_DigitBackspace(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; //variable "ch" for storing keypress

            if (!Char.IsDigit(ch) && ch != 8) //first checks if "ch" is a digit, then checks that key press
            {                                //is equal to backspace enumeration
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event for conroling input to only Digits Backspace and '.' - Specificaly for Price/Cost Textbox
        /// </summary>
        private void priceCostValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; //variable "ch" for storing keypress

            if (!Char.IsDigit(ch) && ch != 8 && ch != '.') //first checks if "ch" is a digit, then checks to see if the 
            {                                              //key press was the symbol '.' and finally it checks to see if
                e.Handled = true;                          //the key pressed was equal to backspace's enumeration
            }
        }

        ////////////////
        //// Misc. ////
        ///////////////

        /// <summary>
        /// Defualt page setup for Parts Screen
        /// </summary>
        private void partScreenSetup()
        {
            saveButton.Enabled = false;
        }
        /// <summary>
        /// Used to set up Parts Page when modifying an existing part
        /// </summary>
        /// <param name="part"> Part object to be modified </param>
        /// <param name="partScreen"> Screen object, used to interact with form elements </param>
        private void modifyPartsScreenSetup(Part part, partScreen modifyPartScreen)
        {
            if (part is Inhouse) //checks to see if the part is Inhouse
            {
                //sets Inhouse Radio Button to true
                modifyPartScreen.inhouseRadioButton.Checked = true;

                //shows Machine ID Label/Value and hides Company Name Label/Value
                modifyPartScreen.machineIDLabel.Show();
                modifyPartScreen.machineIDValue.Show();
                modifyPartScreen.addPartLabel.Text = "Modify Part";
                modifyPartScreen.addPartLabel.Show();
                modifyPartScreen.companyNameLabel.Hide();
                modifyPartScreen.companyNameValue.Hide();

                Inhouse inhouse = part as Inhouse; //sets passed in part as an Inhouse object
                modifyPartScreen.machineIDValue.Text = inhouse.MachineID.ToString(); //used that object to pass in MachineID
            }
            else if (part is Outsourced) //checks to see if the part is Outsourced
            {
                //sets Outsourced Radio Button to true
                modifyPartScreen.outsourcedRadioButton.Checked = true;

                //shows Machine ID Label/Value and hides Company Name Label/Value
                modifyPartScreen.companyNameLabel.Show();
                modifyPartScreen.companyNameValue.Show();
                modifyPartScreen.addPartLabel.Text = "Modify Part";
                modifyPartScreen.addPartLabel.Show();
                modifyPartScreen.machineIDLabel.Hide();
                modifyPartScreen.machineIDValue.Hide();

                Outsourced outsourced = part as Outsourced; //sets passed in part as an Outsourced object
                modifyPartScreen.companyNameValue.Text = outsourced.CompanyName.ToString(); //used that object to pass in company name value
            }

            //sets remaining data from the passed in part object
            modifyPartScreen.idValue.Text = part.PartID.ToString();
            modifyPartScreen.nameValue.Text = part.Name.ToString();
            modifyPartScreen.inventoryValue.Text = part.InStock.ToString();
            modifyPartScreen.priceCostValue.Text = part.Price.ToString();
            modifyPartScreen.maxValue.Text = part.Max.ToString();
            modifyPartScreen.minValue.Text = part.Min.ToString();
        }
        /// <summary>
        /// Method for confirming that the input data form the end user will create a good part before creating the part and adding it to the allparts list
        /// </summary>
        private void inventoryLogicTest()
        {
            if (inhouseRadioButton.Checked == true) //checks to see if the inhouse radio button is checked or not, indicating the part is to be an inhouse part
            {
                try //first trys to create the part withe the passed in data from the Parts Screen
                {
                    Inhouse inhouse = new Inhouse(int.Parse(idValue.Text), nameValue.Text, decimal.Parse(priceCostValue.Text), Int32.Parse(inventoryValue.Text), Int32.Parse(minValue.Text), Int32.Parse(maxValue.Text), Int32.Parse(machineIDValue.Text)); //initialzes a new part with the data put in by the user
                    if (inventory.checkExistence(inhouse) == true) //checks to see if the part already exists
                    {
                        if (inventory.inventoryLogic(inhouse) == true) //confirms that the part conforms to the classes restrictions
                        {
                            inventory.updatePart(inhouse.PartID, inhouse); //updates the existing part
                            this.Close(); //closes part screen
                        }
                    }
                    else if (inventory.inventoryLogic(inhouse) == true) //confirms that the part conforms to the classes restrictions
                    {
                        inventory.addPart(inhouse); //adds the part to the allparts list
                        this.Close(); //closes part screen
                    }
                }
                catch (Exception) //if the part would fail completely, and no other error message display (preventing this one) than this error message acts as more of a catch all
                {
                    partVerification(); //Method that adds notifications to the part screen to help the user correct input errors
                    MessageBox.Show("Please check all data was entered correctly and then try again.");
                }
            }
            else if (outsourcedRadioButton.Checked == true) //checks to see if the outsourced radio button is checked or not, indicating the part is to be an outsourced part
            {
                try
                {
                    Outsourced outsourced = new Outsourced(int.Parse(idValue.Text), nameValue.Text, decimal.Parse(priceCostValue.Text), Int32.Parse(inventoryValue.Text), Int32.Parse(minValue.Text), Int32.Parse(maxValue.Text), companyNameValue.Text); //initialzes a new part with the data put in by the user
                    if (inventory.checkExistence(outsourced) == true) //checks to see if the part already exists
                    {
                        if (inventory.inventoryLogic(outsourced) == true) //confirms that the part conforms to the classes restrictions
                        {
                            inventory.updatePart(outsourced.PartID, outsourced); //updates the existing part
                            this.Close(); //closes part screen
                        }
                    }
                    else if (inventory.inventoryLogic(outsourced) == true) //confirms that the part conforms to the classes restrictions
                    {
                        inventory.addPart(outsourced); //adds the part to the allparts list
                        this.Close(); //closes part screen
                    }
                }
                catch (Exception)
                {
                    partVerification(); //Method that adds notifications to the part screen to help the user correct input errors
                    MessageBox.Show("Please check all data was entered correctly and then try again.");
                }
            }
        }
        /// <summary>
        /// Method for validateing part information and returns useful messages to help end user input proper data
        /// </summary>
        /// <param name="textbox"> refers to the textbox from which the end users data is passed </param>
        private void inventoryValidation(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text)) //checks to make sure the textbox is not null
            {
                textbox.BackColor = Color.Salmon;
                saveButton.Enabled = false;
                MessageBox.Show("Please fill out all textboxes.");
                textbox.Focus();
            }
            else if (textbox == priceCostValue) //priceCostValue textbox specific verification
            {
                Regex currencyCheck = new Regex(@"\d+\.\d{2}"); //initializing new regex to check for currency format: xxx.xx
                if (currencyCheck.IsMatch(textbox.Text)) //checks to see if the priceCostValue.Text matches the currency format
                {
                    textbox.BackColor = Color.White;
                    EnableSaveButton();
                }
                else //if it dose not match the currecny format
                {
                    textbox.BackColor = Color.Salmon;
                    saveButton.Enabled = false;
                    MessageBox.Show("Please Check \"Price / Cost\" for format: x.xx");
                    priceCostValue.Focus();
                }
            }
            else //defualt
            {
                textbox.BackColor = Color.White;
                EnableSaveButton();
            }
        }

        /// <summary>
        /// Method for running verification on all textboxes that make up a complete part
        /// </summary>
        private void partVerification()
        {
            inventoryValidation(nameValue);
            inventoryValidation(inventoryValue);
            inventoryValidation(priceCostValue);
            inventoryValidation(maxValue);
            inventoryValidation(minValue);

            if (inhouseRadioButton.Checked == true) //runs only if the part is inhouse
            {
                inventoryValidation(machineIDValue);
            }
            else if (outsourcedRadioButton.Checked == true) //runs only if the part is outsourced
            {
                inventoryValidation(companyNameValue);
            }
        }

        /// <summary>
        /// Method for enableing the save button, but only once all the textboxes have valid data
        /// </summary>
        private void EnableSaveButton()

        {
            if ((nameValue.BackColor == Color.White) && (inventoryValue.BackColor == Color.White)
                                && (priceCostValue.BackColor == Color.White) && (maxValue.BackColor == Color.White)
                                && (minValue.BackColor == Color.White) && ((companyNameValue.BackColor == Color.White) || (machineIDValue.BackColor == Color.White)))

            {
                saveButton.Enabled = true;
            }
        }

        ////////////////////////////
        //// Validation Events ////
        ///////////////////////////

        /// <summary>
        /// The below events are for validateing texbox input for thier respective textboxes
        /// </summary>
    

        private void nameValue_Validating(object sender, CancelEventArgs e)
        {
            inventoryValidation(nameValue);
        }

        private void inventoryValue_Validating(object sender, CancelEventArgs e)
        {
            inventoryValidation(inventoryValue);
        }

        private void priceCostValue_Validating(object sender, CancelEventArgs e)
        {
            inventoryValidation(priceCostValue);
        }

        private void maxValue_Validating(object sender, CancelEventArgs e)
        {
            inventoryValidation(maxValue);
        }

        private void minValue_Validating(object sender, CancelEventArgs e)
        {
            inventoryValidation(minValue);
        }

        private void machineIDValue_Validating(object sender, CancelEventArgs e)
        {
            if (inhouseRadioButton.Checked == true)
            {
                inventoryValidation(machineIDValue);
            }
        }

        private void companyNameValue_Validating(object sender, CancelEventArgs e)
        {
            if (outsourcedRadioButton.Checked == true)
            {
                inventoryValidation(companyNameValue);
            }
        }
    }
}
