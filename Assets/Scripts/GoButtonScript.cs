using UnityEngine;

public class GoButtonScript : MonoBehaviour
{
    public GameObject korovan;
    public GameObject village;

    public void Go()
    {
        GameObject road = korovan.GetComponent<PathFinder>().get_road(village, korovan);
        if (road != null)
        {
            korovan.GetComponent<KorovanMovement>().init(road);
        }
        else
        {
            Debug.Log("Road is only in your imagine");
        }
    }

}
