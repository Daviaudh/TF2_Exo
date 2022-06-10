using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    [SerializeField]
    private float speedPerso = 2f; // player move speed

    [SerializeField]
    private Rigidbody rgbd;

    public float ballSpeed;

    Ball ballScript;
   
    void Start()
    {
      
    }

   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); // get the horizontal axis of the keyboard
        float v = Input.GetAxisRaw("Vertical"); // get the vertical axis of the keyboard

        if (h !=0 || v !=0)
        {
            transform.Translate(new Vector3(h, 0, v) * speedPerso * Time.deltaTime);
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{

            if (other.CompareTag("Ball"))
            {
                rgbd = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
                ballScript = GameObject.Find("Ball").GetComponent<Ball>();
                ballSpeed = ballScript.m_speedBall;
                rgbd.velocity = transform.forward * ballSpeed;
            }
       //}
    }
}
