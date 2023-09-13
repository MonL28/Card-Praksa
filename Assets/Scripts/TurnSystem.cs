using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isOpponentTurn;
    public TextMeshProUGUI turnText;

    public int maxMana;
    public int currentMana;
    public TextMeshProUGUI manaText;

    private void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        isOpponentTurn = 0;
        maxMana = 1;
        currentMana = 1;
    }

    private void Update()
    {
        if(isYourTurn == true)
        {
            turnText.text = "Your turn!";
        }
        else
        {
            turnText.text = "Opponent`s turn!";
        }

        manaText.text = currentMana + "/" + maxMana;
    }
    public void EndYourTurn()
    {
        isYourTurn = false;
        isOpponentTurn += 1;
    }
    public void EndOppenentTurn()
    {
        isYourTurn = true;
        yourTurn += 1;

        maxMana += 1;
        currentMana = maxMana;
    }

}
