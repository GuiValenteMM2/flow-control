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

        public List<object> StoredItems { get; set; }

        public void AddItem(object value)
        {
            StoredItems.Add(value);
        }

        public void RemoveItem(object value)
        {
            StoredItems.Remove(value);
        }

        public void ShowItems()
        {
            for (int i = 0; i < StoredItems.Count; i++)
            {
                Console.WriteLine(StoredItems[i]);
            }
        }

    }
}