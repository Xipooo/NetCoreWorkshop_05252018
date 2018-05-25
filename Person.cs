namespace NetCoreWorkshop_05252018
{
    public class Person
    {
        private int? _id;
        public int Id
        {
            get
            {
                return _id ?? 0;
            }
            set
            {
                _id = value;
            }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName ?? "Unknown"; }
            set { _firstName = value; }
        }
        private string _middleName;
        public string MiddleName
        {
            get { return _middleName ?? "Unknown"; }
            set { _middleName = value; }
        }

        private string _lastName;
        public string LastName { 
            get { return _lastName ?? "Unknown"; } 
            set { _lastName = value; }
            }
        public string getInfo()
        {
            return $"Id: {Id}  First Name: {FirstName}  Middle Name: {MiddleName}  Last Name: {LastName}";
        }
    }
}