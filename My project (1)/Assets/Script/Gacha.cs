using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    string[] character =
    {
        "히어로", "팔라딘", "다크나이트",
        "아크메이지 불독", "아크메이지 썬콜", "비숍",
        "보우마스터", "신궁", "패스파인더",
        "나이트로드", "섀도어", "듀얼블레이드",
        "바이퍼", "캡틴", "캐논슈터"
    };

    List<string> characterList = new List<string>();

    public void Gacha10()
    {
        characterList.Clear();
        
        for (int i = 0; i < character.Length; i++)
        {
            characterList.Add(character[i]);
        }

        for (int i = 0;i < 10; i++)
        {
            int randomValue = Random.Range(0, characterList.Count);
            string characterName = characterList[randomValue];
            Debug.Log($"{i+1}회차 캐릭터: {characterName}");
        }
    }
    
       
}