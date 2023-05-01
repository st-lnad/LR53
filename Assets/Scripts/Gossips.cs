using UnityEngine;

public class Gossips
{
    public struct OrderNeeds
    {
        public Village village;
        public int product;
        public int value;
    }
    public static string[,] up_gossips_flavor = new string[4, 3];
    public static string[,] down_gossips_flavor = new string[4, 3];
    public static int[] cost = new int[6];
    public static string GossipMessage;
    public static string OrderMessage;
    static Gossips()
    {
        up_gossips_flavor[0, 0] = "The barkeep tells you about a recent drunkard living in ";
        up_gossips_flavor[0, 1] = " complaining of having spent all his life acquiring ";
        up_gossips_flavor[0, 2] = "and now his wife is selling his large collection for dirt cheap. \"Poor guy, says she said it's either her or his precious collection!\" he chuckles.";

        up_gossips_flavor[1, 0] = "The barkeep says a recent customer of his kept mentioning his younger brother's new venture in ";
        up_gossips_flavor[1, 1] = ".\n\"The boy knows nothing about the ";
        up_gossips_flavor[1, 2] = " he makes - nobody needs that many even if you gave it away for free\" he retells.";

        up_gossips_flavor[2, 0] = "Your informer meets you in a dark alley to advise going to ";
        up_gossips_flavor[2, 1] = " where the locals recently started obsessively making ";
        up_gossips_flavor[2, 2] = ". The prices have not yet caught up to the new hobby sweeping the location, he says.";

        up_gossips_flavor[3, 0] = "The informer just returned from ";
        up_gossips_flavor[3, 1] = " with great news: a local tradition calls for every pregnant woman to make as many ";
        up_gossips_flavor[3, 2] = " as possible before she gives birth. Currently there are several husbands who are soon to be dads eager to get rid of excess items, no matter the price.";

        down_gossips_flavor[0, 0] = "The barkeep mentions his mother living in ";
        down_gossips_flavor[0, 1] = " had to move because they didn't have enough ";
        down_gossips_flavor[0, 2] = ".\n\"I reckon they will pay any price for it there\" he says.";

        down_gossips_flavor[1, 0] = " The barkeep notes that it is became very popular in ";
        down_gossips_flavor[1, 1] = " to have huge numbers of ";
        down_gossips_flavor[1, 2] = ". \"The Queen was seen with it by the locals recently and the local sellers struggle to keep up with the crazy high demand\" he shrugs.";

        down_gossips_flavor[2, 0] = "You discreetly hand your informer a sack of gold and he tells you that ";
        down_gossips_flavor[2, 1] = " is about to be visited by a royal looking for ";
        down_gossips_flavor[2, 2] = ".They don't have any at the moment but he's been looking for a long time and is getting desperate.";

        down_gossips_flavor[3, 0] = "The note from your informer arrives by his carrier pigeon saying that ";
        down_gossips_flavor[3, 1] = " has been having a shortage of ";
        down_gossips_flavor[3, 2] = " recently due to a newly-popular way of curing the plague. The details are fuzzy but the locals are obsessed with their health and will pay through the nose.";

        cost[0] = 100;
        cost[1] = 250;
        cost[2] = 500;
        cost[3] = 1000;
    }
    public static string CreateGossip(int value)
    {
        int product = Random.Range(0, 7);
        GameObject village = MainThings.villages[Random.Range(0, MainThings.villages.Length)];
        if (Random.Range(0, 2) > 0)
        {
            GossipMessage = down_gossips_flavor[value, 0] + village.GetComponent<Village>().village_name + down_gossips_flavor[value, 1] + MainThings.stock_name[product] + down_gossips_flavor[value, 2];
            village.GetComponent<Village>().Inventory[product] -= cost[value];
            village.GetComponent<Village>().Inventory[product] = Mathf.Max(village.GetComponent<Village>().Inventory[product], 0);
        }
        else
        {
            GossipMessage = up_gossips_flavor[value, 0] + village.GetComponent<Village>().village_name + up_gossips_flavor[value, 1] + MainThings.stock_name[product] + up_gossips_flavor[value, 2];
            village.GetComponent<Village>().Inventory[product] += cost[value];
            village.GetComponent<Village>().Inventory[product] = Mathf.Min(village.GetComponent<Village>().Inventory[product], village.GetComponent<Village>().Capacity[product]);
        }
        return GossipMessage;
    }

    public static void CreateOrder(OrderNeeds order)
    {
        int product = order.product;
        int amount = 100 * cost[order.value] / MainThings.BasicCost[product];
        OrderMessage = "На доске объявлений висит заказ: \"Требуется " + MainThings.stock_name[product] + " в количестве " + amount + "шт. Доставить в город " + order.village.name + ". Награда - " + 100 * cost[order.value] * 3 / 2 + " денег.";
    }
}
