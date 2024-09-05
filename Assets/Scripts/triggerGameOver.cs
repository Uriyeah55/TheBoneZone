using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGameOver : MonoBehaviour
{
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
        // Check if the player enters the specific trigger collider
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
