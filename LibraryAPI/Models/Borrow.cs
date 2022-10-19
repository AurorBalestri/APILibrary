namespace LibraryAPI.Models
{
    public class Borrow
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _customerId;
        private int _bookId;

        public DateTime StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime EndDate { get { return _endDate; } set { _endDate = value; } }
        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public int BookId { get { return _bookId; } set { _bookId = value; } }

        public Borrow()
        {

        }

        public Borrow(DateTime startdate, DateTime enddate, int customerid, int bookid)
        {
            _startDate = startdate;
            _endDate = enddate;
            _customerId = customerid;
            _bookId = bookid;
        }
    }
}
