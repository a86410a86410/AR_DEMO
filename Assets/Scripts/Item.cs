using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Item
    {
    public int itemID { get; set; }
    public int qty { get; set; }

    public Item(int id,int qty)
    {
        this.itemID = id;
        this.qty = qty;
    }
    }

