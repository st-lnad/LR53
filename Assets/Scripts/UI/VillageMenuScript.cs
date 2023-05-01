using UnityEngine;

public class VillageMenuScript : MonoBehaviour
{
    public GameObject Menu0;
    public GameObject Menu1;
    public GameObject Menu2;

    public GameObject korovan;

    public GameObject GameInit;

    public int status;

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        if (korovan.GetComponent<KorovanMovement>().is_init_allowed == true && UIManagementScript.Inner_UI_activated == false)
        {
            GameInit.GetComponent<UIManagementScript>().DisableUI();
            if (status == 1)
            {
                if (Menu1.activeSelf == true && UIManagementScript.UI_activated == true)
                {
                    Menu1.SetActive(false);
                    UIManagementScript.UI_activated = false;
                }
                else if (Menu1.activeSelf == false && UIManagementScript.UI_activated == false)
                {
                    Menu1.SetActive(true);
                    UIManagementScript.UI_activated = true;
                }
            }
            else if (status == 2)
            {
                if (Menu2.activeSelf == true && UIManagementScript.UI_activated == true)
                {
                    Menu2.SetActive(false);
                    UIManagementScript.UI_activated = false;
                }
                else if (Menu2.activeSelf == false && UIManagementScript.UI_activated == false)
                {
                    Menu2.SetActive(true);
                    UIManagementScript.UI_activated = true;
                }
            }
            else if (status == 0)
            {
                if (Menu0.activeSelf == false && UIManagementScript.UI_activated == false)
                {
                    Menu0.SetActive(true);
                    UIManagementScript.UI_activated = true;
                    UIManagementScript.Inner_UI_activated = true;
                }
            }
        }


    }
}
