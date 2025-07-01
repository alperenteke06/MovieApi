namespace MovieApi.Domain.Entites
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieCoverImageUrl { get; set; }
        public decimal MovieRating { get; set; }
        public string MovieDescription { get; set; }
        public int MovieDuration { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string MovieCreatedYear { get; set; }
        public bool MovieStatus { get; set; }
    }
}
