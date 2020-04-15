using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

public class ItemDataCreator {

    public List<Item> createItems() {


        Item apple = new ItemBuilder().price(100).quantity(2).build();
        Item newspaper = new ItemBuilder().price(1).quantity(2).build();
        Item milk = new ItemBuilder().price(20).quantity(1).build();

        Console.WriteLine("apple item created . {0}", apple);
        Console.WriteLine("newspaper item created . {0}", newspaper);
        Console.WriteLine("milk item created . {0}", milk);

        List<Item> list = new List<Item>();

        list.Add(apple);
        list.Add(newspaper);
        list.Add(milk);

        return list;
    }
}}