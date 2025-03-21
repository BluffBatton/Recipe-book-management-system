using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace NET_Course
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] items;

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
            }
        }
        public int Capacity
        {
            get => items.Length;
            set
            {
                if (value < Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                if (value != items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (Count > 0)
                        {
                            Array.Copy(items, newItems, Count);
                        }
                        items = newItems;
                    }
                    else
                    {
                        items = emptyArray;
                    }
                }
            }
        }
        private static readonly T[] emptyArray = new T[0];

        public CustomList()
        {
            items = emptyArray;
        }
        public CustomList(int Capacity)
        {
            items = new T[Capacity];
        }
        public CustomList(T[] array)
        {
            count = array.Length;
            Capacity = count == 0 ? 4 : count * 2;
            items = new T[Capacity];
            Array.Copy(array, items, count);
        }
        public void Add(T item)
        {
            if (Count == items.Length)
            {
                int newCapacity = items.Length == 0 ? 4 : items.Length * 2;
                T[] newItems = new T[newCapacity];
                Array.Copy(items, newItems, Count);
                items = newItems;
            }
            items[Count++] = item;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            Count--;
            if (index < Count)
            {
                Array.Copy(items, index + 1, items, index, Count - index);
            }
            if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            {
                items[Count] = default!;
            };
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private int IndexOf(T item)
        {
            return Array.IndexOf(items, item, 0, Count);
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Length)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < items.Length)
                {
                    items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
