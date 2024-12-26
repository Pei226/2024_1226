using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1226_001
{
    internal class Puppy
    {
                    //屬性
            public int Id { get; set; }  //寵物哀低
            public string Owner { get; set; }  //寵物主人
            public string Description { get; set; } //寵物描述
            public double Price { get; set; }//寵物價格
            public double Age { get; set; } //寵物年紀
            public string Type { get; set; }  //寵物品種

            private double _money; //伙食費
            public double money
            {
                get { return this._money; }
                set { this._money = value; }
            }

            //建構子函式1
            public Puppy() { }

            //建構子函式2 
            public Puppy(int id, string vOwner, string description, double price, double Age1, string type, double money1)
            {
                Id = id;
                Owner = vOwner;
                Description = description;
                Price = price;
                Age = Age1;
                Type = type;
                money = money1;

            }

            public void PrintAllAttrib()
            {
                Console.WriteLine("ID is:" + this.Id.ToString());
                Console.WriteLine("Owener is :" + this.Owner.ToString());
                Console.WriteLine("Description is :" + this.Description.ToString());
                Console.WriteLine("Price is :" + this.Price.ToString());
                Console.WriteLine("Age is :" + this.Age.ToString());
                Console.WriteLine("Type is :" + this.Type.ToString());
                Console.WriteLine("money is :" + this.money.ToString());
                //類推..把所有屬性印出來.

            }
        }
    }
