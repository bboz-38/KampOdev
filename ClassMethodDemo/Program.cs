using ClassMethodDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.Id = 1;
        customer.FirstName = "Burhan";
        customer.LastName = "Boz";

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer);
        customerManager.List(customer);
        customerManager.Delete(customer);
    }
}