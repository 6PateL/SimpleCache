using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cache
{
    public class Cache
    {
        private object[] _objects;
        private int _size;
        public int Count { get; set; } = 0;
        
        public Cache(int size)
        {
            _objects = new object[size];    
            _size = size;   
        }

        public void SetData(int index, object data)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException(); 
            }
            _objects[index] = data;
            Count++; 
        }

        public object GetData(int index)
        {
            if(index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException(); 
            }
            return _objects[index]; 
        }
    }
}
