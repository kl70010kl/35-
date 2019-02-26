using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int fullCount;
    public Text scoreLabel;
    public GameObject ResultLabel;
    // Start is called before the first frame update
    void Start()
    {
        fullCount = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    // Update is called once per frame
    void Update()
    {
        int count =
            5 - GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString() + " / " + fullCount.ToString();

        int goalCount = GameObject.FindGameObjectsWithTag("Goal").Length;

        if(goalCount == 0)
        {
            ResultLabel.SetActive(true);
        }
    }

    
}
