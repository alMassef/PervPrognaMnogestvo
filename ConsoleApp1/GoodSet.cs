using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GoodSet<T> : IEnumerable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public GoodSet() { }

        public GoodSet(T item)
        {
            items.Add(item);
        }

        public GoodSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }

            items.Add(item);
        }

        public void Remowe(T item)
        {
            items.Remove(item);
        }

        public GoodSet<T> Union(GoodSet<T> set)
        {
            return new GoodSet<T>(items.Union(set.items));
            //GoodSet<T> result = new GoodSet<T>();
            //foreach (var item in items)
            //{
            //    result.Add(item);
            //}

            //foreach(var item in set.items)
            //{
            //    result.Add(item);
            //}
            //return result;
        }

        public GoodSet<T> Intersection(GoodSet<T> set)
        {
            return new GoodSet<T>(items.Intersect(set.items));
        }

        public GoodSet<T> Difference(GoodSet<T> set)
        {
            return new GoodSet<T>(items.Except(set.items));
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
