namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Product Review Management\n");
            bool flag = true;
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductId =  1,UserId = 1, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId =  2,UserId = 1, Rating = 4, Review = "Nice", IsLike = true},
                new ProductReview() {ProductId =  3,UserId = 3, Rating = 3.5, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  4,UserId = 6, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId =  5,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  6,UserId = 3, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId =  7,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  8,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId =  9,UserId = 1, Rating = 1, Review = "Verybad", IsLike = false},
                new ProductReview() {ProductId = 10,UserId = 5, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 11,UserId = 5, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 12,UserId = 1, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 13,UserId = 2, Rating = 4, Review = "Nice", IsLike = true},
                new ProductReview() {ProductId = 14,UserId = 4, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 15,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 16,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 17,UserId = 3, Rating = 2.5, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 18,UserId = 3, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 19,UserId = 6, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 20,UserId = 6, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 21,UserId = 4, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 22,UserId = 3, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 22,UserId = 2, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 22,UserId = 5, Rating = 4, Review = "Nice", IsLike = true},
                new ProductReview() {ProductId = 23,UserId = 2, Rating = 4.5, Review = "VeryGood", IsLike = true},
            };
            Manegment manegment = new Manegment();
            DataBaseOperation dataBaseOperation = new DataBaseOperation();
            while (flag)
            {
                Console.WriteLine("Choose a Option");
                Console.WriteLine("1.View All Row");
                Console.WriteLine("2.Retrive top 3 records");
                Console.WriteLine("3.retrive top reating reacords");
                Console.WriteLine("4.Count of Product Id");
                Console.WriteLine("5.Retrivr Only product Id And Review");
                Console.WriteLine("6.Skip Top Five Records");
                Console.WriteLine("7.Retrive Product Id and Review");
                Console.WriteLine("8.Create dataTable");
                Console.WriteLine("9.Retrive IsLike Data Freom DataTable");
                Console.WriteLine("10.Retrive Avrage Rating with ProductId");
                Console.WriteLine("11.Retrive Record where review contain nice");
                Console.WriteLine("12.Retrive record which user id is 10 in Datatable");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-------Product Review-------\n");
                        foreach (var item in productReviews)
                        {
                            Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
                        }
                        break;
                    case 2:
                        manegment.TopRecord(productReviews);
                        break;
                    case 3:
                        manegment.CollectRecords(productReviews);
                        break;
                    case 4:
                        manegment.CountProductID(productReviews);
                        break;
                    case 5:
                        manegment.ProductIdAndReview(productReviews);
                        break;
                    case 6:
                        manegment.SkipTop5Record(productReviews);
                        break;
                    case 7:
                        manegment.ProductIdReview(productReviews);
                        break;
                    case 8:
                        dataBaseOperation.CreateDataTable();
                        break;
                    case 9:
                        dataBaseOperation.CreateDataTable();
                        dataBaseOperation.RetrieveIsLikeValueWithTrue();
                        break;
                    case 10:
                        dataBaseOperation.CreateDataTable();
                        dataBaseOperation.AvgRatingOfProductId();
                        break;
                    case 11:
                        manegment.RetrieveReviewMessage(productReviews);
                        break;
                    case 12:
                        dataBaseOperation.CreateDataTable();
                        dataBaseOperation.OrderByRating();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            
            
        }
    }
}