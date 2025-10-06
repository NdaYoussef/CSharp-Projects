namespace ShoppineManagentSystem
{
    internal class Program
    {
        static public List<string> cartItems = new List<string>();

        static public Dictionary<string,decimal> itemPrices = new Dictionary<string,decimal>()
        {
            {"Camera" ,1500 },
            {"Laptop",3000 },
            {"TV",2500 }
        };

        static Stack<string> actions = new Stack<string>();


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping system");
            Console.WriteLine("---------------------------------");
            while (true)
            {
               
                Console.WriteLine("1, Add item to cart");
                Console.WriteLine("2, View cart items");
                Console.WriteLine("3, Remove item from cart");
                Console.WriteLine("4, Checkout ");
                Console.WriteLine("5, Undo last action");
                Console.WriteLine("6, Exit");


                Console.WriteLine("Enter your choice number");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ViewCart();
                        break;
                    case 3:
                        RemoveItem();
                        break;
                    case 4:
                        Checkout();
                        break;
                    case 5:
                        Undo();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid code entered");
                        break;

                }
            }
        }
        private static void AddItem()
        {
            Console.WriteLine("Available Items");
            foreach(var item in itemPrices)
            {
                Console.WriteLine($"Item: {item.Key}, Price: {item.Value}");

            }
            Console.WriteLine("Please enter product name");
            string cartItem = Console.ReadLine();

            if (itemPrices.ContainsKey(cartItem))
            {
                cartItems.Add(cartItem);
                actions.Push($"Item: {cartItem} added to cart");
                Console.WriteLine($"Item: {cartItem} added to ypur cart sueccfully");
            }
            else
            {
                Console.WriteLine("Item is out of stock or not available");
            }
        }

        private static void ViewCart()
        {
            Console.WriteLine("Your cart itmes :");
            if (cartItems.Any())
            {
                var itemPricesCollection = GetCartPrices();
                foreach (var item in itemPricesCollection)
                {
                    Console.WriteLine($"Item: {item.Item1} , Price:{item.Item2} ");
                }
            }
            else
            {
                Console.WriteLine("Cart is empty");
            }
        }
        private static IEnumerable<Tuple<string, decimal>> GetCartPrices()
        {
            var cartPrices = new List<Tuple<string,decimal>>();
            foreach (var item in cartItems)
            {
                decimal price = 0;
               bool foundItem = itemPrices.TryGetValue(item, out  price);
                if (foundItem)
                {
                    Tuple<string, decimal> itemPrice = new Tuple<string, decimal>(item,price);
                    cartPrices.Add(itemPrice);
                }
            }

            return cartPrices;
        }
        private static void RemoveItem()
        {
            ViewCart();
            if (cartItems.Any())
            {
                Console.WriteLine("Please select item to remove");
                string itemToRemove = Console.ReadLine();
                if (cartItems.Contains(itemToRemove))
                {
                    cartItems.Remove(itemToRemove);
                    actions.Push($"Item: {itemToRemove} added to cart");

                    Console.WriteLine($"Item: {itemToRemove} removed");
                }
                else
                {
                    Console.WriteLine("item doesn't exist in shopping cart");
                }
            }
        }
        private static void Checkout()
        {
            if(cartItems.Any())
            {
                decimal totalPrice = 0;
                Console.WriteLine("Your cartItems are:");

                var itemsInCart = GetCartPrices();
                foreach(var item in itemsInCart)
                {
                    totalPrice += item.Item2;
                    Console.WriteLine(item.Item1 + " " + item.Item2);
                }

                Console.WriteLine($"Total Price to pay: {totalPrice}");
                Console.WriteLine("Please proceed to payment, thank you for shopping with us"); 

                cartItems.Clear();
                actions.Push("Checkout");
            }
            else
            {
                Console.WriteLine("Your cart is empty!");
            }
        }
        private static void Undo()
        {
            if(actions.Count > 0)
            {
                string lastAction = actions.Pop();
                Console.WriteLine($"Your last action is:{lastAction}");
               var actionArray =  lastAction.Split();

                if(lastAction.Contains("added"))
                {
                    cartItems.Remove(actionArray[1]);
                }
                else if(lastAction.Contains("removed"))
                    {
                    cartItems.Add(actionArray[1]);
                }
                else
                {
                    Console.WriteLine("Check out can not be undo, please ask for refund");
                }
            }
        }
    }
}
