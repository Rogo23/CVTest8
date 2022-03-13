using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace CVTest8.Model
{
    public class LVGroup : ObservableCollection<Product>
    {
        public string Name { get; private set; }

        public LVGroup (string name) : base()
        {
            Name = name;
        }

        public LVGroup(string name, IEnumerable<Product> source) : base(source)
        {
            Name = name;
        }
    }
}
