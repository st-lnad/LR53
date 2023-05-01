using UnityEngine;
using UnityEngine.UI;

public class ShopUIScript : MonoBehaviour
{
    public Text VillageMenu_text;

    public Text VillageMenu_Market_Buy_food_amount;
    public Text VillageMenu_Market_Buy_food_price;
    public InputField VillageMenu_Market_Buy_food_input;
    public Text VillageMenu_Market_Buy_food_totalprice;

    public Text VillageMenu_Market_Buy_wood_amount;
    public Text VillageMenu_Market_Buy_wood_price;
    public InputField VillageMenu_Market_Buy_wood_input;
    public Text VillageMenu_Market_Buy_wood_totalprice;

    public Text VillageMenu_Market_Buy_coal_amount;
    public Text VillageMenu_Market_Buy_coal_price;
    public InputField VillageMenu_Market_Buy_coal_input;
    public Text VillageMenu_Market_Buy_coal_totalprice;

    public Text VillageMenu_Market_Buy_iron_amount;
    public Text VillageMenu_Market_Buy_iron_price;
    public InputField VillageMenu_Market_Buy_iron_input;
    public Text VillageMenu_Market_Buy_iron_totalprice;

    public Text VillageMenu_Market_Buy_steel_amount;
    public Text VillageMenu_Market_Buy_steel_price;
    public InputField VillageMenu_Market_Buy_steel_input;
    public Text VillageMenu_Market_Buy_steel_totalprice;

    public Text VillageMenu_Market_Buy_tool_amount;
    public Text VillageMenu_Market_Buy_tool_price;
    public InputField VillageMenu_Market_Buy_tool_input;
    public Text VillageMenu_Market_Buy_tool_totalprice;

    public Text VillageMenu_Market_Buy_furniture_amount;
    public Text VillageMenu_Market_Buy_furniture_price;
    public InputField VillageMenu_Market_Buy_furniture_input;
    public Text VillageMenu_Market_Buy_furniture_totalprice;

    public Text VillageMenu_Market_Sell_food_amount_korovan;
    public Text VillageMenu_Market_Sell_food_amount_village;
    public Text VillageMenu_Market_Sell_food_price;
    public InputField VillageMenu_Market_Sell_food_input;
    public Text VillageMenu_Market_Sell_food_totalprice;

    public Text VillageMenu_Market_Sell_wood_amount_korovan;
    public Text VillageMenu_Market_Sell_wood_amount_village;
    public Text VillageMenu_Market_Sell_wood_price;
    public InputField VillageMenu_Market_Sell_wood_input;
    public Text VillageMenu_Market_Sell_wood_totalprice;

    public Text VillageMenu_Market_Sell_coal_amount_korovan;
    public Text VillageMenu_Market_Sell_coal_amount_village;
    public Text VillageMenu_Market_Sell_coal_price;
    public InputField VillageMenu_Market_Sell_coal_input;
    public Text VillageMenu_Market_Sell_coal_totalprice;

    public Text VillageMenu_Market_Sell_iron_amount_korovan;
    public Text VillageMenu_Market_Sell_iron_amount_village;
    public Text VillageMenu_Market_Sell_iron_price;
    public InputField VillageMenu_Market_Sell_iron_input;
    public Text VillageMenu_Market_Sell_iron_totalprice;

    public Text VillageMenu_Market_Sell_steel_amount_korovan;
    public Text VillageMenu_Market_Sell_steel_amount_village;
    public Text VillageMenu_Market_Sell_steel_price;
    public InputField VillageMenu_Market_Sell_steel_input;
    public Text VillageMenu_Market_Sell_steel_totalprice;

    public Text VillageMenu_Market_Sell_tool_amount_korovan;
    public Text VillageMenu_Market_Sell_tool_amount_village;
    public Text VillageMenu_Market_Sell_tool_price;
    public InputField VillageMenu_Market_Sell_tool_input;
    public Text VillageMenu_Market_Sell_tool_totalprice;

    public Text VillageMenu_Market_Sell_furniture_amount_korovan;
    public Text VillageMenu_Market_Sell_furniture_amount_village;
    public Text VillageMenu_Market_Sell_furniture_price;
    public InputField VillageMenu_Market_Sell_furniture_input;
    public Text VillageMenu_Market_Sell_furniture_totalprice;

    public GameObject korovan;

    void Update()
    {
        if (korovan.GetComponent<KorovanMovement>().is_init_allowed)
        {
            VillageMenu_Market_Buy_food_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[0].ToString();
            VillageMenu_Market_Buy_food_price.text = MainThings.getBuyPrice(0, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_food_totalprice.text = MainThings.getBuyPrice(0, int.Parse(VillageMenu_Market_Buy_food_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_wood_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[1].ToString();
            VillageMenu_Market_Buy_wood_price.text = MainThings.getBuyPrice(1, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_wood_totalprice.text = MainThings.getBuyPrice(1, int.Parse(VillageMenu_Market_Buy_wood_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_coal_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[2].ToString();
            VillageMenu_Market_Buy_coal_price.text = MainThings.getBuyPrice(2, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_coal_totalprice.text = MainThings.getBuyPrice(2, int.Parse(VillageMenu_Market_Buy_coal_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_iron_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[3].ToString();
            VillageMenu_Market_Buy_iron_price.text = MainThings.getBuyPrice(3, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_iron_totalprice.text = MainThings.getBuyPrice(3, int.Parse(VillageMenu_Market_Buy_iron_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_steel_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[4].ToString();
            VillageMenu_Market_Buy_steel_price.text = MainThings.getBuyPrice(4, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_steel_totalprice.text = MainThings.getBuyPrice(4, int.Parse(VillageMenu_Market_Buy_steel_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_tool_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[5].ToString();
            VillageMenu_Market_Buy_tool_price.text = MainThings.getBuyPrice(5, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_tool_totalprice.text = MainThings.getBuyPrice(5, int.Parse(VillageMenu_Market_Buy_tool_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Buy_furniture_amount.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[6].ToString();
            VillageMenu_Market_Buy_furniture_price.text = MainThings.getBuyPrice(6, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Buy_furniture_totalprice.text = MainThings.getBuyPrice(6, int.Parse(VillageMenu_Market_Buy_furniture_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();


            VillageMenu_Market_Sell_food_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[0].ToString();
            VillageMenu_Market_Sell_food_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[0].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[0].ToString();
            VillageMenu_Market_Sell_food_price.text = MainThings.getSellPrice(0, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_food_totalprice.text = MainThings.getSellPrice(0, int.Parse(VillageMenu_Market_Sell_food_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_wood_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[1].ToString();
            VillageMenu_Market_Sell_wood_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[1].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[1].ToString();
            VillageMenu_Market_Sell_wood_price.text = MainThings.getSellPrice(1, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_wood_totalprice.text = MainThings.getSellPrice(1, int.Parse(VillageMenu_Market_Sell_wood_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_coal_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[2].ToString();
            VillageMenu_Market_Sell_coal_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[2].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[2].ToString();
            VillageMenu_Market_Sell_coal_price.text = MainThings.getSellPrice(2, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_coal_totalprice.text = MainThings.getSellPrice(2, int.Parse(VillageMenu_Market_Sell_coal_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_iron_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[3].ToString();
            VillageMenu_Market_Sell_iron_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[3].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[3].ToString();
            VillageMenu_Market_Sell_iron_price.text = MainThings.getSellPrice(3, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_iron_totalprice.text = MainThings.getSellPrice(3, int.Parse(VillageMenu_Market_Sell_iron_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_steel_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[4].ToString();
            VillageMenu_Market_Sell_steel_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[4].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[4].ToString();
            VillageMenu_Market_Sell_steel_price.text = MainThings.getBuyPrice(4, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_steel_totalprice.text = MainThings.getSellPrice(4, int.Parse(VillageMenu_Market_Sell_steel_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_tool_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[5].ToString();
            VillageMenu_Market_Sell_tool_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[5].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[5].ToString();
            VillageMenu_Market_Sell_tool_price.text = MainThings.getSellPrice(5, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_tool_totalprice.text = MainThings.getSellPrice(5, int.Parse(VillageMenu_Market_Sell_tool_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();

            VillageMenu_Market_Sell_furniture_amount_korovan.text = korovan.GetComponent<Korovan>().Inventory[6].ToString();
            VillageMenu_Market_Sell_furniture_amount_village.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Inventory[6].ToString()
                + "/" + korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().Capacity[6].ToString();
            VillageMenu_Market_Sell_furniture_price.text = MainThings.getSellPrice(6, 1, korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
            VillageMenu_Market_Sell_furniture_totalprice.text = MainThings.getSellPrice(6, int.Parse(VillageMenu_Market_Sell_furniture_input.text), korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>()).ToString();
        }
    }
}
