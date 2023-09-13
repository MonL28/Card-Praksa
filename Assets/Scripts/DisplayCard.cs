using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();

    public int displayID;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public Sprite spriteImage;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descriptionText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject hand;
    public int numberOfCardInDeck;
    private void Start()
    {
        numberOfCardInDeck = PlayerDeck.deckSize;  
    }

    private void Update()
    {
        displayCard[0] = CardDataBase.cardList[displayID];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        cardDescription = displayCard[0].cardDescription;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;

        hand = GameObject.Find("Hand");

        if(this.transform.parent == hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardInDeck - 2];
            numberOfCardInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

        // probaj staviti u for
    }  
    

}
