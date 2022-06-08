using System;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List : IList
    {

        private readonly bool _readOnly;
        private int _size;
        private object[] _elements;

        public List(bool readOnly)
        {
            _readOnly = readOnly;
            _size = 0;
            _elements = new object[_size];
        }

        public void Add(object element)
        {
            if (_readOnly) return;
            if (ListElementsIsSmallerThanList())
            {
                _elements = AddTenElements();
            }

            _elements[_size++] = element;
        }

        private object[] AddTenElements()
        {
            object[] newElements = new object[_elements.Length + 10];

            for (int i = 0; i < _size; i++)
                newElements[i] = _elements[i];
            return newElements;
        }

        private bool ListElementsIsSmallerThanList()
        {
            return _size + 1 > _elements.Length;
        }

        public object[] Elements()
        {
            return _elements;
        }

    }

}