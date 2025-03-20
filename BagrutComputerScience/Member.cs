namespace B2024
{
    public class Member
    {

        private string name;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        private bool isCoal;

        public bool GetIsCoal()
        {
            return this.isCoal;
        }
        public void SetIsCoal(bool isCoal)
        {
            this.isCoal = isCoal;
        }

    }
}