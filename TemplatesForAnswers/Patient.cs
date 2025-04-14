namespace B2024.Q05
{
    public class Patient
    {
        public Patient(int id, int priority)
        {
            this.id = id;
            this.priority = priority;
        }

        private int id;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }


        private int priority;

        public int GetPriority()
        {
            return this.priority;
        }
        public void SetPriority(int priority)
        {
            this.priority = priority;
        }
        public override string ToString()
        {
            return $"{id}:{priority}";
        }

    }
}