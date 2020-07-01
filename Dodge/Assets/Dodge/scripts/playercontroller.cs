using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public float m_Speed = 10f;
    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = /*gameObject.*/GetComponent<Rigidbody>();

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector3(xAxis, 0, yAxis) * m_Speed);

        if (Input.GetKeyDown(KeyCode.Space))
            Die();
    }

    public void Die()
    {
        Debug.Log("사망");
        gameObject.SetActive(false);
    }
        
}
