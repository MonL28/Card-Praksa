using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None", Resources.Load<Sprite>("Chalice")));
        cardList.Add(new Card(1, "Human", 2, 1, "This is a human", Resources.Load<Sprite>("Human")));
        cardList.Add(new Card(2, "Elf", 3, 3, "This is an elf", Resources.Load<Sprite>("Elf")));
        cardList.Add(new Card(3, "Dwarf", 4, 4, "This is a dwarf", Resources.Load<Sprite>("Dwarf")));
        cardList.Add(new Card(4, "Troll", 5, 5, "This is a troll", Resources.Load<Sprite>("Troll")));
    }
}
