using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    string[] character =
    {
        "�����", "�ȶ��", "��ũ����Ʈ",
        "��ũ������ �ҵ�", "��ũ������ ����", "���",
        "���츶����", "�ű�", "�н����δ�",
        "����Ʈ�ε�", "������", "�����̵�",
        "������", "ĸƾ", "ĳ����"
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
            Debug.Log($"{i+1}ȸ�� ĳ����: {characterName}");
        }
    }
    
       
}