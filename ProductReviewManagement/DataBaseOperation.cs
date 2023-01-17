using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class DataBaseOperation
    {
        DataTable dataTable;
        public void CreateDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            dataTable.Rows.Add(1, 2, 4, "Good", true);
            dataTable.Rows.Add(4, 3, 3.5, "Nice", true);
            dataTable.Rows.Add(3, 6, 3, "Good", true);
            dataTable.Rows.Add(1, 2, 2, "bad", false);
            dataTable.Rows.Add(1, 10, 4, "Good", true);
            dataTable.Rows.Add(1, 4, 4.5, "VeryGood", true);
            dataTable.Rows.Add(1, 3, 3, "Good", true);
            dataTable.Rows.Add(6, 10, 1, "VeryBad", false);
            dataTable.Rows.Add(2, 1, 3, "Good", true);
            dataTable.Rows.Add(8, 1, 3.5, "Nice", true);
            dataTable.Rows.Add(9, 2, 2, "bad", false);
            dataTable.Rows.Add(10, 3, 3.5, "Good", true);
            dataTable.Rows.Add(4, 2, 1, "VeryBad", false);
            dataTable.Rows.Add(2, 4, 4, "Good", true);
            dataTable.Rows.Add(3, 2, 4.5, "VeryGood", true);
            dataTable.Rows.Add(5, 6, 4, "Good", true);
            dataTable.Rows.Add(5, 5, 3, "Nice", true);
            dataTable.Rows.Add(1, 4, 2, "bad", false);
            dataTable.Rows.Add(9, 5, 3.5, "Good", true);
            dataTable.Rows.Add(8, 2, 4, "Good", true);
            dataTable.Rows.Add(7, 3, 4.5, "VeryGood", true);
            dataTable.Rows.Add(2, 2, 3.5, "Good", true);
            dataTable.Rows.Add(3, 4, 1, "VeryBad", false);
            dataTable.Rows.Add(6, 10, 4.5, "VeryGood", true);
            dataTable.Rows.Add(9, 5, 3, "Nice", true);
            Console.WriteLine("\nData Table is Created");
        }
        public void RetrieveIsLikeValueWithTrue()
        {
            var records = from row in dataTable.AsEnumerable() where row.Field<bool>("IsLike") == true select row;
            foreach (DataRow row in records)
            {
                Console.WriteLine("ProductID: " + row["ProductID"]);
                Console.WriteLine("UserID: " + row["UserID"]);
                Console.WriteLine("Rating: " + row["Rating"]);
                Console.WriteLine("Review: " + row["Review"]);
                Console.WriteLine("IsLike: " + row["IsLike"]);
                Console.WriteLine("--------------");
            }
        }
        public void AvgRatingOfProductId()
        {
            var records = from row in dataTable.AsEnumerable() group row by row.Field<int>("ProductID") into grp select new { ProductID = grp.Key, AverageRating = grp.Average(x => x.Field<double>("Rating")) };
            foreach (var item in records)
            {
                Console.WriteLine("ProductID: " + item.ProductID);
                Console.WriteLine("Average Rating: " + item.AverageRating);
                Console.WriteLine("--------------");
            }
        }
        public void OrderByRating()
        {
            var records = dataTable.Select("UserID = 10").OrderBy(r => r["Rating"]);
            Console.WriteLine("\n-------Order By Rating------");
            foreach (DataRow row in records)
            {
                Console.WriteLine("ProductID: " + row["ProductID"]);
                Console.WriteLine("UserID: " + row["UserID"]);
                Console.WriteLine("Rating: " + row["Rating"]);
                Console.WriteLine("Review: " + row["Review"]);
                Console.WriteLine("IsLike: " + row["IsLike"]);
                Console.WriteLine("--------------");
            }
        }
    }
}
