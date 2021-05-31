using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReusableMethodsWithReturn : MonoBehaviour
{
    public int number1 = 2;
    public int number2 = 3;

    // Start is called before the first frame update
    void Start()
    {
        int sumResult = AddTwoNumbers(number1, number2);
        DisplayResult(sumResult);
    }

    int AddTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }

    void DisplayResult(int total)
    {
        Debug.Log("The grand total is" + total);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
