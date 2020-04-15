using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

public class ItemBuilder {

    
    Item item = new Item();


    public ItemBuilder quantity(int quantity) {
item.SetQuantity(quantity);
        return this;
    }

    public ItemBuilder price(int price) {
      item.Price = price;
      return this;
    }


    public Item build() {
        return item;
    }
}
}