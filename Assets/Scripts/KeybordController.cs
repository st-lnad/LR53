using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybordController : MonoBehaviour
{
    public Vector3 to = new Vector3(10, 5, 0);
    public float time = 10f;
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<KorovanMovement>().init(road);
        }
    }
}
