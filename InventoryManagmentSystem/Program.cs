namespace InventoryManagmentSystem
{
    internal class Program
    {
        const int numberOfProducts = 50;
        static  string[,] inventory = new string[numberOfProducts, 3];
        static int productId = 0;

        static void Main(string[] args)
        {
          


            // add product
            // update product
            // view product (id - name - quantity - price )
            // exit

            while(true)
            {
                Console.WriteLine("Welcome to our Inventory System");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. View Product");
                Console.WriteLine("4. Exit ");

                string userInput = Console.ReadLine();
                int userChoise = Convert.ToInt32(userInput);


                switch (userChoise)
                {
                    case 1:
                        // add product logic
                        AddProduct();
                        break;
                    case 2:
                        // update product logic
                        UpdateProduct();
                        break;
                    case 3:
                        // view product logic
                        ViewProduct();
                        break;
                    case 4:
                        // Exit logic
                        Environment.Exit(0);
                        break;
                }
            }
          

        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter product name");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter product quantity");
            string productquantity = Console.ReadLine();

            Console.WriteLine("Enter product Price");
            string productPrice = Console.ReadLine();
            inventory[productId, 0] = productName;
            inventory[productId, 1] = productquantity;
            inventory[productId, 2] = productPrice;

            productId++;
            Console.WriteLine("Product added successfully");
        }

        private static void ViewProduct()
        {
            if(productId>0)
            {
                Console.WriteLine("Product list:");
                for(int i = 0; i<productId;i++)
                {
                    Console.WriteLine($"Product ID : {i}, Product Name : {inventory[i, 0]}, Product Quantity : {inventory[i,1]} : Product Price : {inventory[i,2]}");
                }
            }
        }


        private static void UpdateProduct()
        {
            Console.WriteLine("Enter Product name to update ");
            string name = Console.ReadLine();

            int productNum = -1;
            if(productId > 0)
            {
                for(int i =0; i<productId; i++)
                {
                    if (inventory[i,0] ==  name)
                    {
                        productNum = i;
                        break;
                    }
                }
                if(productNum != -1)
                {
                    Console.WriteLine("Enter the new quantity");
                    var newQuantity = Console.ReadLine();
                    inventory[productNum, 1] = newQuantity;
                    Console.WriteLine("Quantity updated successfully");
                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }
        }

    }
}
