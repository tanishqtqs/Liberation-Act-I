using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public static int health=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health==0)
        {
            Debug.Log("Game Over!");
        }
    }
     void OnTriggerEnter(Collider other){
        if (other.CompareTag("Enemy"))
        {
            health=health-100;
        }
        
        
    }
}
