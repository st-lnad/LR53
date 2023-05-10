using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThings
{
    public static GameObject[] villages;
    public static int[] BasicCost = new int[7];
    public static string[] stock_name = new string[7];
    public static int[] weight = new int[7];
    public static int[,] WorkingNeeds = new int[7, 7];
    static MainThings()
    {

        for (int i = 0; i < 7; i++) 
        {
            for (int j = 1; j < 7; j++) 
            {
                WorkingNeeds[i, j] = 0;
            }
            WorkingNeeds[i, 0] = 1;
            WorkingNeeds[i, 5] = 1;
        }
        WorkingNeeds[0, 5] = 0;
        WorkingNeeds[5, 0] = 0;
        WorkingNeeds[4, 2] = 1;
        WorkingNeeds[4, 3] = 1;
        WorkingNeeds[6, 1] = 1;
        WorkingNeeds[6, 4] = 1;



        villages = GameObject.FindGameObjectsWithTag("Place");
        BasicCost[0] = 100; //хлеб
        BasicCost[1] = 200; //Дерево
        BasicCost[2] = 200; //Уголь
        BasicCost[3] = 200; //Железо
        BasicCost[4] = 500; //Сталь
        BasicCost[5] = 800; //Инструменты
        BasicCost[6] = 2000; //Мебель
        stock_name[0] = "Food";
        stock_name[1] = "Wood";
        stock_name[2] = "Coal";
        stock_name[3] = "Iron";
        stock_name[4] = "Steel";
        stock_name[5] = "Tools";
        stock_name[6] = "Furniture";
        weight[0] = 1;
        weight[1] = 5;
        weight[2] = 5;
        weight[3] = 5;
        weight[4] = 5;
        weight[5] = 5;
        weight[6] = 5;
    }
    public static int getBuyPrice(int slot, int amount, Village Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot] - 2*Seller.Inventory[slot] + i)/Seller.Capacity[slot];
            price += (int)(((Mathf.Pow(Seller.price_modifier,AmountDependency)  + 0.1) * MainThings.BasicCost[slot]));
        }
        return price;
    }
   public static int getSellPrice(int slot, int amount, Village Seller)
    {
        int price = 0;
        float AmountDependency;
        for (int i = 0; i < amount; i++)
        {
            AmountDependency = (float)(Seller.Capacity[slot] - 2 * Seller.Inventory[slot] - i) / Seller.Capacity[slot];
            price += (int)(((Mathf.Pow(Seller.price_modifier, AmountDependency) - 0.1) * MainThings.BasicCost[slot]));
        }
        return price;
    }

    public static void LifeGoesOn()
    {
    
        foreach (GameObject Vill in MainThings.villages)
        {
            Village village = Vill.GetComponent<Village>();
            //Создание заказа для каждой деревни
            village.Order.product = Random.Range(0, 7);
            village.Order.value = Random.Range(0, 3);
            village.Order.village = MainThings.villages[Random.Range(0, MainThings.villages.Length)].GetComponent<Village>();

            //Изменение людей в зависимости от еды
            float difference = (float) (2 * village.Inventory[0] - village.Capacity[0]) / village.Capacity[0];
            village.population = (int) (village.population * Mathf.Pow(2.0f, difference));
            
            village.population = Mathf.Min(village.population, village.MaxPopulation);

            //Едение
            village.Inventory[0] -= village.population / 10;
            village.Inventory[0] += village.MaxPopulation / 20 ;

            //Изменение ресурсов в день
            for (int i = 0; i < 7; i++)
            {
                if (village.IsHere[i])
                {
                   // village.Capacity[i] = village.population * 5;
                    if (village.village_type == i)
                    {
                     //   village.Capacity[i] *= 2;
                        if (village.Inventory[i] < village.Capacity[i])
                        {

                            float value = (20000 / MainThings.BasicCost[i] * village.population / 100);

                            for (int j = 0; j < 7; j++)
                            {
                                village.Inventory[j] -= WorkingNeeds[i, j] * village.population / 100;
                                if (village.Inventory[j] < 0)
                                {
                                    village.Inventory[j] = 0;
                                    value /= 2;
                                }
                            }
                            village.Inventory[i] += (int)value;
                        }
                    }
                        
                    

                    village.Inventory[i] = Mathf.Min(village.Inventory[i], village.Capacity[i]);

                }

               
            }


        }
    }




}
