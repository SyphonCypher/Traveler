namespace TravelerTest
{
    public class Beach
    {
        //Fields
        private string eyeColor;
        private double shoeSize

        //Properties
        public string GetColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }

        public double GetShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        public Beach()
        {

        }

        public Beach(string eyeColor)
        {
            this.GetColor = eyeColor;
        }

        public string GetBeach(string eyeColor)
        {
            if (eyeColor == "green")
            {
                return "Seal Beach";
            }
            if (eyeColor == "brown")
            {
                return "Newport Beach";
            }
            if (eyeColor == "gray")
            {
                return "Huntington Beach";
            }
            return " ";
        }

        public string GetHotel(double num, string value)
        {
            if((num == 10) && (value == "Seal Beach"))
            {
                return "Hilton";
            }
            return null;
        }
        
    }
}