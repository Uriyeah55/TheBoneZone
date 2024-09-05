using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace StarterAssets
{

public class EnemyBehaviourInverted : MonoBehaviour
{
    public GameObject player,manager,ScreamManager;
    public bool isSinging; // Boolean to control movement
    public float moveSpeed=2f;
    public float MaxmoveSpeed=2f;

    public GameObject PinkskeletonSkull,PinkskeletHand;



    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");


    }

    // Update is called once per frame
void Update()
{
    isSinging = manager.GetComponent<NewAudioManager>().itsSinging;
    
    if (isSinging)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;

            Debug.Log("Disabling BoxCollider");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("BoxCollider is now " + gameObject.GetComponent<BoxCollider>().enabled);
        moveSpeed = 0f;

        // Store the original Y position
        float fixedY = transform.position.y;

        // Move towards the player, but keep the original Y position
        Vector3 targetPosition = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        targetPosition.y = fixedY; // Fix the Y position

        // Apply the new position to the enemy
        transform.position = targetPosition;
    }
    else
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;

        moveSpeed = MaxmoveSpeed;
        
        // Store the original Y position
        float fixedY = transform.position.y;

        // Move towards the player, but keep the original Y position
        Vector3 targetPosition = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        targetPosition.y = fixedY; // Fix the Y position

        // Apply the new position to the enemy
        transform.position = targetPosition;
    }
}
void CallGameOverScene(){
            SceneManager.LoadScene("gameover");

}
void AnimationSkullDelay(){
            PinkskeletonSkull.SetActive(true);
            
            Invoke("CallGameOverScene",0.5f);

}

           void OnTriggerEnter(Collider other)
    {
        //Check if its the player to kill him
        if (other.CompareTag("Player"))
        {
            player.gameObject.GetComponent<FirstPersonController>().enabled=false;
ScreamManager.SetActive(true);  

            PinkskeletHand.SetActive(true);
            Invoke("AnimationSkullDelay",1f);

        }
    }
}
}