namespace core_api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Item(int id, string name, int rating, string description)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Description = description;
        }
    }
}