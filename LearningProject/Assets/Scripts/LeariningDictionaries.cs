using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeariningDictionaries : MonoBehaviour
{
    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("secondName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);

        if (personalDetails.Contains("firstName"))
        {
            Debug.Log((string)personalDetails["firstName"]);
        }
        else
        {
            Debug.Log("First name isn't stored in the hashtable");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
