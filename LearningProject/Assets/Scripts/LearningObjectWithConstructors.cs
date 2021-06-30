using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjectWithConstructors : MonoBehaviour
{
    //프로젝트 내의 LearningObject 스크립트의 Human class 따름
    public Human man;
    public Human woman;

    // Start is called before the first frame update
    void Start()
    {
        man = new Human("Greg", "Lukosek");
        woman = new Human("Kate", "Lukosek");

        man.spouse = woman;
        woman.spouse = man;

        if (man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + " is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName + " and " + woman.firstName + " are not married");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
