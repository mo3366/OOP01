namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Create a DeliveryAddress struct 
            DeliveryAddress address1 = new DeliveryAddress("New York", "Main Street", 123);

            DeliveryAddress address2 = address1;
            address2.City = "Giza";
            address2.Street = "Pyramids Street";
            address2.BuildingNumber = 100;

            Console.WriteLine("original address:");
            Console.WriteLine(address1.GetFullAddress());

            Console.WriteLine("\nCopied Address after modification:");
            Console.WriteLine(address2.GetFullAddress());
            #endregion

        }
    }
}
