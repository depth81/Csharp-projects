using MusicStore.Models;
using System;
using System.Collections.Generic;

namespace MusicStore.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {

        protected override void Seed(StoreContext context)
        {

            var customers = new List<Customer>
            {
            new Customer{ID=1050,FirstName="Evan",LastName="Appleton", Address = "3827 Colonial Wagon Downs", City="Lynn", Country="USA"},
            new Customer{ID=4022,FirstName="Ernest",LastName="Archer", Address = "4661 Middle Ledge", City="Shippegan", Country="USA"},
            new Customer{ID=4041,FirstName="Liam",LastName="Armstrong", Address = "6460 Green Lagoon Corner", City="Woodbine Acres", Country="USA"},
            new Customer{ID=1045,FirstName="Veronica",LastName="Barnes", Address = "6278 Thunder Canyon", City="Dos Cabezas", Country="USA"},
            new Customer{ID=3141,FirstName="Casey",LastName="Barrett", Address = "3008 Little Robin Island", City="Aiken", Country="USA"},
            new Customer{ID=2021,FirstName="America",LastName="Rimmer", Address = "6612 Fallen Inlet", City="Damascus", Country="USA"},
            new Customer{ID=2042,FirstName="Joyce",LastName="Ness", Address = "6432 Umber Rise Isle", City="Five Oaks", Country="USA"},
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{ CustomerID=1050, ProductID=80, OrderNumber=123, OrderDate=DateTime.Parse("2005-09-01")},
                new Order{ CustomerID=4022, ProductID=70, OrderNumber=345, OrderDate=DateTime.Parse("2015-09-02")},
                new Order{ CustomerID=4041, ProductID=60, OrderNumber=567, OrderDate=DateTime.Parse("2020-03-04")},
                new Order{ CustomerID=1045, ProductID=50, OrderNumber=998, OrderDate=DateTime.Parse("2003-08-11")},
                new Order{ CustomerID=3141, ProductID=40, OrderNumber=876, OrderDate=DateTime.Parse("2018-09-10")},
                new Order{ CustomerID=2021, ProductID=30, OrderNumber=812, OrderDate=DateTime.Parse("2011-01-01")},
                new Order{ CustomerID=2042, ProductID=20, OrderNumber=665, OrderDate=DateTime.Parse("2014-12-12")},
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();


            //var products = new List<Product>
            //{
            //new Product{ProductID=20,ProductName ="Piano Keyboard",ProductDescr="Yamaha Keyboard",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/piano.jpg?raw=true", Category=Category.pianos},
            //new Product{ProductID=30,ProductName="Electric Guitar",ProductDescr="Gibson Classic",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/electricguitar.jpg?raw=true", Category=Category.guitars},
            //new Product{ProductID=40,ProductName="Electric Bass",ProductDescr="Fender Bass",Picture ="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/bass.jpg?raw=true",Category=Category.basses},
            //new Product{ProductID=50,ProductName="Drum set",ProductDescr="Mapex",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/drums.jpg?raw=true", Category=Category.percussion},
            //new Product{ProductID=60,ProductName="Guitar amp",ProductDescr="Marshall DSL40C",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/marshall.jpg?raw=true", Category=Category.amps},
            //new Product{ProductID=70,ProductName="Classical Trumpet",ProductDescr="Bach 180 series",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/trumpet.jpg?raw=true", Category=Category.trumpet},
            //new Product{ProductID=80,ProductName="Musical Book",ProductDescr="complete music theory",Picture="https://github.com/depth81/img_M3_lengDeProg_CSharp/blob/main/MusicBook.jpg?raw=true", Category=Category.books}

            //};

            //products.ForEach(s => context.Products.Add(s));
            //context.SaveChanges();


        }
    }
}