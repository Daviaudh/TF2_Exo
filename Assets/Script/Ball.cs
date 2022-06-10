using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody m_Rigidbody;
    Vector3 initialPos; // ball's initial position
    public float m_speedBall;
    public float m_gravity;
    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_gravity = Physics.gravity.y;

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall")) 
        {
            m_Rigidbody.velocity = -transform.forward * m_speedBall;
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("speedBall : " + m_speedBall.ToString("00.00"));
        m_speedBall = GUILayout.HorizontalSlider(m_speedBall, 1f, 50f);
        GUILayout.Label("GravityBall : " + m_gravity.ToString("00.00"));
        m_gravity = GUILayout.HorizontalSlider(m_gravity, 0f, 50f);
    }




}


