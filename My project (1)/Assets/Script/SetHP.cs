using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    // Start is called before the first frame update

    public Image img_HPbar;

    public int maxHP;
    int nowHP;
    // �ּ� ü���� 0

    public int Damage;
    public int HealPoint;

    public void Awake()
    {
        nowHP = maxHP;
    }

    public void OnClickDamage() // ������
    {
        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;

        }

        img_HPbar.fillAmount = nowHP / maxHP;
    }

    public void OnClickHealPoint() // ȸ��
    {
        nowHP += HealPoint; //ȸ���Ѵ�
        if (nowHP < maxHP) 
        { 
            nowHP = maxHP; 
        }

    }    
}
