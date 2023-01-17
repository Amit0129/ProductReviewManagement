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
        public void CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            dataTable.Rows.Add(1, 2, 4, "Good", true);
            dataTable.Rows.Add(4, 3, 3.5, "Nice", true);
            dataTable.Rows.Add(3, 6, 3, "Good", true);
            dataTable.Rows.Add(1, 2, 2, "bad", false);
            dataTable.Rows.Add(1, 2, 4, "Good", true);
            dataTable.Rows.Add(3, 4, 4.5, "VeryGood", true);
            dataTable.Rows.Add(1, 3, 3, "Good", true);
            dataTable.Rows.Add(1, 2, 1, "VeryBad", false);
            dataTable.Rows.Add(2, 1, 3, "Good", true);
            dataTable.Rows.Add(8, 1, 3.5, "Nice", true);
            dataTable.Rows.Add(9, 2, 2, "bad", false);
            dataTable.Rows.Add(6, 3, 3.5, "Good", true);
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
            dataTable.Rows.Add(6, 2, 4.5, "VeryGood", true);
            dataTable.Rows.Add(9, 5, 3, "Nice", true);
            Console.WriteLine("\nData Table is Created");
        }
    }
}
