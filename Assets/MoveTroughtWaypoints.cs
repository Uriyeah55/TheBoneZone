using System.Collections;
using UnityEngine;

public class MoveThroughWaypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public int currentWP = 0;
    public float speed = 5f;
    public float waitTime = 2f; // Time to wait before moving to the next waypoint


    void Start()
    {
        if (waypoints.Length > 0)
        {
            // Start the movement coroutine
            StartCoroutine(MoveToNextWaypoint());
        }
    }

    IEnumerator MoveToNextWaypoint()
    {
        while (true)
        {
            // Move towards the current waypoint
            while (Vector3.Distance(transform.position, waypoints[currentWP].transform.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWP].transform.position, speed * Time.deltaTime);
                yield return null; // Wait until the next frame
            }

            // Snap to the exact position of the waypoint (just in case)
            transform.position = waypoints[currentWP].transform.position;

            // Wait for the specified time before moving to the next waypoint
            yield return new WaitForSeconds(waitTime);

            // Move to the next waypoint
            currentWP = (currentWP + 1) % waypoints.Length;
        }
    }
}
