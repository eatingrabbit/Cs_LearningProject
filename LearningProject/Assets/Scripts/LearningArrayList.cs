using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningArrayList : MonoBehaviour
{
    public ArrayList inventory = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        //ArrayList: ũ������x, ����߰�����, ����Ÿ���� ���� ���� ����
        inventory.Add(10);
        inventory.Add(20);
        inventory.Add("Adam");
        inventory.Add(GameObject.Find("Player"));

        Debug.Log(inventory[1].GetType());
        Debug.Log(inventory[2].GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
