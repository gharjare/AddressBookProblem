namespace AddressBookPracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressbook program");
            AddressBookMain addressBook = new AddressBookMain();
            addressBook.AddContact();
        }
    }
}
