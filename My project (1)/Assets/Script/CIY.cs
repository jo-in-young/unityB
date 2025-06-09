using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CIY : MonoBehaviour
{
    string Name = "조인영";
    int Age = 24;
    float Height = 168.1f;
    string MBTI = "ISFJ";
    string Major = "한국역사학과";
    string Hobby = "게임";
    string Skill = "그림 그리기";
    string Region = "서울";
    string PhoneNumber = "010-1111-1111";
    string BloodType = "A";

    void Start()
    {
        SelfIntroduction();
        SelfIntroductionA();
        SelfIntroductionB("조인영",24,168.1f,"ISFJ");
    }
    
    public void SelfIntroduction()
    {
        Debug.Log("안녕하세요");
        Debug.Log("제 이름은 " + Name + " 입니다.");
        Debug.Log("제 나이는 " + Age + " 입니다.");
        Debug.Log("제 MBTI는 " + MBTI + " 입니다.");
        Debug.Log("제 키는 " + Height + " 입니다.");
        Debug.Log("제 전공은 " + Major + " 입니다.");
        Debug.Log("저는 " + Region + "에 거주하고 있습니다.");
        Debug.Log("취미는 " + Hobby + "입니다");
        Debug.Log("혈액형은" + BloodType + "형 입니다.");
        Debug.Log("저는 " + Skill + "를 잘합니다.");
        Debug.Log("제 번호는 " + PhoneNumber + "입니다.");

    }


    public void SelfIntroductionA()
    {
        Debug.Log($"이름: {Name}, 나이: {Age}");
        Debug.Log($"전공: {Major},키: {Height}");
        Debug.Log($"MBTI: {MBTI}, 취미: {Hobby}");
        Debug.Log($"거주지{Region}, 혈액형{BloodType}");
        Debug.Log($"능?력: {Skill}, 번호: {PhoneNumber}");
    }

    public void SelfIntroductionB(
        string _Name,
        int _Age,
        float _Height,
        string _Mbti
        )
    {
        Debug.Log($"이름:{_Name}, 나이: {_Age}");
    }
}