using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human
{
    public string firstName = "";
    public string lastName = "";
    public Human spouse;

    //����� ���� ������: Human ������ �ν��Ͻ� ��ü�� ������ �� �Ķ���͸� �̿��Ͽ� ��ҵ��� ���� ������ �� �ִ� ������(�޼ҵ�)
    public Human() { } //�Ķ���� ���� Human �ν��Ͻ� ��ü ���� ���� ���� ������
    public Human(string pFirstName, string pLastName)
    {
        this.firstName = pFirstName;
        this.lastName = pLastName;
    }

    public bool IsMarriedWith (Human otherPerson)
    {
        if (spouse != null)
        {
            if (otherPerson == this.spouse) { return true; }
            else { return false; }
        }
        else
        {
            return false;
        }
    }
}

public class LearningObjects : MonoBehaviour
{
    public Human man;
    public Human woman;

    // Start is called before the first frame update
    void Start()
    {
        man = new Human();
        man.firstName = "Greg";
        man.lastName = "Lukosek";

        woman = new Human();
        woman.firstName = "Kate";
        woman.lastName = "Lukosek";

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
