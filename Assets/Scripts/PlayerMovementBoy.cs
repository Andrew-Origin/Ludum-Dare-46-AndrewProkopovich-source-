using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBoy : MonoBehaviour
{
    Animator anim;
    public float movespeedBoy = 3f;
    public bool boyIsMoving = true;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        // character moving horizontal
        if (boyIsMoving == true)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * movespeedBoy;
            anim.SetFloat("isRunning", Mathf.Abs(Input.GetAxis("Horizontal")));
        }

        //switch between characters
        if (Input.GetKeyDown(KeyCode.Tab) && boyIsMoving == false)
        {
            movespeedBoy = 3f;
            boyIsMoving = true;
            Debug.Log("MoveBoy");
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && boyIsMoving == true)
        {
            movespeedBoy = 0f;
            boyIsMoving = false;
            Debug.Log("StopBoy");
        }
    }
}
