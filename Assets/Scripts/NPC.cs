using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class NPC
    {
        public string playname { get; set; }
        public string TextName { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        
        public List<Item> items { get; set; }
    }

