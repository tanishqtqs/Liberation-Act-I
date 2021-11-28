using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float posX;
    public float posY;
    public float posZ;
    private GameObject player;
    public GameObject enemyPrefab;
    public GameObject enemyPrefab1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Male_01_V01");
        posX = player.transform.position.x + Random.Range(-15, 15);
        posY = player.transform.position.y + Random.Range(5, 15);
        posZ = player.transform.position.z + Random.Range(10, 20);
        Instantiate(enemyPrefab, new Vector3(posX, posY, posZ), enemyPrefab.transform.rotation);
        Instantiate(enemyPrefab1, new Vector3(posX+5, posY, posZ+5), enemyPrefab1.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
