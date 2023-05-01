using UnityEngine;

public class UIManagementScript : MonoBehaviour
{
    public GameObject VillageMenu;
    public GameObject VillageMenu_Market_Buy;
    public GameObject VillageMenu_Market_Sell;
    public GameObject VillageMenu_Inn;
    public GameObject VillageMenu_Gossip;
    public GameObject VillageMenu_End;
    public GameObject Village1_1;
    public GameObject Village1_2;
    public GameObject Village2_1;
    public GameObject Village2_2;
    public GameObject Village3_1;
    public GameObject Village3_2;
    public GameObject Village4_1;
    public GameObject Village4_2;
    public GameObject Village5_1;
    public GameObject Village5_2;
    public GameObject Village6_1;
    public GameObject Village6_2;
    public GameObject Village7_1;
    public GameObject Village7_2;
    public GameObject Village8_1;
    public GameObject Village8_2;
    public GameObject Village9_1;
    public GameObject Village9_2;
    public GameObject Village10_1;
    public GameObject Village10_2;
    public GameObject Village11_1;
    public GameObject Village11_2;

    public static bool UI_activated;
    public static bool Inner_UI_activated;

    void Start()
    {
        DisableUI();
    }

    public void DisableUI()
    {
        VillageMenu.SetActive(false);
        VillageMenu_Market_Buy.SetActive(false);
        VillageMenu_Market_Sell.SetActive(false);
        VillageMenu_Inn.SetActive(false);
        VillageMenu_Gossip.SetActive(false);
        VillageMenu_End.SetActive(false);
        Village1_1.SetActive(false);
        Village1_2.SetActive(false);
        Village2_1.SetActive(false);
        Village2_2.SetActive(false);
        Village3_1.SetActive(false);
        Village3_2.SetActive(false);
        Village4_1.SetActive(false);
        Village4_2.SetActive(false);
        Village5_1.SetActive(false);
        Village5_2.SetActive(false);
        Village6_1.SetActive(false);
        Village6_2.SetActive(false);
        Village7_1.SetActive(false);
        Village7_2.SetActive(false);
        Village8_1.SetActive(false);
        Village8_2.SetActive(false);
        Village9_1.SetActive(false);
        Village9_2.SetActive(false);
        Village10_1.SetActive(false);
        Village10_2.SetActive(false);
        Village11_1.SetActive(false);
        Village11_2.SetActive(false);
        UI_activated = false;
        Inner_UI_activated = false;
    }
}
