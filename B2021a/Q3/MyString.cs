namespace B2021a.Q3
{
    public class MyString
    {

        private string str;

        public string GetStr()
        {
            return this.str;
        }
        public void SetStr(string str)
        {
            this.str = str;
        }
        public MyString()
        {
            this.str = "";
        }
        public int CounterChar(char ch)
        {
            int counter = 0;
            for (int i = 0; i < this.str.Length; i++)
            {
                if (this.str[i] == ch)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void RemoveChar(char ch)
        {
            string newStr = "";
            for (int i = 0; i < this.str.Length; i++)
            {
                if (this.str[i] != ch)
                {
                    newStr += this.str[i];
                }
            }
            this.str = newStr;
        }
        public void AppendChar(char str)
        {
            this.str += str;
        }
        public char FirstChar()
        {
            return this.str[0];
        }
        public bool IsEmpty()
        {
            return this.str == "";
        }
    }
}