using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    float hinput;
    float vinput;
    Vector3 Movement;

    [SerializeField] 
    float speed=7f;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       PlayerInput();
       
       
       
    }
    void FixedUpdate()
    {
        Move();
    }
    void PlayerInput()
    {
        hinput=Input.GetAxis("Horizontal");
        vinput=Input.GetAxis("Vertical");
        Movement= new Vector3(hinput,0,vinput);
    }

    void Move()
    {
           
        rb.AddForce(Movement*speed);
        Debug.Log(Movement*speed);
    }
    
}
