using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

public class DecisionMaker {

public static void Main(string[] args) {

    
        List<Item> list = new Item().allItems();
Console.WriteLine("list of items is {0}", list[0]);
        Cart cart = new CartBuilder().listOfItems(list).byTotalAmount(list).build();
        Console.WriteLine(cart);
    }
}
}
