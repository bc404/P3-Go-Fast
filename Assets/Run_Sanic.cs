using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Sanic : MonoBehaviour
{
        //Variables
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //Adding Gravity and Rigidbody
        
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
            //Making the Player Jump when Space is Pressed
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           
            //Stopping Double Jump
            
            isOnGround = false;
        }
    }
            //Stopping Double Jump
        
        private void OnCollisionEnter(Collision collision)
        {
            isOnGround = true;
        }
}
