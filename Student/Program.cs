using System;
using System.IO;
using System.Text;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
                var path2 = @"C:\Users\studentRemarks2.txt";                                           // File.OpenRead
 /*comment this line out and run again*/  File.Create(path2);  
                  var path = @"C:\Users\studentScore.txt";                                              
                 string[] text = File.ReadAllLines(path);
                     // Console.WriteLine(text[0]);                                                    //  File.ReadLines(path);
                 
               foreach (var item in text)

            {
               string [] subs = item.Split(' ');
                int x = int.Parse(subs[1]);
            if (x < 50) { x += 10; }
                 else x+=5;
                // Console.WriteLine(x);                                                   //     using  ( TextReader reader = File.OpenText(path))
                string v = subs[0];
               File.AppendAllLines(path2, new String[] { v,Convert.ToString(x)});
               

            }                                                                                                   // int x = int.TryParse(item);
                                                                                                               // Console.WriteLine(x);
          






           


        }
    }
}