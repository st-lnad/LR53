using UnityEngine;
using UnityEngine.UI;

public class HUDManagementScript : MonoBehaviour
{

    public GameObject korovan;

    public Text Text_Days;
    public Text Text_Gold;
    public Text Text_Rank;

    public Text VillageMenu_text;

    void Update()
    {
        Text_Days.text = "Day " + GameInnerTimer.days.ToString();
        Text_Gold.text = "Gold \n" + korovan.GetComponent<Korovan>().money.ToString();
        Text_Rank.text = "Rank " + korovan.GetComponent<Korovan>().famous.ToString();

        if (korovan.GetComponent<KorovanMovement>().is_init_allowed)
        {
            VillageMenu_text.text = korovan.GetComponent<PathFinder>().get_place_by_korovan_position(korovan.transform.position).GetComponent<Village>().village_name;
        }
        
    }
}
