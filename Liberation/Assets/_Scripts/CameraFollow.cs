using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    public  Vector3 offset = new Vector3(0,4,-7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
        //transform.rotation=Player.transform.rotation;
    }
    
    void LateUpdate()
    {
        transform.rotation=Player.transform.rotation;

    }
}
