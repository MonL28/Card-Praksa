using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpponentHealth : MonoBehaviour
{

    public static float maxHP;
    public static float staticHP;
    public float hp;
    public Image health;
    public TextMeshProUGUI hpText;


    private void Start()
    {
        maxHP = 25000;
        staticHP = 5000;
    }
    private void Update()
    {
        hp = staticHP;
        health.fillAmount = hp / maxHP;
        health.color = Color.red;

        if (hp >= maxHP)
        {
            hp = maxHP;
        }

        hpText.text = hp + "HP";
    }
}
