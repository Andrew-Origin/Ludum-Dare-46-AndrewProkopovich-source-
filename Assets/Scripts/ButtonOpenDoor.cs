using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpenDoor : MonoBehaviour
{

    public bool openPurpleDoor;
    public bool openBlueDoor;
    public Collider2D playerPurple;
    public Collider2D playerBlue;
    public Collider2D thisObject;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerPurple.IsTouching(thisObject) && thisObject.CompareTag("BlueButton"))
        {
            FindObjectOfType<GameManager>().OpenBlueDoor();

            Debug.Log("Player is touching button");
        }
        if (playerBlue.IsTouching(thisObject) && thisObject.CompareTag("PurpleButton"))
        {
            FindObjectOfType<GameManager>().OpenPurpleDoor();

            Debug.Log("Player is touching button");

        }
        if (playerBlue.IsTouching(thisObject) && playerPurple.IsTouching(thisObject) && thisObject.CompareTag("FinishPlatform"))
        {
            FindObjectOfType<GameManager>().DropHearts();

        }
        if (playerBlue.IsTouching(thisObject) && thisObject.CompareTag("BlueHeart"))
        {
            FindObjectOfType<GameManager>().BlueHeartPickedUp();
            Debug.Log("Blue got heart");
        }
        if (playerPurple.IsTouching(thisObject) && thisObject.CompareTag("PurpleHeart"))
        {
            FindObjectOfType<GameManager>().PurpleHeartPickedUp();
            Debug.Log("Purple got heart");

        }
    }
}
