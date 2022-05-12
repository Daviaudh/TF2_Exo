using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 initialPos; // ball's initial position
    Rigidbody m_speed; 

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
       

       // initialPos = transform.position; // default it to where we first place it in the scene
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.transform.CompareTag("Wall")) // if the ball hits a wall
        {
           transform.velocity = transform.forward  * m_speed ;  
        }
    }

    if(Input.GetKeyDown(KeyCode.F))
        {


        }

}


//  private void OnTriggerEnter(Collider other)
//{
//    if (other.CompareTag("Ball"))
//    {


//    }
//}