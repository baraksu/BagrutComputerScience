namespace B2021a.Q02
{
    public class ReportCard
    {

        private string stuName;

        public string GetStuName()
        {
            return this.stuName;
        }
        public void SetStuName(string stuName)
        {
            this.stuName = stuName;
        }

        private Subject[] subArray;

        public Subject[] GetSubArray()
        {
            return this.subArray;
        }
        public void SetSubArray(Subject[] subArray)
        {
            this.subArray = subArray;
        }

        public ReportCard(string name, int num)
        {
            this.stuName = name;
            this.subArray = new Subject[num];

        }
        public double Agerage()
        {
            double sum = 0;
            for (int i = 0; i < this.subArray.Length; i++)
            {
                sum += this.subArray[i].GetGrade();
            }
            return sum / this.subArray.Length;
        }
        // לכל וקיים
        public bool IsExcellent()
        {
            if (Agerage() < 85)
                return false;

            bool has100 = false;
            
            for (int i = 0; i < this.subArray.Length; i++)
            {
                if (this.subArray[i].GetGrade() < 55)
                {
                    return false;
                }
                if (this.subArray[i].GetGrade() == 100)
                {
                    has100 = true;
                }
            }
            return  has100;
        }

    }
}