using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThings
{
    public static int[] BasicCost = new int[7];
    public static int[] weight = new int[7];
    static MainThings()
    {
        BasicCost[0] = 100; //хлеб
        BasicCost[1] = 200; //Дерево
        BasicCost[2] = 200; //Уголь
        BasicCost[3] = 200; //Железо
        BasicCost[4] = 500; //Сталь
        BasicCost[5] = 800; //Инструменты
        BasicCost[6] = 2000; //Мебель
        weight[0] = 1;
        weight[1] = 5;
        weight[2] = 5;
        weight[3] = 5;
        weight[4] = 5;
        weight[5] = 5;
        weight[6] = 5;
    }
    public static int getBuyPrice(int slot, int amount, ProtoGorod Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot]/2 - Seller.Inventory[slot]) /Seller.Capacity[slot];
            price += (int)(((Seller.price_modifier * AmountDependency + 0.1) * MainThings.BasicCost[slot]));
        }
        return price;
    }
   public static int getSellPrice(int slot, int amount, ProtoGorod Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot] / 2 - Seller.Inventory[slot]) / Seller.Capacity[slot];
            price += (int)(((Seller.price_modifier * AmountDependency - 0.1) * MainThings.BasicCost[slot]));

            

        }
        return price;
    }
}
