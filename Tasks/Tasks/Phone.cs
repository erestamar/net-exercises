namespace Tasks
{
    public class Phone
    {
        //private Color color;
        //private int price;
        //private string? manufacturer;

        //public Phone(Color color, int price, string? manufacturer)
        //{
        //    this.color = color;
        //    this.price = price;
        //    this.manufacturer = manufacturer;
        //}

        public Color Color { get; init; } = Color.Black;

        public int Price { get; set; }

        //private int _price;
        //public int Price
        //{
        //    get
        //    {
        //        return _price;
        //    }
        //    set
        //    {
        //        _price = value;

        //        if (value < 1000)
        //        {
        //            IsKytay = "Китайская версия";
        //        }
        //        else
        //        {
        //            IsKytay = "Вероятней всего оригинал";
        //        }
        //    }
        //}

        public string? Manufacturer { get; set; }

        public string Company { get; } = "iPhone";

        public string IsKytay
        {
            //get
            //{
            //    //if (Price < 1000)
            //    //{
            //    //    return "Китайская версия";
            //    //}
            //    //else
            //    //{
            //    //    return "Вероятней всего оригинал";
            //    //}

            //    return Price < 1000 ? "Китайская версия" : "Вероятней всего оригинал";
            //}

            get => Price < 1000 ? "Китайская версия" : "Вероятней всего оригинал";
        }

        public string GetInfo()
        {
            return $"{Color} {Price} {Manufacturer}";
        }

        public string HowMuchPrice()
        {
            if (Price < 1000)
            {
                return "Китайская версия";
            }
            else
            {
                return "Вероятней всего оригинал";
            }
        }
    }

    public enum Color
    {
        Blue, Pink, Black
    }
}
