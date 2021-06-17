using System;
namespace BakeryCart131.Models
{
    public class CakeReview
    {
        public CakeReview()
        {
        }

        public int CakeReviewId  { get; set; }

        public string Review { get; set; }

        public int CakeId { get; set; }
    }
}
