namespace ConsoleApp2
{
    class Movie
    {
        public string title;
        public string director;
        private string rating="";
        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            Rating = aRating;
        }

        //method setter and getter
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}