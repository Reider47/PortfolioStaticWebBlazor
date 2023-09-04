namespace BlazorBasic.Data
{
    public class PortfolioItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public string imgLink { get; set; }

        public PortfolioItem(string name, string description) 
        {
            this.name = name;
            this.description = description;
            imgLink = "dc_icon2.svg";
        }
        public PortfolioItem(string name, string description, string imgLink)
        {
            this.name = name;
            this.description = description;
            this.imgLink = imgLink;
        }
    }
}
