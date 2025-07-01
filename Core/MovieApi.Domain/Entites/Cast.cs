namespace MovieApi.Domain.Entites
{
    public class Cast
    {
        public int CastId { get; set; }
        public string CastTitle { get; set; }
        public string CastName { get; set; }
        public string CastSurname { get; set; }
        public string CastImageUrl { get; set; }
        public string? CastOverview { get; set; }
        public string? CastBiography { get; set; }
    }
}
