using System;
using System.Collections;
using System.Collections.Generic;

namespace ItemsApplication {

  public class Item {
  public  int  Price {get; set;}
     public int quantity;


    public int getQuantity() {
        return quantity;}

  
   public void SetQuantity(int quantity) {
             this.quantity = quantity;
   }


    public override string ToString() {
        return "Item{" +  "Price=" + Price +  ", quantity=" + quantity + '}';
    }

    public List<Item> allItems() {
        return new ItemDataCreator().createItems();}
}}