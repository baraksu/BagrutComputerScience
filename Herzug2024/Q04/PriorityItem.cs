using System.Security.Policy;

namespace Herzug2024.Q04
{
    public class PriorityItem
    {

        public PriorityItem(int priority, int taskSize)
        {
            this.priority = priority;
            this.taskSize = taskSize;
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

        private int taskSize;

        public int GetTaskSize()
        {
            return this.taskSize;
        }
        public void SetTaskSize(int taskSize)
        {
            this.taskSize = taskSize;
        }
        public override string ToString()
        {
            return $"[{priority}:{taskSize}]";
        }

    }
}