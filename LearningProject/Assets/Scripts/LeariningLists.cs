using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeariningLists : MonoBehaviour
{
    public List<string> familyMembers = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //List: ����Ÿ�� 1���� ����_�������� �ʼ�
        //Array: ����Ÿ��1���� ��������_�������� �ʼ�_ũ�⺯��&����߰� �Ұ���_ũ�� �������� �ʼ�

        //Add: ��ü �߰�
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        //Remove: ��ü ����(��������� ó���� ��ü ����)
        familyMembers.Remove("Mia");

        //Contains: ��ü ���� ���� ��ȯ
        Debug.Log(familyMembers.Contains("Mia"));

        //Insert: ������ �ε����� ��ü ����
        familyMembers.Insert(1, "Amy");

        string firstFamilyMember = familyMembers[0];

        Debug.Log(firstFamilyMember);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
