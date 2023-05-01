using UnityEngine;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour
{
    public GameObject korovan;

    public GameObject VillageMenu_End;

    public Text End_text;

    public bool gameEnded = false;
    void Update()
    {
        if (korovan.GetComponent<Korovan>().money >= 10000000 && gameEnded == false)
        {

            End_text.text = "You have achieved your main goal\n\n10 000 000 gold\nOn Day "+GameInnerTimer.days+"\n\nCongratulations!!!";

            VillageMenu_End.SetActive(true);
            gameEnded = true;
        }
    }
}
