using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEndLevelenemy : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
               void OnTriggerEnter(Collider other)
    {
        //Check if its the player to kill him
        if (other.CompareTag("Player"))
        {
            enemy.SetActive(true);
            enemy.GetComponent<SpriteRenderer>().enabled=true;
        }
    }
}
