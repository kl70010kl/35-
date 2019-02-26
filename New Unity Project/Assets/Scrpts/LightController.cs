using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light light;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        count = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    // Update is called once per frame
    void Update()
    {
        int previousCount = count;
        count = GameObject.FindGameObjectsWithTag("Item").Length;
        if (previousCount > count)
        {
            light.range += 0.75f;
        }
    }
}
