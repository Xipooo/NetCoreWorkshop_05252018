namespace NetCoreWorkshop_05252018
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string getFullName(){
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}