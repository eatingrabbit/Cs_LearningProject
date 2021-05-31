using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript : MonoBehaviour
{
    public int number1 = 2;
    public int number2 = 9;

    public bool areRoadConditioinsPerfect = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) AddTwoNumbers();
        
    }

    void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);

    }
}
