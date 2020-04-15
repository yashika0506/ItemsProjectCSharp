using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

public class CartBuilder {

   // List<Item> items = new List<Item>();
    int totalAmount;
    Cart cart = new Cart();



    public CartBuilder byTotalAmount(List<Item> items){
       totalAmount =0;
        foreach(Item a in items) {
            totalAmount = totalAmount + a.getQuantity()*a.Price;
        }
        this.totalAmount = totalAmount;
        Console.WriteLine("total amount is {0}", this.totalAmount);
        return  this;
    }

    public CartBuilder listOfItems(List<Item> items){
        cart.listOfItems(items);
        return this;
    }

    public Cart build() {
         return cart;
    }


}}

