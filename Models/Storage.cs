using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace flow_control.Models
{
    public class Storage
    {

        public Storage(string name)
        {
            Name = name;
        }

        public string Name { get; set;}

        private readonly List<object> _storedItems = [];

        public List<object> StoredItems
        {
            get
            {
                return _storedItems;
            }
        }

        public void AddItem(object value)
        {
            _storedItems.Add(value);
        }

        public void RemoveItem(object value)
        {
            _storedItems.Remove(value);
        }

        public void ShowItems()
        {
            for (int i = 0; i < _storedItems.Count; i++)
            {
                Console.WriteLine(_storedItems[i]);
            }
        }

    }
}