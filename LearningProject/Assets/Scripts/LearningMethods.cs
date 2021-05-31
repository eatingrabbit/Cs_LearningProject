using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningMethods : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("Awake function is calling");

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start function is called");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        
    }
}
