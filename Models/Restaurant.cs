namespace Models;

public class Restaurant {
    //In a restaurant, I want to store name, city, state of a restaurant

    //This is property, a type member
    //Access modifier controls the visibility of type and type members.
    //There are four access modifiers: Public, Private, Internal, Protected
    //public is the most visible, private is the least visible
    //By default, class member has private access modifier
    //Class, by default, are internal unless you explicitely say otherwise

    public Restaurant()
    {
        this.Reviews = new List<Review>();
    }
    public Restaurant(string name)
    {
        this.Reviews = new List<Review>();
        this.Name = name;
    }
    public string Name { get; set; }


    public string City { get; set; }
    public string State { get; set; }
    public List<Review> Reviews { get; set; }
}