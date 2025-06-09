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
    // 최소 체력은 0

    public int Damage;
    public int HealPoint;

    public void Awake()
    {
        nowHP = maxHP;
    }

    public void OnClickDamage() // 데미지
    {
        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;

        }

        img_HPbar.fillAmount = nowHP / maxHP;
    }

    public void OnClickHealPoint() // 회복
    {
        nowHP += HealPoint; //회복한다
        if (nowHP < maxHP) 
        { 
            nowHP = maxHP; 
        }

    }    
}
