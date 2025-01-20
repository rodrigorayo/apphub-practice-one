namespace AppHub.Domain.Responses
{
    public class Pager
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public Pager(int pageNumber, int pageSize, int totalItems)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItems = totalItems;
        }
    }
}
