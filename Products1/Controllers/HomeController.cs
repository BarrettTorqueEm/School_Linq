using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products1.Models;

namespace Products1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Createing a Connection to database and Lists 
            DBConnection aConnection = new DBConnection();

            ProductList aListOfProducts = new ProductList();

            List<Product> aListOfProductsPrice = new List<Product>();

            aListOfProducts = aConnection.GetProducts();

             //Start  LINQ 
            #region// LINQ statments
            var aListByPriceA = from aProduct in aListOfProducts orderby aProduct.UnitPrice select aProduct;

            var aListByPriceB = from aProduct in aListOfProducts orderby aProduct.UnitPrice
                                where (aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) select aProduct;

            var aListByPriceC = from aProduct in aListOfProducts orderby aProduct.UnitPrice
                                where ((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40)
                                select aProduct;

            var aListByPriceD = from aProduct in aListOfProducts orderby aProduct.ProductName
                                where (((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40)) 
                                      && (aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))) 
                                select aProduct;

            var aListByPriceE = from aProduct in aListOfProducts
                                orderby aProduct.ProductName
                                where (((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && (aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q")))
                                select aProduct;

            var aListByPriceF = from aProduct in aListOfProducts
                                orderby aProduct.ProductName
                                where (((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && (aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                select aProduct;

            var aListByPriceG = from aProduct in aListOfProducts
                                orderby aProduct.ProductId
                                where (((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22)))
                                select aProduct;

            var aListByPriceH = from aProduct in aListOfProducts
                                orderby aProduct.ProductId
                                where (((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22) || (aProduct.ProductId < 77 && aProduct.ProductId > 50)))
                                select aProduct;

            var aListByPriceI = from aProduct in aListOfProducts
                                orderby aProduct.ProductId
                                where ((((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22) || (aProduct.ProductId < 77 && aProduct.ProductId > 50))) 
                                      || (aProduct.ProductName.StartsWith("C")  && (aProduct.UnitPrice < 20)))
                                select aProduct;

            var aListByPriceJ = from aProduct in aListOfProducts
                                orderby aProduct.UnitPrice
                                where ((((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22) || (aProduct.ProductId < 77 && aProduct.ProductId > 50)))
                                      || (aProduct.ProductName.StartsWith("C") && (aProduct.UnitPrice < 20)))
                                select aProduct;

            var aListByPriceK = from aProduct in aListOfProducts
                                orderby aProduct.UnitPrice descending
                                where ((((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22) || (aProduct.ProductId < 77 && aProduct.ProductId > 50)))
                                      || (aProduct.ProductName.StartsWith("C") && (aProduct.UnitPrice < 20)))
                                select aProduct;

            var aListByPriceL = from aProduct in aListOfProducts
                                orderby aProduct.UnitPrice descending, aProduct.ProductName
                                where ((((aProduct.UnitPrice >= 10 && aProduct.UnitPrice <= 15) || (aProduct.UnitPrice >= 30 && aProduct.UnitPrice <= 40))
                                      && ((aProduct.ProductName.StartsWith("A") || aProduct.ProductName.StartsWith("B") || aProduct.ProductName.StartsWith("C") || aProduct.ProductName.StartsWith("D"))
                                      || (aProduct.ProductName.StartsWith("M") || aProduct.ProductName.StartsWith("N") || aProduct.ProductName.StartsWith("O") || aProduct.ProductName.StartsWith("P") || aProduct.ProductName.StartsWith("Q"))
                                      || (aProduct.ProductName.StartsWith("W") || aProduct.ProductName.StartsWith("X") || aProduct.ProductName.StartsWith("Y") || aProduct.ProductName.StartsWith("Z")))
                                      && ((aProduct.ProductId <= 27 && aProduct.ProductId >= 22) || (aProduct.ProductId < 77 && aProduct.ProductId > 50)))
                                      || (aProduct.ProductName.StartsWith("C") && (aProduct.UnitPrice < 20)))
                                select aProduct;
            #endregion

            #region//Add LINQ reaults to ViewBag
            ViewBag.aListOfProductsA = aListByPriceA;

            ViewBag.aListOfProductsB = aListByPriceB;

            ViewBag.aListOfProductsC = aListByPriceC;

            ViewBag.aListOfProductsD = aListByPriceD;

            ViewBag.aListOfProductsE = aListByPriceE;

            ViewBag.aListOfProductsF = aListByPriceF;

            ViewBag.aListOfProductsG = aListByPriceG;

            ViewBag.aListOfProductsH = aListByPriceH;

            ViewBag.aListOfProductsI = aListByPriceI;

            ViewBag.aListOfProductsJ = aListByPriceJ;

            ViewBag.aListOfProductsK = aListByPriceK;

            ViewBag.aListOfProductsL = aListByPriceL;
            #endregion

            //testing things****************************************************
            Product aTestOfProduct = new Product(10, "test", 3, 5, "Test", 2, 1, 3, 4, false);

            aListOfProducts.Add(aTestOfProduct);

            ViewBag.aTestList = aListOfProducts;
            //******************************************************************
            return View();
        }
    }
}