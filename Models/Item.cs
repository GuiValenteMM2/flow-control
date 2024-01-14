using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace flow_control.Models
{
    public class Item(string name, DateTime registered)
    {
        private string _name = name[0].ToString().ToUpper() + name[1..];
        
        private readonly DateTime _registerDate = registered;

        public string Name
        {

            get => _name;

            set
            {
                string toUpper = value[0].ToString().ToUpper() + value[1..];
                _name = toUpper;
            }
        }

        public DateTime RegisterDate
        {
            get => _registerDate;
        }

        public string? About { get; set; }

    }
}