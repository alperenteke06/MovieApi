namespace MovieApi.Domain.Entites
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewUserRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public bool ReviewStatus { get; set; }
    }
}
