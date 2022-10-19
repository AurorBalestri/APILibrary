namespace LibraryAPI.Models
{
    public class Customer
    {
        public static int autoIncrementId = 1;
        private int _customerId;
        private string _fullName;
        private string _address;
        private int _phoneNumber;

        public int CustomerId { get { return _customerId; } set { _customerId = autoIncrementId++; } }
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }

        public Customer()
        {

        }
        public Customer(int customerid, string fullname, string address, int phonenumber)
        {
            _customerId = customerid;
            _fullName = fullname;
            _address = address;
            _phoneNumber = phonenumber;
        }
    }
}
