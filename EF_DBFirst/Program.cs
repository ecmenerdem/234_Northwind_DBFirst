using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            int selectedOrderID = 0;
            NORTHWINDEntities northwindContext = new NORTHWINDEntities();

            //var orders = northwindContext.Orders;

            //var orderList = orders.Count(q=>q.CustomerID== "VINET");

            //------------------------------------------------------------------------
            //var orderDTOList = orders.OrderBy(q => q.CustomerID).Select(q => new OrderDTO()
            //{
            //    OrderDate = q.OrderDate,
            //    OrderID = q.OrderID,
            //    CustomerID = q.CustomerID,
            //    ShipName=q.ShipName
            //}).ToList();


            //var count=orderDTOList.Count(q=>q.CustomerID== "ALFKI");

            //foreach (var item in orderDTOList)
            //{
            //    Console.WriteLine(item.OrderDate + " " + item.OrderID + " " + item.CustomerID);
            //}


            //-----------------------------------------------



            //var orderDTOList2 = orders.OrderBy(q => q.CustomerID).Select(q => new
            //{
            //    OrderDate = q.OrderDate,
            //    OrderID = q.OrderID,
            //    CustomerID = q.CustomerID,
            //    ShipName = q.ShipName
            //}).ToList();





            //---------------------------------------------------------------------------
            //var orderDTOList1 = orders.OrderBy(q => q.CustomerID).ToList();

            //var count1 = orderDTOList1.Count(q => q.CustomerID == "ALFKI");

            //foreach (var item in orderDTOList1)
            //{
            //    Console.WriteLine(item.OrderDate + " " + item.OrderID + " " + item.CustomerID);
            //}

            //foreach (var order in orderDTOList)
            //{
            //    Console.WriteLine($"{order.OrderID}-{order.OrderDate.Value.ToShortDateString()}-{order.CustomerID}-{order}");
            //}

            //foreach (var order in orderList)
            //{
            //    Console.WriteLine($"{order.OrderID}-{order.OrderDate.Value.ToShortDateString()}-{order.CustomerID}-{order.Customers.ContactName}");
            //}

            //Console.WriteLine("Sipariş Numarası Giriniz: ");

            //int orderID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Customer ID Giriniz");

            //string customerID = Console.ReadLine();

            //var orders = northwindContext.Orders.Where(q => q.OrderID == orderID).SingleOrDefault();

            //var ordersSQL = northwindContext.Orders.Where(q => q.OrderID == orderID).ToString();

            //var a = northwindContext.Customers.Where(q => q.CustomerID == customerID);

            //var x= a.ToList();

            //SqlParameter parameter1 = new SqlParameter();


            //var b = northwindContext.Database.SqlQuery<Customers>($"select * from Customers where CustomerID={customerID}");


            //var b = northwindContext.Database.SqlQuery<Customers>("select * from Customers where CustomerID=@param1 AND ORDERID=@param2", new SqlParameter("@param1", customerID));

            //var c= b.ToList();

            //OrderDTO orderDTO = new OrderDTO();

            //orderDTO.Products = new List<Products>();

            //foreach (var item in orders.Order_Details)
            //{
            //    orderDTO.Products.Add(item.Products);
            //}

            //orderDTO.Products = orders.Order_Details.Select(q => q.Products).ToList();

            //foreach (var product in orderDTO.Products)
            //{
            //    Console.WriteLine($"{product.ProductName}");
            //}

            //   Console.WriteLine("Andrew İçin");
            //   var employee = northwindContext.Employees.Where(q => q.FirstName == "Andrew")
            //       .Include("Orders.Order_Details.Products.Categories")
            //.FirstOrDefault();
            //   foreach (var order in employee.Orders)
            //   {
            //       foreach (var orderDetail in order.Order_Details)
            //       {
            //           Console.WriteLine(orderDetail.Products.ProductName + "-" + orderDetail.Products.Categories.CategoryName);
            //       }
            //   }

            //   Console.WriteLine("Laura İçin-----------------");

            //   var employee1 = northwindContext.Employees.Where(q => q.FirstName == "Laura").FirstOrDefault();

            //   foreach (var order in employee1.Orders)
            //   {
            //       foreach (var orderDetail in order.Order_Details)
            //       {
            //           Console.WriteLine(orderDetail.Products.ProductName + "-" + orderDetail.Products.Categories.CategoryName);
            //       }
            //   }


            //------------------------------------------------------------------------

            //Console.WriteLine("Order No Giriniz");
            //int OrderID = Convert.ToInt32(Console.ReadLine());
            //var order = northwindContext.Orders.Where(q => q.OrderID == OrderID)
            //    .Include("Order_Details.Products").FirstOrDefault();

            //List<Order_Details> orderDetails = new List<Order_Details>();


            //decimal GrandTotal = 0;
            //foreach (var orderDetail in order.Order_Details)
            //{

            //    Console.WriteLine("Product Name: " + orderDetail.Products.ProductName);
            //    Console.WriteLine("Quantity: "+ orderDetail.Quantity);

            //    Console.WriteLine("Unit Price: "+ orderDetail.UnitPrice);

            //    Console.WriteLine("UnitTotal: "+ orderDetail.Quantity* orderDetail.UnitPrice);
            //    Console.WriteLine(Environment.NewLine);
            //    Console.WriteLine("--------------------");
            //    Console.WriteLine(Environment.NewLine);
            //    GrandTotal += orderDetail.Quantity * orderDetail.UnitPrice;
            //}
            //Console.WriteLine("Grand Total: " + GrandTotal)
            //---------------------------------------------------------------------------

            //Console.WriteLine("Customer ID Giriniz");

            //string customerID = Console.ReadLine();

            //var customer = northwindContext.Customers.Where(q => q.CustomerID == customerID)
            //    .Include("Orders.Order_Details.Products").FirstOrDefault();


            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("Toplam Sipariş Sayısı: " + customer.Orders.Count());

            //decimal GrandTotal = 0;

            //foreach (var order1 in customer.Orders)
            //{
            //    Console.WriteLine(Environment.NewLine);
            //    Console.WriteLine("OrderNo: " + order1.OrderID);
            //    Console.WriteLine(Environment.NewLine);
            //    Console.WriteLine("----Order Details----");
            //    Console.WriteLine(Environment.NewLine);

            //    decimal OrderTotal = 0;

            //    foreach (var orderDetail in order1.Order_Details)
            //    {
            //        Console.WriteLine("Product Name: " + orderDetail.Products.ProductName);
            //        Console.WriteLine("Quantity: " + orderDetail.Quantity);

            //        Console.WriteLine("Unit Price: " + orderDetail.UnitPrice);

            //        Console.WriteLine("UnitTotal: " + orderDetail.Quantity * orderDetail.UnitPrice);
            //        Console.WriteLine(Environment.NewLine);
            //        OrderTotal += orderDetail.Quantity * orderDetail.UnitPrice;
            //    }
            //    Console.WriteLine("Order Total: " + OrderTotal);

            //    Console.WriteLine("--------------------");
            //    Console.WriteLine(Environment.NewLine);

            //    GrandTotal += OrderTotal;
            //}
            //Console.WriteLine("Grand Total: " + GrandTotal);

            //----------------------------------------------------------------------

            /*  1-Sipariş Bilgilerini Göster
                    1.1-Siparis Detayı
                        1.1.1-Anasayfaya Dön
                        1.1.2-Geri Dön
                    1.2-Yeni Sorgulama
            */

            // 2-Yeni Sipariş Ver

            ShowMainMenu();







            Console.ReadLine();



            #region Ekranlar

            void ShowMainScreen()
            {
                Console.Clear();
                ShowMainMenu();
            }
            void ShowOrderInfoScreen()
            {
                Console.Clear();

                Console.Write("Siparis No Giriniz: ");

                int siparisNo = Convert.ToInt32(Console.ReadLine());
                selectedOrderID = siparisNo;
                Console.Clear();

                WriteOrderInfo(GetOrderInfo(siparisNo));
            }
            void ShowOrderDetailScreen()
            {
                Console.Clear();
            }

            void ShowNewOrderScreen()
            {
                ShowAllProductsScreen();
            }

            void ShowAllProductsScreen()
            {
                WriteProductList(GetAllProducts());
            }


            #endregion

            #region Menüler
            void ShowMainMenu()
            {
                Console.WriteLine("------KAÇAK SHOP'A HOŞGELDİNİZ------");
                Console.WriteLine("1-Sipariş Bilgilerini Göster");
                Console.WriteLine("2-Yeni Sipariş Ver");

                int anaMenuCevap = Convert.ToInt32(Console.ReadLine());
                if (anaMenuCevap == 1)
                {
                    ShowOrderInfoScreen();
                }
                else if (anaMenuCevap == 2)
                {
                    Console.Clear();
                    Console.WriteLine("----Ürün Listesi----");
                    Console.WriteLine(Environment.NewLine);
                    ShowNewOrderScreen();
                }
            }
            void ShowOrderInfoMenu()
            {
                Console.WriteLine("1-Anasayfaya Dön");
                Console.WriteLine("2-Siparis Detayı");
                Console.WriteLine("3-Yeni Sorgulama");

                int OrderInfoMenuCevap = Convert.ToInt32(Console.ReadLine());

                if (OrderInfoMenuCevap == 1)
                {
                    ShowMainScreen();
                }
                else if (OrderInfoMenuCevap == 2)
                {
                    Console.Clear();
                    WriteOrderDetails(selectedOrderID);
                }
                else if (OrderInfoMenuCevap == 3)
                {
                    ShowOrderInfoScreen();
                }
            }
            void ShowOrderDetailMenu()
            {
                Console.WriteLine("1-Anasayfaya Dön");
                Console.WriteLine("2-Geri Dön");

                int OrderDetailMenuCevap = Convert.ToInt32(Console.ReadLine());

                if (OrderDetailMenuCevap == 1)
                {
                    ShowMainScreen();
                }
                else if (OrderDetailMenuCevap == 2)
                {
                    Console.Clear();
                    WriteOrderInfo(GetOrderInfo(selectedOrderID));
                }
            }

            #endregion

            #region Metotlar

            OrderDTO GetOrderInfo(int orderID)
            {
                var order = northwindContext.Orders.Where(q => q.OrderID == orderID)
                    .Include("Customers")
                    .Include("Employees").FirstOrDefault();

                OrderDTO orderDTO = new OrderDTO()
                {
                    OrderID = order.OrderID,
                    CustomerName = order.Customers.ContactName,
                    EmployeeName = order.Employees.FirstName + " " + order.Employees.LastName,
                    OrderDate = order.OrderDate.Value.ToShortDateString(),
                    ShipAdress = order.ShipAddress,
                    ShipCountry = order.ShipCountry,
                    ShipCity = order.ShipCity
                };

                return orderDTO;
            }
            void WriteOrderInfo(OrderDTO orderDTO)
            {
                Console.WriteLine("Sipariş Bilgileri");
                Console.WriteLine("-------------------------");
                Console.WriteLine("OrderID: " + orderDTO.OrderID);
                Console.WriteLine("Order Date: " + orderDTO.OrderDate);
                Console.WriteLine("Customer Name: " + orderDTO.CustomerName);
                Console.WriteLine("Employee Name:" + orderDTO.EmployeeName);
                Console.WriteLine("Ship Country/City: " + orderDTO.ShipCountry + "/" + orderDTO.ShipCity);
                Console.WriteLine("Ship Adress: " + orderDTO.ShipAdress);
                Console.WriteLine(Environment.NewLine);
                ShowOrderInfoMenu();
            }
            void WriteOrderDetails(int orderID)
            {
                Console.WriteLine($"{orderID} No lu Sipariş Detayları");
                var order = northwindContext.Orders.Where(q => q.OrderID == orderID)
                    .Include
                   ("Order_Details.Products").FirstOrDefault();
                Console.WriteLine(Environment.NewLine);

                decimal OrderTotal = 0;
                foreach (var orderDetail in order.Order_Details)
                {
                    Console.WriteLine("Product Name: " + orderDetail.Products.ProductName);
                    Console.WriteLine("Quantity: " + orderDetail.Quantity);

                    Console.WriteLine("Unit Price: " + orderDetail.UnitPrice);

                    Console.WriteLine("UnitTotal: " + orderDetail.Quantity * orderDetail.UnitPrice);
                    Console.WriteLine(Environment.NewLine);
                    OrderTotal += orderDetail.Quantity * orderDetail.UnitPrice;
                }
                Console.WriteLine("Order Total: " + OrderTotal);
                Console.WriteLine(Environment.NewLine);
                ShowOrderDetailMenu();

            }
            void WriteProductList(List<ProductDTO> products)
            {
                foreach (var item in products)
                {
                    Console.WriteLine($"Product No: {item.ID} - Product Name: {item.Name} - Unit Price: {item.UnitPrice} - Stock: {item.Stock}");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                }

            }

            List<ProductDTO> GetAllProducts()
            {
                List<ProductDTO> productList = new List<ProductDTO>();
                var products = northwindContext.Products.ToList();

                foreach (var item in products)
                {
                    //ProductDTO product = new ProductDTO()
                    //{
                    //    ID = item.ProductID,
                    //    Name = item.ProductName,
                    //    Stock = item.UnitsInStock,
                    //    UnitPrice = item.UnitPrice,
                    //};

                    productList.Add(new ProductDTO()
                    {
                        ID = item.ProductID,
                        Name = item.ProductName,
                        Stock = item.UnitsInStock,
                        UnitPrice = item.UnitPrice,
                    });
                }

                return productList;

            }
        }

        #endregion
    }




}


