namespace B2022.Q03
{
    public class Pixel
    {

        private int red;

        public int GetRed()
        {
            return this.red;
        }
        public void SetRed(int red)
        {
            this.red = red;
        }

        private int green;

        public int GetGreen()
        {
            return this.green;
        }
        public void SetGreen(int green)
        {
            this.green = green;
        }

        private int blue;

        public int GetBlue()
        {
            return this.blue;
        }
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public bool IsRed()
        {
            return this.red>=1 && this.red<= 255 && this.green == 0 && this.blue == 0;
        }

    }
}