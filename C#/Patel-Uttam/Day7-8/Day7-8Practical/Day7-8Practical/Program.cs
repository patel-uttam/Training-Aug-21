using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7_8Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            var List1 = new List<int>();

            int[] a1;
            a1 = new int[5] {2,4,8,16,32};



            // Projection operator
            //select and SelectMany


            var select_query = from l1 in List1 select new {l1};

            var select_method = List1.Select(l1 => List1.ToList());  //toList method to convert output in List format

             var lists = new List<List<int>>();
            lists.Add(List1);

            var selectMany_query = from L1 in lists from list in lists[0] select list;

            var selectMany_method = lists.SelectMany(l1=>l1.ToList());

            
            
            /*filtering*/
            // where  and oftype

            List1.AddRange(a1);
            var where_query = from l1 in List1 where l1 % 2 == 0select l1;
            
            var where_operator = List1.Where(x => x < 17);

            var oftype_query = from l1 in List1 where l1 is int select l1;

            var oftype_method = List1.OfType<int>();



            //order by and group by

            var orderby_query = from l1 in List1 orderby l1 select l1;

            var orderby_method = List1.OrderBy(l1 => l1.ToString());

            var orderbydesending_method = List1.OrderByDescending(l1 => l1.ToString());

            var groupby_query = from l1 in List1 group l1 by l1.ToString();

            var groupby_method = List1.GroupBy(l1=>l1.ToString());


            //all

            var all_method = List1.All(l1 => l1 < 128);

            // max and min

            var max_method = List1.Max();

            var min_method = List1.Min();
            //contains 
            var is_contain = List1.Contains(6);

            Console.ReadKey();
        }


    }
}
