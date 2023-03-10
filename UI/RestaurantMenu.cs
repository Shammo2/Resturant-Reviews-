namespace UI;

public class RestaurantMenu
{
    private RRBL _bl;

    public RestaurantMenu() 
    {
        _bl = new RRBL();
    }
    public void Start()
    {
        bool exit = false;
        while(!exit)
        {
            Console.WriteLine("This is Restaurant Menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Create a new restaurant");
            Console.WriteLine("[2] View All Restaurants");
            Console.WriteLine("[x] Go Back to Main Menu");

            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.WriteLine("Create a new restaurant:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("City: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("State: ");
                    string state = Console.ReadLine();

                    Restaurant newRestaurant = new Restaurant {
                        Name = name,
                        City = city,
                        State = state
                    };

                    _bl.AddRestaurant(newRestaurant);
                break;

                case "2":
                    List<Restaurant> allRestaurants = _bl.GetAllRestaurants();
                    
                    //there is no restaurants stored anywhere
                    if(allRestaurants.Count == 0)
                    {
                        Console.WriteLine("No restaurants found :/");
                    }
                    else
                    {
                        Console.WriteLine("Here are all your restaurants!");
                        foreach(Restaurant resto in allRestaurants)
                        {
                            Console.WriteLine($"Name: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
                            if(resto.Reviews != null && resto.Reviews.Count > 0)
                            {
                                Console.WriteLine("======Reviews======");
                                foreach(Review review in resto.Reviews)
                                {
                                    Console.WriteLine($"Rating: {review.Rating} \t Note: {review.Note}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Reviews :'(");
                            }
                        }
                    }
                break;

                case "x":
                    exit = true;
                break;
                default:
                    Console.WriteLine("I'm not sure what that was");
                break;
            }       

        }
    }
}