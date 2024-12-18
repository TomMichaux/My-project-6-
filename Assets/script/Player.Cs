using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(10, 0));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-10, 0));
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, 10));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -10));
        }

        m_Rigidbody.rotation += 5f;
    }
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("we bewegen naar Rechts! !");
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("we bewegen naar beneden");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = Vector3.zero;
        Debug.Log("We hebben iets geraakt!");

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene("Kuru Menu");
        transform.position = Vector3.zero;
    }
}
