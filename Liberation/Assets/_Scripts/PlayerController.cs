using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public string moveInputAxis = "Vertical";
    public string turnInputAxis = "Horizontal";

    public float rotationRate = 360;
    public float moveSpeed = 10;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    
    //private Rigidbody rb;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
            GameObject projectile=Instantiate(projectilePrefab) as GameObject;
            projectile.transform.position=new Vector3(transform.position.x,transform.position.y+2f,transform.position.z);
            Rigidbody rb=projectile.GetComponent<Rigidbody>();
            rb.velocity=transform.forward*20;
        }
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }

    void FixedUpdate()
    {
        
    }






    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }


    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
        //rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
