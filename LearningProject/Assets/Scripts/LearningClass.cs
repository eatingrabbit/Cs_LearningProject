using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    public string firstName = "";
    public string lastName = "";
    public int age = 0;
    public string address = "";
    public bool isMale = false;
    public bool isMarried = false;
}

public class LearningClass : MonoBehaviour
{
    public Person father;
    public Person mother;
    public Person son;

    // Start is called before the first frame update
    void Start()
    {
        father = new Person();
        father.firstName = "Greg";
        father.lastName = "Lukosek";
        father.age = 29;
        father.isMale = true;
        father.isMarried = true;

        mother = new Person();
        mother.firstName = "Kate";
        mother.lastName = "Lukosek";
        mother.age = 28;
        mother.isMale = false;
        mother.isMarried = true;

        son = new Person();
        son.firstName = "Adam";
        son.lastName = "Lukosek";
        son.age = 3;
        son.isMale = true;
        son.isMarried = false;


        Debug.Log(father.firstName + " and " + mother.firstName + " have a beautiful son " + son.firstName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
