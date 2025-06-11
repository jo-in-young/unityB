using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    public TextMeshProUGUI txt_Star;

    string star;

    public void OnClickButton()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1() // 1페이즈
    {
        star = string.Empty;
        for (int i = 1; i <= 5; i++) //
        {
            star += new string('★', i);
            star += "\n";
        }
        Debug.Log(star);
        txt_Star.text = star;

    }

    public void Phase2() // 2페이즈
    {
        star = string.Empty;
        for (int i = 5; i >= 1; i--)
        {
            star += new string('★',i);
            star += new string('　', 5 - i);
            star += "\n";
        }
        Debug.Log(star);
        txt_Star.text = star;

    }

    public void Phase3() // 3페이즈
    {
        star = string.Empty;
        for (int i = 1; i <= 5; i++) //
        {
            star += new string('★', i);
            star += "\n";
        }

        for (int j = 4; j >= 1; j--)
        {
            star += new string('★', j);
            star += new string('　', 5 - j);
            star += "\n";
        }
        Debug.Log(star);
        txt_Star.text = star;

    }

    public void Phase4() // 4페이즈
    {
        star = string.Empty;
        for (int i = 1; i <= 5; i++)
        {
            star += new string('　', 5 - i);
            star += new string('★', i);
            star += "\n";
        }

        for(int i = 4;i >= 1;i--)
        {
            star += new string('　', 5 - i);
            star += new string('★', i);
            star += "\n";
        }
        Debug.Log(star);
        txt_Star.text = star;

    }
    public void Phase5() // 5페이즈
    {
        star = string.Empty;
        for (int i = 1; i <= 5; i++) // 윗 부분
        {
            star += new string('　', 5 - i);
            star += new string('★', 2 * i - 1);
            star += new string('　', 5 - i);
            star += "\n";
        }

        for (int i = 4; i >=1; i--)
        {
            star += new string('　', 5 - i);
            star += new string('★', 2 * i - 1);
            star += new string('　', 5 - i);
            star += "\n";
        }
        
        Debug.Log(star);
        txt_Star.text = star;

    }

}
