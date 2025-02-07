using MatthewEvans___BFM1___Software_I___C968.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewEvans___BFM1___Software_I___C968
{
    public partial class mainScreen : Form
    {
        //Initialize instance of Inventory class
        Inventory inventory = new Inventory();

        //Value used to setup data only once
        int setupData = 0; // 0: Setup Test Data || 1: Dont Setup Test Data

        public mainScreen()
        {
            InitializeComponent();

            //sets properties for MainScreen datagridviews
            MainScreenSetup();

            //sets up sampel data for debug
            SetupSampleData();
        }

        //clears the autoselection of rows
        private void partsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsDataGridView.ClearSelection();
        }
        private void productsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsDataGridView.ClearSelection();
        }

        ////////////////
        /// Buttons ///
        ///////////////

        //Parts - ADD Button
        //opens a blank add part screen
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            partScreen addPartScreen = new partScreen();
            addPartScreen.ShowDialog();
        }

        //Parts - MODIFY Button
        //opens and populates modify parts screen
        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow.DataBoundItem is Inhouse) //checks to see if highlighted part is Inhouse
            {
                Inhouse selectedInhouse = partsDataGridView.CurrentRow.DataBoundItem as Inhouse; //stores selection in Inhouse object
                partScreen modifyPartScreen = new partScreen(selectedInhouse); //opens the partScreen useing the data from selectedInhouse to populate the screen
            }
            else
            {
                Outsourced selectedOutsourced = partsDataGridView.CurrentRow.DataBoundItem as Outsourced; //stores selection in Outsourced object
                partScreen modifyPartScreen = new partScreen(selectedOutsourced); //opens the partScreen useing the data from selectedOutsourced to populate the screen
            }
        }

        //Parts - DELETE Button
        //button used to delete selected part
        public void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.CurrentRow == null || !partsDataGridView.CurrentRow.Selected) //checks if the current row is empty or if there is no selection
            {
                MessageBox.Show("Nothing Selected!", "Please Make A Slection");
                return;
            }

            Part deletepart = partsDataGridView.CurrentRow.DataBoundItem as Part; //storeing selection in Part veriable
            inventory.deletePart(deletepart); //deleteing selecting from bindinglist
        }

        //Products - ADD Button
        //opens a blank add product screen
        private void productsAddButton_Click(object sender, EventArgs e)
        {
            productScreen addProduct = new productScreen();
            addProduct.Show();
        }

        //Products - MODIFY Button
        //opens and populates productScreen
        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null || !productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please Make A Selection");
                return;
            }

            Product selectedProduct = productsDataGridView.CurrentRow.DataBoundItem as Product;
            productScreen productScreen = new productScreen(selectedProduct);
            productScreen.Show();
        }

        //Products - DELETE Button
        //button used to delete selected product
        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null || !productsDataGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please Make A Selection");
                return;
            }

            Product deleteproduct = productsDataGridView.CurrentRow.DataBoundItem as Product;
            inventory.removeProduct(deleteproduct);

        }

        //Parts - Search Button
        //takes input from search text box and returns a message if found or not
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            searchDataGrid(partsSearchValue.Text, partsDataGridView);
        }

        //Product - Search Button
        //takes input from search text box and returns a message if found or not
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            searchDataGrid(productsSearchValue.Text, productsDataGridView);
        }

        //MainScreen - EXIT Button
        //closes application
        private void exitButton_Click(object sender, EventArgs e)
    {
            this.Close();
        }


        ///////////////
        //// Misc ////
        //////////////

        //Settings for main screen form
        private void MainScreenSetup()
        {
            //set data source for Parts datagrid
            partsDataGridView.DataSource = Inventory.AllParts;
            productsDataGridView.DataSource = Inventory.Products;

            //Remove bottom row from datagrids
            partsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToAddRows = false;
        }

        //Sample Data
        private void SetupSampleData()
        {
            if (setupData < 1) // if SetupSample has not yet run, it will run
            {
                //Part Sample Data
                Inhouse rearWeightBracket = new Inhouse(1, "Rear Weight Bracket", 67.41m, 1, 1, 20, 8675309);
                Inhouse magneticHitchPin = new Inhouse(2, "Magnetic Hitch Pin", 18.99m, 5, 1, 10, 8675309);
                Inhouse storageCompartmentCover = new Inhouse(3, "Strorage Compartment Cover", 7.46m, 10, 10, 99, 8675309);
                Inhouse pushToConnect = new Inhouse(4, "3/4 in. Push-to-Connect Brass Ball Valve", 26.97m, 22, 5, 100, 8675309);
                Inhouse brassFlangedSillcockValve = new Inhouse(5, "1/2 in. FIP x MHT Brass Flanged Sillcock Valve", 7.78m, 11, 5, 100, 8675309);
                Outsourced rearWeightBracket2 = new Outsourced(6, "Rear Weight Bracket", 67.41m, 1, 1, 20, "Sanford and Sons");
                Outsourced magneticHitchPin2 = new Outsourced(7, "Magnetic Hitch Pin", 18.99m, 5, 1, 10, "John Deer");
                Outsourced storageCompartmentCover2 = new Outsourced(8, "Strorage Compartment Cover", 7.46m, 10, 10, 99, "John Deer");
                Outsourced pushToConnect2 = new Outsourced(9, "3/4 in. Push-to-Connect Brass Ball Valve", 26.97m, 22, 5, 100, "Yamaha");
                Outsourced brassFlangedSillcockValve2 = new Outsourced(10, "1/2 in. FIP x MHT Brass Flanged Sillcock Valve", 7.78m, 11, 5, 100, "Yamaha");


                //adding sample parts to AllParts list
                inventory.addPart(rearWeightBracket);
                inventory.addPart(magneticHitchPin);
                inventory.addPart(storageCompartmentCover);
                inventory.addPart(pushToConnect);
                inventory.addPart (brassFlangedSillcockValve);
                inventory.addPart(rearWeightBracket2);
                inventory.addPart(magneticHitchPin2);
                inventory.addPart(storageCompartmentCover2);
                inventory.addPart(pushToConnect2);
                inventory.addPart(brassFlangedSillcockValve2);


                //Product Sample Data
                BindingList<Part> ridingLawnmowerParts = new BindingList<Part>();
                ridingLawnmowerParts.Add(rearWeightBracket);
                ridingLawnmowerParts.Add(magneticHitchPin);
                ridingLawnmowerParts.Add(storageCompartmentCover);
                inventory.addProduct(new Product(1, "Riding Lawnmower", 6.99m, 2, 1, 10, ridingLawnmowerParts));

                BindingList<Part> tankWaterHeater = new BindingList<Part>();
                tankWaterHeater.Add(pushToConnect);
                tankWaterHeater.Add(pushToConnect2);
                inventory.addProduct(new Product(2, "40 Gal. 36,000 BTU Tank Water Heater", 519.00m, 2, 0, 2, tankWaterHeater));

                //Product with no initial AssociatedParts list
                inventory.addProduct(new Product(3, "Colorado 5-Light Black Modern Farmhouse Rectangular Chandelier", 353.00m, 0, 0, 5));

                setupData++; // used for logic to only set sample data once
            }
            
        }

        /// <summary>
        /// function for searching the All Cadidates DataGrid useing an argument (string input)
        /// </summary>
        /// <param name="search"> string veriable used as the search comparison object </param>
        private void searchDataGrid(string search, DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (search != "" && int.TryParse(search, out int result) == true) //checks to make sure the search string is not empty, and then tries to see if it cna be parsed into an integer
                {
                    try
                    {
                        if (inventory.checkExistence(int.Parse(search)) == true) //checks to make sure that the search input exists in the list
                        {
                            integerSearch(search, i, dataGrid); //runs the integerSearch function that hides all rows that do not match the partID of the search string
                        }
                        else //if the string input (part number) dose not exist then...
                        {
                            MessageBox.Show($"No part with the id: \"{search}\" was found. Please check your spelling and try again.");
                            break;
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show($"An Error has occured, please remove your search data and try again. If the issue continues please close the application and reopen.");
                    }

                }
                else //if the search string can not be parsed into an integer (ie. its a string)
                {
                    try
                    {
                        if (inventory.checkExistence(search) == true) //checks to see if the part exists in the AllParts list
                        {
                            stringSearch(search, i, dataGrid); //runs the stringSearch function that hides all rows that do not math the part that is being searched
                            continue; //continues the for loop
                        }
                        else //if the part dose not exist in the AllParts list
                        {
                            MessageBox.Show($"No part with the name \"{search}\" was found. Please check your spelling and try again.");
                            break;
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show($"An Error has occured, please remove your search data and try again. If the issue continues please close the application and reopen.");
                    }
                }
            }
        }

        /// <summary>
        /// Function for searching and manipulateing the allCandidatesDataGridView based on the Name of the Part
        /// </summary>
        /// <param name="inputString"> veriable to hold the search parameter, input by the user in the allCandidateSearchValue textbox</param>
        /// <param name="i"> integer indicating the iteration of the forloop in the parent function</param>
        private void stringSearch(String inputString, int i, DataGridView dataGrid)
        {
            if (inputString == Inventory.AllParts[i].Name) //checks if the inputString is the same as the current parts name 
            {
                dataGrid.Rows[i].Visible = true; //if so it will make sure that row containg the part stays visable, or makes it viable once again if it was already invisable
            }
            else
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGrid.DataSource]; //no idea what this is doing, but it fixed my exeption I was getting XD
                currencyManager.SuspendBinding();
                dataGrid.Rows[i].Visible = false; //sets rows that do not match teh inputString to be invisable
                currencyManager.ResumeBinding();
            }
        }

        /// <summary>
        /// Function for seaching and manipulateing the allCandidatesDataGridView based on the Part ID
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="i"></param>
        private void integerSearch(String inputString, int i, DataGridView dataGrid)
        {
            if (int.Parse(inputString) == Inventory.AllParts[i].PartID) //checks to see if the inputString match the part ID of the part in the list
            {
                dataGrid.Rows[i].Visible = true; //if so it will make sure that row containg the part stays visable, or makes it viable once again if it was already invisable
            }
            else
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGrid.DataSource]; //same as above, I have no idea what this is doing XD but it fixes my issue, added it to the google list for later consumption
                currencyManager.SuspendBinding();
                dataGrid.Rows[i].Visible = false;//sets rows that do not match teh inputString to be invisable
                currencyManager.ResumeBinding();
            }
        }

        private void partsSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (partsSearchValue.Text == "") //checks to see if the content of the allCandidateSeachValue textbox is an empty string
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    partsDataGridView.Rows[i].Visible = true; //sets all rows in the datagrid to being visable
                }
            }
        }

        private void productsSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (productsSearchValue.Text == "") //checks to see if the content of the allCandidateSeachValue textbox is an empty string
            {
                for (int i = 0; i < productsDataGridView.Rows.Count; i++)
                {
                    productsDataGridView.Rows[i].Visible = true; //sets all rows in the datagrid to being visable
                }
            }
        }

        private void productsDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            productsDataGridView.ResetBindings();
        }
    }
}
