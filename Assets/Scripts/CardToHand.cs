using UnityEngine;

public class CardToHand : MonoBehaviour
{
    public GameObject hand;
    public GameObject handCard;

    void Start()
    {

    }


    void Update()
    {
        hand = GameObject.Find("Hand");
        handCard.transform.SetParent(hand.transform);
        handCard.transform.localScale = Vector3.one;
        handCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        handCard.transform.eulerAngles = new Vector3(25, 0, 0);

    }
}
