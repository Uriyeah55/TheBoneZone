using UnityEngine;

public class MoveFromCollision : MonoBehaviour
{
    public GameObject objetToMove,manager;
    public Vector3 positionA,positionB; // Ending position
    public float speed = 1.0f; // Speed of movement
    public bool isSinging = false; // Boolean to control movement

    private float progress = 0.0f; // Progress of the movement
    private bool insideCollider = false; // Whether the object is inside the collider

void Start(){
        manager = GameObject.Find("Manager");

}
    void Update()
    {
        isSinging = manager.GetComponent<NewAudioManager>().itsSinging;

        if (isSinging && insideCollider)
        {

            // Move from position A to position B
            progress += speed * Time.deltaTime;
            objetToMove.transform.position = Vector3.Lerp(positionA, positionB, progress);
            
            // Clamp progress to 1 to stop at positionB
            if (progress >= 1.0f)
            {
                progress = 1.0f;
                isSinging = false;
            }
        }
        else
        {
            // If not moving or outside the collider, reset progress to 0 for future moves
            //progress = 0.0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object enters the specific trigger collider
        if (other.CompareTag("Player"))
        {
            insideCollider = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        // Check if the object stays inside the specific trigger collider
        if (other.CompareTag("Player"))
        {
            insideCollider = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the object exits the specific trigger collider
        if (other.CompareTag("Player"))
        {
            insideCollider = false;
        }
    }
}
