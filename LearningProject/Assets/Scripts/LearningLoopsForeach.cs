using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsForeach : MonoBehaviour
{
    public List<string> familyMembers = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        foreach (string familyMember in familyMembers)
        {
            Debug.Log(familyMember);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
