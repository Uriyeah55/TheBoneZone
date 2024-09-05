using UnityEngine;

public class MoveBarrierAndReturnCollision : MonoBehaviour
{
    public Vector3 positionA; // Starting position
    public Vector3 positionB; // Ending position
    public float speed= .5f; // Speed of movement
    public float speedWhenReturning=.1f;
    public bool isTalking; // Boolean to control movement
    public GameObject player, manager, barrierToMove;
    private float progress = 0.0f; // Progress of the movement
    private bool isInsideCollider = false; // Whether the player is inside the collider

    void Start()
    {
        //positionA=new Vector3(2.31f,2.9f,8.09f);
       // positionB=new Vector3(2.31f,1f,8.09f);

        positionA=barrierToMove.transform.position;
        Debug.Log("position A for barrier is " + positionA);
        player = GameObject.Find("Player");
        manager = GameObject.Find("Manager");

    }

    void Update()
    {
        isTalking = manager.GetComponent<NewAudioManager>().itsSinging;

        if (isTalking && isInsideCollider)
        {
            // Move from position A to position B
            progress += speed * Time.deltaTime;
            barrierToMove.transform.position = Vector3.Lerp(positionA, positionB, progress);

            // Clamp progress to 1 to stop at positionB
            if (progress >= 1.0f)
            {
                progress = 1.0f;
                isTalking = false; // Stop moving when the object reaches position B
            }
        }
        else if (!isTalking && progress > 0.0f)
        {
            // Optionally, you can move the barrier back to position A when not talking
            // Comment out this block if you don't want the barrier to move back
            progress -= speedWhenReturning * Time.deltaTime;
            barrierToMove.transform.position = Vector3.Lerp(positionA, positionB, progress);

            if (progress <= 0.0f)
            {
                progress = 0.0f;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideCollider = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideCollider = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideCollider = false;
        }
    }
}
