using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIY : MonoBehaviour
{
    string Name = "���ο�";
    int Age = 24;
    float Height = 168.1f;
    string MBTI = "ISFJ";
    string Major = "�ѱ������а�";
    string Hobby = "����";
    string Skill = "�׸� �׸���";
    string Region = "����";
    string PhoneNumber = "010-1111-1111";
    string BloodType = "A";

    void Start()
    {
        SelfIntroduction();
        SelfIntroductionA();
        SelfIntroductionB("���ο�",24,168.1f,"ISFJ");
    }
    
    public void SelfIntroduction()
    {
        Debug.Log("�ȳ��ϼ���");
        Debug.Log("�� �̸��� " + Name + " �Դϴ�.");
        Debug.Log("�� ���̴� " + Age + " �Դϴ�.");
        Debug.Log("�� MBTI�� " + MBTI + " �Դϴ�.");
        Debug.Log("�� Ű�� " + Height + " �Դϴ�.");
        Debug.Log("�� ������ " + Major + " �Դϴ�.");
        Debug.Log("���� " + Region + "�� �����ϰ� �ֽ��ϴ�.");
        Debug.Log("��̴� " + Hobby + "�Դϴ�");
        Debug.Log("��������" + BloodType + "�� �Դϴ�.");
        Debug.Log("���� " + Skill + "�� ���մϴ�.");
        Debug.Log("�� ��ȣ�� " + PhoneNumber + "�Դϴ�.");

    }


    public void SelfIntroductionA()
    {
        Debug.Log($"�̸�: {Name}, ����: {Age}");
        Debug.Log($"����: {Major},Ű: {Height}");
        Debug.Log($"MBTI: {MBTI}, ���: {Hobby}");
        Debug.Log($"������{Region}, ������{BloodType}");
        Debug.Log($"��?��: {Skill}, ��ȣ: {PhoneNumber}");
    }

    public void SelfIntroductionB(
        string _Name,
        int _Age,
        float _Height,
        string _Mbti
        )
    {
        Debug.Log($"�̸�:{_Name}, ����: {_Age}");
    }
}