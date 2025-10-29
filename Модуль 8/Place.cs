namespace InteractiveMap
{
    public class Place : MainWindow
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string Color { get; set; } = "Red";
        public string ImagePath { get; set; }
    }
}
