using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjectWithConstructors : MonoBehaviour
{
    //������Ʈ ���� LearningObject ��ũ��Ʈ�� Human class ����
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
