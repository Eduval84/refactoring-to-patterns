namespace RefactoringToPatterns.ComposeMethod
{
    public class ListElements : IList
    {
        private readonly List _list;
        private int _size;
        public object[] Elements;

        public ListElements(int size, object[] elements, List list)
        {
            _size = size;
            Elements = elements;
            _list = list;
        }

        public void Add(object element)
        {
            if (_list.IsReadOnly()) return;
            if (ListElementsIsSmallerThanList())
            {
                Elements = AddTenElements();
            }

            Elements[_size++] = element;
        }

        private object[] AddTenElements()
        {
            var newElements = new object[Elements.Length + 10];

            for (var i = 0; i < _size; i++)
                newElements[i] = Elements[i];
            return newElements;
        }

        private bool ListElementsIsSmallerThanList()
        {
            return _size + 1 > Elements.Length;
        }
    }
}