using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    public GameObject manager;
    private bool playerSinging;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        
    }

    // Update is called once per frame
    void Update()
    {
        playerSinging=manager.GetComponent<NewAudioManager>().itsSinging;
        if(playerSinging){
           // this.gameObject.SetActive(true);
        }
        else{
           // this.gameObject.SetActive(false);

        }
    }
                   void OnTriggerEnter(Collider other)
    {
        //Check if its the player to kill him
        if (other.CompareTag("Player"))
        {
            manager.GetComponent<TriggerEndLevelSwitches>().switchesCounter++;
            Destroy(this.gameObject,0f);
        }
    }
}
