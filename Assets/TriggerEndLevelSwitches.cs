using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEndLevelSwitches : MonoBehaviour
{
    public int switchesCounter=0;
    public GameObject nextLevelObj,manager;
    public List<GameObject> switches;
    bool playerIsSinging;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        
    }

    // Update is called once per frame
    void Update()
    {
        playerIsSinging=manager.GetComponent<NewAudioManager>().itsSinging;

        if(playerIsSinging){
   foreach(GameObject currentSwitch in switches){
    if(currentSwitch != null){
            currentSwitch.SetActive(true);

    }
        }
        }
        else{
               foreach(GameObject currentSwitch in switches){
    if(currentSwitch != null){
            currentSwitch.SetActive(false);

    }
        }
        }
     
        if(switchesCounter>=4){
            nextLevelObj.SetActive(true);
            nextLevelObj.GetComponent<BoxCollider>().enabled=true;
        }
        
    }
}
