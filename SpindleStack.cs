using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class SpindleStack : IterableCollection
    {
        private CDNode top;
        private int size;

        public Iterator createIterator()
        {
            return new StackIterator(this);
        }

        public SpindleStack()
        {
            top = null;
            size = 0;
        }
        public int getSize
        {
            get
            {
                return size;
            }
        }
        private bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//is empty
        public void push(CDNode sn)
        {
            sn.Previous = top;
            top = sn;
            size++;
        }//push
        public CDNode pop()
        {
            if (isEmpty())
            {
                return null;
            }
            CDNode removed = top;
            top = removed.Previous;
            size--;
            return removed;
        }//pop
        public String list()
        {
            if (isEmpty())
            {
                return "Stack is empty\n";
            }
            string output = "Contents of stack\n Nodes:     " + size +
            "\n";
            CDNode current = top;
            while (current != null)
            {
                output += "Artist:   " + current.Artist + " Duration: " + current.Duration + "\n";
            current = current.Previous;
            }
            return output;
        }//list
        public CDNode peek()
        {
            return top;
        }//peek


    }
}

