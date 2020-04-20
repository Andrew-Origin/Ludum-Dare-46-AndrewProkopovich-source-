using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementGirl : MonoBehaviour
{
    Animator anim;
    public float movespeedGirl = 3;
    public bool girlIsMoving = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (girlIsMoving == true)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * movespeedGirl;
            anim.SetFloat("isRunning", Mathf.Abs(Input.GetAxis("Horizontal")));
        }

        //switch between characters
        if (Input.GetKeyDown(KeyCode.Tab) && girlIsMoving == false)
        {
            movespeedGirl = 3f;
            girlIsMoving = true;
            Debug.Log("MoveGirl");
        }else if (Input.GetKeyDown(KeyCode.Tab) && girlIsMoving == true)
        {
            movespeedGirl = 0f;
            girlIsMoving = false;
            Debug.Log("StopGirl");
        }
    }
}