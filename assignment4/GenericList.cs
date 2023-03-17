namespace Linklistaction
{
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = null;
            tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T data)
        {
            Node<T> n = new Node<T>(data);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = tail.Next;
            }
        }

    }
}