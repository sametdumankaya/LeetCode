namespace LeetCodeSolutions.Solutions
{
    class Problem225
    {
        System.Collections.Generic.Queue<int> _queue = new System.Collections.Generic.Queue<int>();

        // Push element x onto stack.
        public void Push(int x)
        {
            _queue.Enqueue(x);

            for (int i = 0; i < _queue.Count - 1; i++)
            {
                _queue.Enqueue(_queue.Peek());
                _queue.Dequeue();
            }
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            _queue.Dequeue();
        }

        // Get the top element.
        public int Top()
        {
            return _queue.Peek();
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return _queue.Count == 0;
        }
    }
}
