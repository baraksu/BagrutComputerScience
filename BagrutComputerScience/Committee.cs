namespace B2024
{
    public class Committee
    {
        public readonly int maxMembers = 16;

        public Committee(string name, Member[] members, int count)
        {
            this.name = name;
            this.members = members;
            this.count = count;

        }
        public Committee()
        {
            
        }
        private string name;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
            
        }

        private Member[] members;

        public Member[] GetMembers()
        {
            return this.members;
        }
        public void SetMembers(Member[] members)
        {
            this.members = members;
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
        public int Total (bool belong)
        {
            int count = 0;

            for (int i = 0; i < this.count; i++)
            {
                if (this.members[i].GetIsCoal() == belong)
                {
                    count++;
                }
            }
            return count;
        }

    }
}