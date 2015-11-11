using SimpleCRM.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCRM.DAL
{
    public class CRMInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CRMContext>
    {
        protected override void Seed(CRMContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{Email="tom@email.com",FirstName="Tom",LastName="Harpur",Age=24,Gender="Male"},
                new Customer{Email="meg@gmail.com",FirstName="Meg",LastName="Smith",Age=34,Gender="Female"},
                new Customer{Email="tim@example.com",FirstName="Tim",LastName="Cook",Age=23,Gender="Male"},
                new Customer{Email="sarah@hotmail.com",FirstName="Sarah",LastName="Arch",Age=45,Gender="Female"},
                new Customer{Email="mark@email.com",FirstName="Mark",LastName="Johnson",Age=31,Gender="Male"},
                new Customer{Email="jack@email.com",FirstName="Jack",LastName="Cooper",Age=20,Gender="Male"}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var addresses = new List<Address>
            {
                new Address{CustomerID=1,NameOrNum="10",AddressLine1="Grange Road",AddressLine2="Guildford",Postcode="GU2 4DT",County="Surrey",Country="UK"},
                new Address{CustomerID=1,NameOrNum="Nest",AddressLine1="Porter Lane",AddressLine2="Wimbledon ",Postcode="SW19 4DT",County="London",Country="UK"},
                new Address{CustomerID=2,NameOrNum="6",AddressLine1="Trop Avenue",AddressLine2="Selly Oak",Postcode="B29 6AT",County="West Midlands",Country="UK"},
                new Address{CustomerID=3,NameOrNum="The White House",AddressLine1="Pool Road",AddressLine2="Miami",Postcode="45HT67",County="Florida",Country="USA"},
                new Address{CustomerID=3,NameOrNum="15",AddressLine1="Red Path",AddressLine2="Houston",Postcode="09FA32",County="Texas",Country="USA"}
            };

            addresses.ForEach(s => context.Addresses.Add(s));
            context.SaveChanges();
        }
    }
}