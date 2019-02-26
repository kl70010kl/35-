using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    private float rotate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotate += 1;
            transform.localEulerAngles = new Vector3(0, 0, rotate);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotate -= 1;
            transform.localEulerAngles = new Vector3(0, 0, rotate);
        }
    }
}
