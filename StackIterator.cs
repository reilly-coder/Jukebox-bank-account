using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class StackIterator : Iterator
    {
        private SpindleStack collection;
        private int size;
        private CDNode current;

        public StackIterator(SpindleStack collection)
        {
            this.collection = collection;
            size = collection.getSize;
            current = collection.peek();
        }

        public string getNext()
        {
            CDNode oldCurrent = current;
            current = current.Previous;
            return oldCurrent.Artist;
        }

        public bool hasMore()
        {
            return current != null;
        }
    }
}
