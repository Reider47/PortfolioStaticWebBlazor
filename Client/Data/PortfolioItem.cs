namespace BlazorBasic.Data
{
    public class PortfolioItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public string imgPath { get; set; }

        public string link { get; set; }
        public PortfolioItem(string name, string description) 
        {
            this.name = name;
            this.description = description;
            imgPath = "dc_icon2.svg";
        }
        public PortfolioItem(string name, string description, string link)
        {
            this.name = name;
            this.description = description;
            this.imgPath = "dc_icon2.svg";
            this.link = link;
        }
        public PortfolioItem(string name, string description, string imgPath, string link)
        {
            this.name = name;
            this.description = description;
            this.imgPath = imgPath;
            this.link = link;
        }
    }
}
