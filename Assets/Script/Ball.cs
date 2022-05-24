using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 initialPos; // ball's initial position
    public float m_speed; 

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
       

       // initialPos = transform.position; // default it to where we first place it in the scene
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall")) // if the ball hits a wall
        {
            m_Rigidbody.velocity = transform.forward * m_speed;
        }


        if (Input.GetKeyDown(KeyCode.F))
        {


        }
    }

    private void OnGUI()
    {
        GUILayout.Label("speed : " + m_speed.ToString("00.00"));
        m_speed = GUILayout.HorizontalSlider(m_speed, 1f, 12f);
    }



}


//  private void OnTriggerEnter(Collider other)
//{
//    if (other.CompareTag("Ball"))
//    {


//    }
//}