using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWhileSinging : MonoBehaviour
{
    public bool isSinging; // Boolean to control movement
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        
    }

    // Update is called once per frame
    void Update()
    {
    isSinging = manager.GetComponent<NewAudioManager>().itsSinging;
    if(isSinging){
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
    else{
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
        
    }
}
