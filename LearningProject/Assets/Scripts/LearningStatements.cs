using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStatements : MonoBehaviour
{
    public bool willItBeRaningToday = true;

    // Start is called before the first frame update
    void Start()
    {
        if (! willItBeRaningToday)
        {
            Debug.Log("Yes, you need umbrella");
        }
        else
        {
            Debug.Log("No, you don't need umbrella");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
