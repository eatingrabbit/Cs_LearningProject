using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReusableMethods : MonoBehaviour
{
    public int number1 = 2;
    public int number2 = 3;
    public int number3 = 7;

    // Start is called before the first frame update
    void Start()
    {
        AddAndPrintTwoNumbers(number1, number2);
        AddAndPrintTwoNumbers(number1, number3);
        AddAndPrintTwoNumbers(number2, number3);
        
    }

    void AddAndPrintTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
