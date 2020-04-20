using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool purpleHeartPickedUp = false;
    public bool blueHeartPickedUp = false;
    public GameObject openingHearts;
    public GameObject purpleDoor;
    public GameObject blueDoor;
    public GameObject purpleLuke;
    public GameObject blueLuke;
    Animator anim1;
    Animator anim2;
    Animator lukeAnim1;
    Animator lukeAnim2;

    private void Start()
    {
        anim1 = purpleDoor.GetComponent<Animator>();
        anim2 = blueDoor.GetComponent<Animator>();
        lukeAnim1 = purpleLuke.GetComponent<Animator>();
        lukeAnim2 = blueLuke.GetComponent<Animator>();
    }

    public void OpenPurpleDoor (){
        anim1.SetBool("doorOpen", true);
        purpleDoor.gameObject.GetComponent<Collider2D>().enabled = false;
        Debug.Log("Purple Door Opened");

    }
    public void OpenBlueDoor()
    {
        anim2.SetBool("openDoor", true);
        blueDoor.gameObject.GetComponent<Collider2D>().enabled = false;
        Debug.Log("Blue Door Opened");
    }

    public void PurpleHeartPickedUp()
    {
        purpleHeartPickedUp = true;
        if (purpleHeartPickedUp == true && blueHeartPickedUp == true)
        {
            GameObject canvas = GameObject.Find("EndLevelCanvas");
            canvas.GetComponent<Canvas>().enabled = true;
        }

    }
    public void BlueHeartPickedUp()
    {
        blueHeartPickedUp = true;
        if (purpleHeartPickedUp == true && blueHeartPickedUp == true)
        {
            GameObject canvas = GameObject.Find("EndLevelCanvas");
            canvas.GetComponent<Canvas>().enabled = true;
        }

    }

    public void DropHearts()
    {
        lukeAnim1.SetBool("isOpen", true);
        blueLuke.gameObject.GetComponent<Collider2D>().enabled = false;
        lukeAnim2.SetBool("isOpen", true);
        purpleLuke.gameObject.GetComponent<Collider2D>().enabled = false; 
        Debug.Log("Hears Droppped");
    }
}
