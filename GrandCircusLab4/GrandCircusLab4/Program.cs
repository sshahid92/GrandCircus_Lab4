using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GrandCircusLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataSet dataSet;
            //DataTable table = new DataTable();
            //DataColumn column;
            //DataRow row;

            ////Creat first column
            //column = new DataColumn();
            //column.DataType = Type.GetType("System.Int32");
            //column.ColumnName = "Number";
            //column.ReadOnly = true;
            //column.Unique = true;
            //// Add the Column to the DataColumnCollection.
            //table.Columns.Add(column);

            ////Creat second column
            //column = new DataColumn();
            //column.DataType = Type.GetType("System.Int32");
            //column.ColumnName = "Squared";
            //column.ReadOnly = true;
            //column.Unique = true;
            //// Add the Column to the DataColumnCollection.
            //table.Columns.Add(column);

            ////Creat third column
            //column = new DataColumn();
            //column.DataType = Type.GetType("System.Int32");
            //column.ColumnName = "Cubed";
            //column.ReadOnly = true;
            //column.Unique = true;
            //// Add the Column to the DataColumnCollection.
            //table.Columns.Add(column);

            //dataSet = new DataSet();
            //dataSet.Tables.Add(table);

            ////create rows
            //row = table.NewRow();
            //row["Number"] = i;
            //row["Squared"] = Math.Pow(i, 2);
            //row["Cubed"] = Math.Pow(i, 3);
            //table.Rows.Add(row);

            while (true)
            {

                Console.WriteLine("Enter a number.");

                int i;
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {

                    //string num = "Number";
                    //string squ = "Squared";
                    //string cub = "Cubed";
                    Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", "number", "squared", "cubed");
                    Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", "======", "=======", "=====");

                    for (i = 1; i <= number; ++i)
                    {
                        
                        var squared = Math.Pow(i, 2);
                        var cubed = Math.Pow(i, 3);

                        
                        Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", i, squared, cubed);
                        
                        

                    }

                    Console.WriteLine("Do you want to continue? y/n");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'y' or 'n'.");
                        
                    }

                }
                else
                {
                    Console.WriteLine("Enter a whole number");
                    continue;
                }
                
                

                
            }
        }
    }
}
