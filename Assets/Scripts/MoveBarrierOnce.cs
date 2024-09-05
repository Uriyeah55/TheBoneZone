using UnityEngine;

public class MoveBarrierOnce : MonoBehaviour
{
    private Vector3 positionA; // Starting position
    public Vector3 positionB; // Ending position
    public float speed = 0.5f; // Speed of movement
    public bool isTalking; // Boolean to control movement
    public GameObject manager, barrierToMove;
    private float progress = 0.0f; // Progress of the movement

    void Start()
    {
        // Set the starting and ending positions
        positionA = new Vector3(transform.position.x, transform.position.y,  transform.position.z); // Original position
       // positionB = new Vector3(22, transform.position.y, transform.position.z);  // Horizontal move to the right

        // Position the barrier at the starting position
        //barrierToMove.transform.position = positionA;

        // Find the Manager object
        manager = GameObject.Find("Manager");
    }

    void Update()
    {
        // Check if the manager indicates that the object should move
        isTalking = manager.GetComponent<NewAudioManager>().itsSinging;

        if (isTalking)
        {
            // Move from position A to position B
            progress += speed * Time.deltaTime;

            barrierToMove.transform.position = Vector3.Lerp(transform.position, positionB, progress);

            // Clamp progress to 1 to stop at positionB
            if (progress >= 1.0f)
            {
                isTalking = false; // Stop moving when the object reaches position B
            }
        }
     
    }
}
