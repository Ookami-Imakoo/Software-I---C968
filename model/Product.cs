using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MatthewEvans___BFM1___Software_I___C968.model
{
    public class Product
    {
        /*
         *  Product Defualt Properties
         */
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }



        /// <summary>
        /// Defualt Constructor for Prodcut Object
        /// </summary>

        public Product()
        {

        }



        /// <summary>
        /// Copy Constructor
        /// </summary>
        public Product(Product product)
        {
            ProductID = product.ProductID;
            Name = product.Name;
            Price = product.Price;
            InStock = product.InStock;
            Min = product.Min;
            Max = product.Max;

            AssociatedParts = product.AssociatedParts;

        }


        /// <summary>
        /// Constroctor for Product Object that has no AssociatedParts list
        /// </summary>
        public Product(int ProductID, String Name, decimal Price, int InStock, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }

        /// <summary>
        /// Full Constructor for Product Object
        /// </summary>
        public Product(int ProductID, String Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> AssociatedParts)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.AssociatedParts = AssociatedParts;
        }

        /// <summary>
        /// Adds Associated Part to the Associated Parts List
        /// </summary>
        /// <param name="myPart"> Part to be added to the List </param>
        public void addAssociatedPart(Part myPart)
        {
            if (AssociatedParts == null && checkExistence(myPart) == false) //checks to see if Associated Parts list exists and checks if the part already exists in that list.
            {
                AssociatedParts = new BindingList<Part>(); //initializes AssociatedParts list
                AssociatedParts.Add(myPart); //adds part to AssociatedParts list
            }
            else if (checkExistence(myPart) == false) //if an Associated Parts list already exists, and the part has not already been added
            {
                AssociatedParts.Add(myPart); //adds part to AssociatedParts list
            }
            else
            {
                MessageBox.Show("You can not add duplicate parts."); // messaged returned if the part the user is adding already exists in the list
            }
        }

        /// <summary>
        /// Removes part from AssociatedParts list
        /// </summary>
        /// <param name="x"> PartID of the part to be removed </param>
        /// <returns></returns>
        public bool removeAssoicatedPart(int x)
        {
           for(int i = 0; i < AssociatedParts.Count; i++) //loops though all parts in AssociatedParts list
            {
                if (AssociatedParts[i].PartID == x) //checks to see if the PartID of the Associated Part in the list matches the PartID parameter
                {
                    if(AssociatedParts.Count == 1) //if above logic is true then it checks to see if there is only one entry in the AssociatedParts list
                    {
                        AssociatedParts.Clear(); //if its the last part in the list, then the list is cleared
                    }
                    else
                    {
                        AssociatedParts.Remove(AssociatedParts[i]); //otherwise AssociatedPart is removed
                    }     
                return true; //retuning true if part was removed
                }
            }
            return false; //returning flase if part was not removed
        }

        /// <summary>
        /// Made because the UML document demanded it, but not refrenced at all
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Part lookupAssoicatedPart(int x)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (x == ProductID)
                {
                    return AssociatedParts[i];
                }
                continue;
            }
            return null;
        }

        /// <summary>
        /// Checks to see if the part in parameter exists in the AssociatedParts list
        /// </summary>
        public bool checkExistence(Part part)
        {
            if(AssociatedParts != null) //checks if the AssociatedParts list is null
            {
                for (int i = 0; i < AssociatedParts.Count; i++) //loop of AssociatedParts list
                {
                    if (AssociatedParts[i].PartID == part.PartID) //checks if the AssociatedParts PartID match the Parameters PartID
                    {
                        return true; //return true if the part exists in AssociatedParts list
                    }
                }
            }
            return false; //returns false if AssociatedParts list is null
        }

        /// <summary>
        /// Method used to validate product data
        /// </summary>
        /// <returns> bool </returns>
        public bool productValidation(Product product) //takes product to be validated as argument
        {
            if (minGraterThanMax(product) == false) //first checks to see if the products min value is grater than the instock value
            {
                if (minGraterThanInstock(product) == false) //then checks to see if the min is grater than the instock
                {
                    if (maxLessthanInstock(product) == false) //finally checks to see if the max is less than the instock
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Method used to determin if a products "Min" value is grater than the "Max" value
        /// </summary>
        /// <param name="product"> product to be evaluated </param>
        /// <returns> bool </returns>
        public bool minGraterThanMax(Product product)
        {
            if (product.Min > product.Max)
            {
                MessageBox.Show($"Alright, you need to take a min, because what you enterend made no sence. The Min is grater than the max???? Are you drunk?");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to determin if a produts "Min" is greater than the "Instock" value
        /// </summary>
        /// <param name="product"> prodcut to be evaluated </param>
        /// <returns> bool </returns>
        public bool minGraterThanInstock(Product product)

        {
            if (product.Min > product.InStock)
            {
                MessageBox.Show($"Amount Instock for {product.Name} is less than the allowed Minimum");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method used to detmine if a products "Max" value is less than the "Instock" value
        /// </summary>
        /// <param name="product"> product to be evaluated </param>
        /// <returns> bool </returns>
        public bool maxLessthanInstock(Product product)
        {
            if (product.Max < product.InStock)
            {
                MessageBox.Show($"Amount Instock for {product.Name} is greater than the allowed Maximum");
                return true;
            }
            return false;
        }
    }
}
