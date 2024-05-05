using System.Collections.Generic;

namespace NewTalentsDioBootcamp
{
    public class LimitedStack<T> : Stack<T>
    {
        private int limit;

        public LimitedStack(int limit)
        {
            this.limit = limit;
        }

        public new void Push(T item)
        {
            while (this.Count >= this.limit)
            {
                this.RemoveOldest();
            }

            base.Push(item);
        }

        private void RemoveOldest()
        {
            if (this.Count <= 0) return;
            var temp = new Stack<T>(this.Count - 1);
            while (this.Count > 1)
            {
                temp.Push(this.Pop());
            }
            this.Pop(); // Remove o elemento mais antigo
            while (temp.Count > 0)
            {
                this.Push(temp.Pop());
            }
        }
    }
}