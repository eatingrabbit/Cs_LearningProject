using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeariningLists : MonoBehaviour
{
    public List<string> familyMembers = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //List: 변수타입 1개만 가능_사전지정 필수
        //Array: 변수타입1개만 지정가능_사전지정 필수_크기변경&요소추가 불가능_크기 사전지정 필수

        //Add: 객체 추가
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        //Remove: 객체 제거(여러개라면 처음의 객체 제거)
        familyMembers.Remove("Mia");

        //Contains: 객체 포함 여부 반환
        Debug.Log(familyMembers.Contains("Mia"));

        //Insert: 지정된 인덱스에 객체 삽입
        familyMembers.Insert(1, "Amy");

        string firstFamilyMember = familyMembers[0];

        Debug.Log(firstFamilyMember);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
