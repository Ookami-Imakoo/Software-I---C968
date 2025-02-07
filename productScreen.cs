using MatthewEvans___BFM1___Software_I___C968.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewEvans___BFM1___Software_I___C968
{
    public partial class productScreen : Form
    {
        ////////////////////////
        /// Global Veriables ///
        ///////////////////////
        
        Inventory inventory = new Inventory(); //initialzation of inventory object
        
        Product modifyProduct = new Product(); //used to store the product to be modifed

        public BindingList<Part> AssociatedPartsCopy = new BindingList<Part>(); //listed used to store associated parts list durring modification

        ////////////////////////
        //// Constoructors ////
        ///////////////////////

        /// <summary>
        /// Defult Constructor for Product Screen: Used when creating a new product
        /// </summary>
        public productScreen()
        {
            InitializeComponent();
            
            productScreenSetup(); //sets up screen

            idValue.Text = inventory.productIDGenerator().ToString(); //generates a unique idValue for new Products and sets it in textbox
        }

        /// <summary>
        /// Constructor used when modifying a product.
        /// </summary>
        /// <param name="product"> Product to be modifed -- passed in from MainScreen productsModifyButton_Click </param>
        public productScreen(Product product)
        {
            InitializeComponent();

            productScreenSetup(); //sets up screen

            modifyProductScreenSetup(product); //sets data useing product as an argument
        }
        
        ////////////////
        /// Buttons ///
        ///////////////

        // ADD - All Candidate Parts Button (Function: adds selected part to AssociatedParts list)
        private void allCandidateAddButton_Click(object sender, EventArgs e)
        {
            Part part = allCandidateDataGridView.CurrentRow.DataBoundItem as Part; //uses selection to create part object

            modifyProduct.addAssociatedPart(part); //adds part object to Associated Parts List
            partsAssociatedDataGridView.DataSource = modifyProduct.AssociatedParts; //displays AssociatedParts list of new product
        }

        // Delete - AssociatedParts Button (Function: removes parts from the AssociatedParts list, but not from the AllParts list)
        private void partsAssociatedDeleteButton_Click(object sender, EventArgs e)
        {
            Product modifyProductCopy = new Product(modifyProduct); //copy

            if (partsAssociatedDataGridView.CurrentRow == null || !partsAssociatedDataGridView.CurrentRow.Selected) //checks if the associated parts list is null or if no row is currently selected
            {
                MessageBox.Show("No Part Selected, please select a part to be deleted."); //returns message if the above logic is true
                return;
            }
            Part part = partsAssociatedDataGridView.CurrentRow.DataBoundItem as Part; //sets part highlighted in AssociatedParts list as part object

            if (modifyProduct.AssociatedParts != null) //checks to see if the part is a modifed part or not
            {
                modifyProductCopy.removeAssoicatedPart(part.PartID); //removes part on the modifyPart.AssociatedParts
            }
            else
            {
                modifyProduct.removeAssoicatedPart(part.PartID); //removes part on the myProduct.AssociatedParts
            }
        }

        /// <summary>
        /// function used to save (new and modified) products 
        /// </summary>
        private void productSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (modifyProduct.ProductID == 0) //checks to make sure we are creating a new or existing entry (ture == new product)
                {
                    Product product = new Product
                    {
                        ProductID = int.Parse(idValue.Text),
                        Name = nameValue.Text,
                        InStock = int.Parse(inventoryValue.Text),         //creates new prodcut useing the data from forms textboxes
                        Price = decimal.Parse(priceCostValue.Text),
                        Max = int.Parse(maxValue.Text),
                        Min = int.Parse(minValue.Text),
                        AssociatedParts = partsAssociatedDataGridView.DataSource as BindingList<Part>
                    };

                    if (product.productValidation(product) == true) //runs product validation to confirm product has good data
                    {
                        inventory.addProduct(product);
                        this.Close();
                    }

                }
                else
                {
                    modifyProduct.ProductID = int.Parse(idValue.Text);
                    modifyProduct.Name = nameValue.Text;
                    modifyProduct.InStock = int.Parse(inventoryValue.Text);    //updates preexisting product record
                    modifyProduct.Price = decimal.Parse(priceCostValue.Text);
                    modifyProduct.Max = int.Parse(maxValue.Text);
                    modifyProduct.Min = int.Parse(minValue.Text);

                    inventory.updateProduct(modifyProduct.ProductID, modifyProduct); 
                    
                    this.Close();
                }
            }
            catch (Exception) //exception captured incase bad data is able to be passed into a product creation, this error message should only tigger in a last case senerio
            {

                MessageBox.Show("An Error has occured, please check your data and try again.");
            }
        }

        /// <summary>
        /// Method for searching All Candidates list based on string data from "allCandidateSearchValue"
        /// </summary>
        private void allCandidateSearchButton_Click(object sender, EventArgs e)
        {
            searchAllCadidatesDataGrid(allCandidateSearchValue.Text); //runs search function on the contence of the allCandidateSearchValue textbox
        }

        /// <summary>
        /// 
        /// </summary>
        private void productCancelButton_Click(object sender, EventArgs e)
        {
            modifyProduct.AssociatedParts = AssociatedPartsCopy; //returns a copy of the Associated Parts list that was created when the parts screen was created (so pre any modifications by the end user)
            this.Close();
        }

        ///////////////
        //// Misc ////
        //////////////
 
        //clears inital selection on allCadidateDataGridView
        private void allCandidateDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            allCandidateDataGridView.ClearSelection();
        }

        //clears inital selection on partsAssociatedDataGridView
        private void partsAssociatedDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsAssociatedDataGridView.ClearSelection();
        }

        /// <summary>
        /// Method used to set up productScreen (defualt)
        /// </summary>
        private void productScreenSetup()
        {
            allCandidateDataGridView.DataSource = Inventory.AllParts; //sets data for All Candidate Parts DataGrid
        }

        /// <summary>
        /// Method used to setup productScreen (for modfiying existing prodcuts)
        /// </summary>
        /// <param name="prodcut"></param>
        private void modifyProductScreenSetup(Product prodcut)
        {
            modifyProduct = prodcut; //setting modifyProduct to the product used in constructor

            //sets data from the passed in modifyProduct object
            idValue.Text = modifyProduct.ProductID.ToString();
            nameValue.Text = modifyProduct.Name;
            inventoryValue.Text = modifyProduct.InStock.ToString();
            priceCostValue.Text = modifyProduct.Price.ToString();
            maxValue.Text = modifyProduct.Max.ToString();
            minValue.Text = modifyProduct.Min.ToString();
            partsAssociatedDataGridView.DataSource = modifyProduct.AssociatedParts; //Setting display to copy of ModifyProduct Associated Parts list

            if (prodcut.AssociatedParts != null) //checks to make sure the prodcut Associated Parts list is not empty
            {
                for (int i = 0; i < prodcut.AssociatedParts.Count; i++) //loops though Associated parts, and adds all parts to another list to be used if the product screen is closed before saving
                {
                    AssociatedPartsCopy.Add(prodcut.AssociatedParts[i]);
                }
            }
 
            addProductLabel.Text = "Modify Product"; //changes the screen lable text to indicate the product is being modified
        }

        /// <summary>
        /// Event that triggers whenever the text in allCandidateSearchValue textbox is changed to being an empty string (ie. empty textbox)
        /// </summary>
        private void allCandidateSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (allCandidateSearchValue.Text == "") //checks to see if the content of the allCandidateSeachValue textbox is an empty string
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    allCandidateDataGridView.Rows[i].Visible = true; //sets all rows in the datagrid to being visable
                }
            }

        }

        /// <summary>
        /// function for searching the All Cadidates DataGrid useing an argument (string input)
        /// </summary>
        /// <param name="search"> string veriable used as the search comparison object </param>
        private void searchAllCadidatesDataGrid(string search)
        {
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (search != "" && int.TryParse(search, out int result) == true) //checks to make sure the search string is not empty, and then tries to see if it cna be parsed into an integer
                {
                    try
                    {
                        if (inventory.checkExistence(int.Parse(search)) == true) //checks to make sure that the search input exists in the list
                        {
                            integerSearch(search, i); //runs the integerSearch function that hides all rows that do not match the partID of the search string
                            continue; //continues the for loop
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
                        if (inventory.checkExistence(Inventory.AllParts[i]) == true) //checks to see if the part exists in the AllParts list
                        {
                            stringSearch(search, i); //runs the stringSearch function that hides all rows that do not math the part that is being searched
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
        private void stringSearch(String inputString, int i)
        {
            if (inputString == Inventory.AllParts[i].Name) //checks if the inputString is the same as the current parts name 
            {
                allCandidateDataGridView.Rows[i].Visible = true; //if so it will make sure that row containg the part stays visable, or makes it viable once again if it was already invisable
            }
            else
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[allCandidateDataGridView.DataSource]; //no idea what this is doing, but it fixed my exeption I was getting XD
                currencyManager.SuspendBinding();
                allCandidateDataGridView.Rows[i].Visible = false; //sets rows that do not match teh inputString to be invisable
                currencyManager.ResumeBinding();
            }
        }

        /// <summary>
        /// Function for seaching and manipulateing the allCandidatesDataGridView based on the Part ID
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="i"></param>
        private void integerSearch(String inputString, int i)
        {
            if (int.Parse(inputString) == Inventory.AllParts[i].PartID) //checks to see if the inputString match the part ID of the part in the list
            {
                allCandidateDataGridView.Rows[i].Visible = true; //if so it will make sure that row containg the part stays visable, or makes it viable once again if it was already invisable
            }
            else
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[allCandidateDataGridView.DataSource]; //same as above, I have no idea what this is doing XD but it fixes my issue, added it to the google list for later consumption
                currencyManager.SuspendBinding();
                allCandidateDataGridView.Rows[i].Visible = false;//sets rows that do not match teh inputString to be invisable
                currencyManager.ResumeBinding();
            }
        }
    }
}
