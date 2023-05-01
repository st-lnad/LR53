using UnityEngine;

public class GoWithRightMouse : MonoBehaviour
{
    public GameObject korovan;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    /*
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
                Debug.Log("Click near smth");
                GameObject road = korovan.GetComponent<PathFinder>().get_road(gameObject, korovan);
                print(road);
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
    */

    // Update is called once per frame
    void Update()
    {

    }
}
