using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Products1.Models{


    public class Product
    {

        // private variables
        private int productId = -1;
        private string productName = "na";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "na";
        private decimal unitPrice = 10000000.00M;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = -1;
        private bool discontinued = false;


        // gets & sets
        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
            }
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                this.productName = value;
            }

        }

        public int SupplierId
        {

            get
            {
                return this.supplierId;
            }

            set
            {

                this.supplierId = value;
            }

        }

        public int CategoryId
        {

            get
            {
                return this.categoryId;
            }

            set
            {

                this.categoryId = value;

            }

        }

        public string QuantityPerUnit
        {
            get
            {
                return this.quantityPerUnit;
            }

            set
            {
                this.quantityPerUnit = value;

            }
        }

        public decimal UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                this.unitPrice = value;

            }

        }

        public int UnitsInStock
        {

            get
            {
                return this.unitsInStock;
            }

            set
            {
                this.unitsInStock = value;

            }

        }

        public int UnitsOnOrder
        {

            get
            {
                return this.unitsOnOrder;
            }

            set
            {
                this.unitsOnOrder = value;

            }

        }

        public int ReorderLevel
        {
            get
            {
                return this.reorderLevel;
            }

            set
            {
                this.reorderLevel = value;

            }

        }

        public bool Discontinued
        {

            get
            {
                return this.discontinued;
            }

            set
            {
                this.discontinued = value;
            }

        }

        // Constructors 

        public Product()
        {
            
        }

        //Constructors
        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string 	aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel, 	bool aDiscontinued)
            : this()
        {

            this.productId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsOnOrder = aUnitsOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, -1, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, aUnitsInStock, -1, -1, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string 	aQuantityPerUnit, decimal aUnitPrice)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, aUnitPrice, -1, -1, -1, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, aQuantityPerUnit, 1000000000, -1, -1, -1, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId)
            : this(aProductId, aProductName, aSupplierId, aCategoryId, "na", 1000000000, -1, -1, -1, false)
        {

        }

        public Product(int aProductId, string aProductName, int aSupplierId)
            : this(aProductId, aProductName, aSupplierId, -1, "na", 1000000000, -1, -1, -1, false)
        {

        }

        public Product(int aProductId, string aProductName)
            : this(aProductId, aProductName, -1, -1, "na", 1000000000, -1, -1, -1, false)
        {

        }

        public Product(int aProductId)
            : this(aProductId, "na", -1, -1, "na", 1000000000, -1, -1, -1, false)
        {

        }

        //The toString method begins here

        //ToString
        public override string ToString()
        {

            string aString = "";
            aString = aString + "Product Id = " + ProductId + "\n";
            aString = aString + "Product Name = " + ProductName + "\n";
            aString = aString + "Supplier Id = " + SupplierId + "\n";
            aString = aString + "Category Id = " + CategoryId + "\n";
            aString = aString + "Quantity per unit = " + QuantityPerUnit + "\n";
            aString = aString + "UnitPrice = " + UnitPrice + "\n";
            aString = aString + "UnitInStock = " + UnitsInStock + "\n";
            aString = aString + "UnitsOnOrder = " + UnitsOnOrder + "\n";
            aString = aString + "ReorderLevel = " + ReorderLevel + "\n";
            aString = aString + "Discontinued = " + Discontinued + "\n";


            return aString;

        }

        public string Display()
        {

            string aString = "";
            aString = aString + "Product Id = " + ProductId + "<br />";
            aString = aString + "Product Name = " + ProductName + "<br />";
            aString = aString + "Supplier Id = " + SupplierId + "<br />";
            aString = aString + "Category Id = " + CategoryId + "<br />";
            aString = aString + "Quantity per unit = " + QuantityPerUnit + "<br />";
            aString = aString + "UnitPrice = " + UnitPrice + "<br />";
            aString = aString + "UnitInStock = " + UnitsInStock + "<br />";
            aString = aString + "UnitsOnOrder = " + UnitsOnOrder + "<br />";
            aString = aString + "ReorderLevel = " + ReorderLevel + "<br />";
            aString = aString + "Discontinued = " + Discontinued + "<br />";

            return aString;

        }


    }

}
 
