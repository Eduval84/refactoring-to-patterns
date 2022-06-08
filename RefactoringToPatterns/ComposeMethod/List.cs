using System;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List : IList
    {

        private readonly bool _readOnly;
        private readonly ListElements _listElements;

        public List(bool readOnly, object[] elements)
        {
            _readOnly = readOnly;
            _listElements = new ListElements(0, elements, this);
        }

        public void Add(object element)
        {
            _listElements.Add(element);
        }

        public object[] Elements()
        {
            return _listElements.Elements;
        }

        public bool IsReadOnly() { return _readOnly; }

    }

}