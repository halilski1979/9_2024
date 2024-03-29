using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opashka
{
    public class CircleQue<T>
    {
        private const int DefaultCapacity = 4;
        public int Count { get; private set; }

        private T[] elements;

        int startIndex = 0;
        int endIndex = 0;
       
        public CircleQue()
        {
            this.elements= new T[DefaultCapacity];
        }
        private void CopyElementsTo(T[] array)
        {
            int sourceIndex= startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                array[destinationIndex] = this.elements[sourceIndex];
                sourceIndex=(sourceIndex+1)%this.elements.Length;
                destinationIndex++;
            }
        }
        public void Grow()
        {
            T[]copy= new T[elements.Length*2];
            this.CopyElementsTo(copy);
            this.elements= copy;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }
        public void Enqueue(T element)
        {
            if (this.Count>=elements.Length)
            {
                Grow();
            }
            this.elements[endIndex] = element;
            this.endIndex=(this.endIndex+1)%this.elements.Length;
            this.Count++;  
        }
    }
}
