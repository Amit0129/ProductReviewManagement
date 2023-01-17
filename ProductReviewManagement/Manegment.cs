﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Manegment
    {
        public void TopRecord(List<ProductReview> productReviews)
        {
            var top3Records = (from record in productReviews orderby record.Rating descending select record).Take(3);
            foreach (var item in top3Records)
            {
                Console.WriteLine($"Product Id = {item.ProductId} UserId = {item.UserId} Rating = {item.Rating} Review = {item.Review} IsLike = {item.IsLike}");
            }
        }
        public void CollectRecords(List<ProductReview> productReviews)
        {
            var records = from record in productReviews where (record.ProductId == 1 || record.ProductId == 4 || record.ProductId == 9) && record.Rating > 3 select record;
            foreach (var item in records)
            {
                Console.WriteLine($"Product Id = {item.ProductId} UserId = {item.UserId} Rating = {item.Rating} Review = {item.Review} IsLike = {item.IsLike}");
            }
        }
    }
}
