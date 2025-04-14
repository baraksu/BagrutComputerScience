namespace B2023
{
    public class NumCount
    {
        public NumCount (int num, int count)
        {
            this.num = num;
            this.count = count;
        }

        private int num;

        public int GetNum()
        {
            return this.num;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }

        private int count;

        public int GetCount()
        {
            return this.count;
        }
        public void SetCount(int count)
        {
            this.count = count;
        }
        public override string ToString()
        {
            return $"[{this.num}:{this.count}]"; 
        }
    }
}