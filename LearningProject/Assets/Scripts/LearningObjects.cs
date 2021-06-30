using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human
{
    public string firstName = "";
    public string lastName = "";
    public Human spouse;

    //사용자 정의 생성자: Human 형식의 인스턴스 객체를 생성할 때 파라미터를 이용하여 요소들의 값을 대입할 수 있는 생성자(메소드)
    public Human() { } //파라미터 없이 Human 인스턴스 객체 선언 시의 에러 방지용
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
