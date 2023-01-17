namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Product Review Management\n");

            List<ProductReview> productList = new List<ProductReview>()
            {
                new ProductReview() {ProductId =  1,UserId = 1, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId =  2,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
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
                new ProductReview() {ProductId = 13,UserId = 2, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 14,UserId = 4, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 15,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 16,UserId = 1, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 17,UserId = 3, Rating = 2.5, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 18,UserId = 3, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 19,UserId = 6, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 20,UserId = 6, Rating = 4.5, Review = "VeryGood", IsLike = true},
                new ProductReview() {ProductId = 21,UserId = 4, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 22,UserId = 3, Rating = 3, Review = "Average", IsLike = true},
                new ProductReview() {ProductId = 23,UserId = 2, Rating = 2, Review = "bad", IsLike = false},
                new ProductReview() {ProductId = 24,UserId = 5, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() {ProductId = 25,UserId = 2, Rating = 4.5, Review = "VeryGood", IsLike = true},
            };
            Console.WriteLine("-------Product Review-------\n");
            foreach (var item in productList)
            {
                Console.WriteLine($"Product ID : {item.ProductId}, " + $"User Id : {item.UserId}, " + $"Rating : {item.Rating}, " + $"Review : {item.Review}, " + $"IsLike : {item.IsLike}");
            }
        }
    }
}