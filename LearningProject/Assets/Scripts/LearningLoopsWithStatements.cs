using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsWithStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            if (i == 0)
            {
                Debug.Log(i + " is zero");
            }
            else if (IsNumberEven(i))
            {
                Debug.Log(i + " is even");
            }
            else
            {
                Debug.Log(i + " is odd");
            }
        }
    }


    public bool IsNumberEven(int number)
    {
        if (number % 2 == 0) { return true; }
        else { return false; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
