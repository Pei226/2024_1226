using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1226_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
                            Puppy DennisPuppy = new Puppy();
                //設定DennisPuppy的屬性值.
                DennisPuppy.Id = 112;
                DennisPuppy.Owner = "Dennis";
                DennisPuppy.Description = "cute";
                DennisPuppy.Price = 12000;
                DennisPuppy.Age = 1;
                DennisPuppy.Type = "哈士奇";
                DennisPuppy.money = 6500;
                //類堆..所有屬性都要設.

                //最後,叫用DennisPuppy的方法PrintAllAttrib( )印出所有屬性參數.
                DennisPuppy.PrintAllAttrib();

                //===============================================
                //第二個 使用有參數的建構子設一隻寵物MarysPuppy.
                //經由建構子函式2 來設定所有屬性
                Puppy MarysPuppy = new Puppy(123, "Mary", "pretty", 15500, 1, "薩摩耶", 5500);

                //最後,叫用 MarysPuppy的方法PrintAllAttrib( )印出所有屬性參數.
                MarysPuppy.PrintAllAttrib();


            }
        }
    }


