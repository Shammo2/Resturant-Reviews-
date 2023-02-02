namespace Models;

public class Review {


    public Review() { }

    public Review(int rating)
    {
        this.Rating = rating;
    }

    public Review(int rating, string note)
    {
        this.Rating = rating;
        this.Note = note;
    }

    public int Rating { get; set; }
    public string Note { get; set; }
}