using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        UIManagementScript.UI_activated = false;
    }
}
