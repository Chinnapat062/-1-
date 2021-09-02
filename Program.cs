using System;
using System.Collections.Generic;

namespace การบ้าน
{
    
    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(string valuesize,string valuecolor,float valueprice)
        {
            size = valuesize;
            color = valuecolor;
            price = valueprice;
        }

    }
    class User
    {
        public string name;
        public string email;
        public List<Tshirt> order;
        public User (string valuename)
        {
            name = valuename;
            
            order = new List<Tshirt>();
        }


        public void addlist(Tshirt shirt)
        {
            order.Add(shirt);
        }

        public void getShoppingCart()
        {
            foreach (Tshirt totalshirt in order)
            {
                Console.WriteLine(totalshirt.price);
            }
        }
        public void getShopping()
        {
            float totalprice = 0;
            foreach (Tshirt totalshirt in order)
            {
                totalprice = totalshirt.price + totalprice;
            }
            Console.WriteLine(totalprice);
        }



    }
    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valuestreet,string valuecity,string valuezipcode)
        {
            street = valuestreet;
            city = valuecity;
            zipcode = valuezipcode;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame");
            jame.name = "jame watson";
            jame.email = "jame@gmail";
            
            Tshirt shirt1 = new Tshirt("L", "Red", 500);
            Tshirt shirt2 = new Tshirt("M", "Black", 750);
            Tshirt shirt3 = new Tshirt("S", "Yelow", 625);

            jame.addlist(shirt1);
            jame.addlist(shirt2);
            jame.addlist(shirt3);

            Address customeraddress = new Address("131/75 puttamontol","Nakron pathom","10180");
            

           jame.getShopping();

        }

    }
   
}
