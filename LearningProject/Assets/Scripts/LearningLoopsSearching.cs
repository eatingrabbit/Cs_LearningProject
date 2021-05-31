using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsSearching : MonoBehaviour
{
    public List<string> familyMembers = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        int adamsIndex = -1;

        for(int i = 0; i < familyMembers.Count; i++)
        {
            if (familyMembers[i] == "Adam")
            {
                adamsIndex = 1;
                break;
            }
        }

        if (adamsIndex == -1)
        {
            Debug.Log("Adam value is not stored in the list");
        }
        else
        {
            Debug.Log("Adam value found at index " + adamsIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
