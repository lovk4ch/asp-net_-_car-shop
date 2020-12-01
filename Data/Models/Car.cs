namespace asp_net___car_shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool isAvailable { get; set; }
        public int categoryID { get; set; }
        public virtual Category category { get; set; }
    }
}