using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

public class Cart {

    List<Item> items = new List<Item>();
    int totalAmount;

     public List<Item> getItems() {
        return items;
    }

    public int getTotalAmount() {
        return totalAmount;
    }

     public void listOfItems(List<Item> items){
        this.items = items;
    }
    

  
    public override string ToString() {
        return "Cart{" +
                "items=" + items +
                ", totalAmount=" + totalAmount +
                '}';
    }
}

}