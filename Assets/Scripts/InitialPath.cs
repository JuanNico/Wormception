using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPath : MonoBehaviour
{
    public GameObject player;
    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponentInChildren<AnimatorGusano>().remolino = true;
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().isKinematic = true;
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        // Set position of Enemy as position of the first waypoint
        player.transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move Enemy
        Move();
    }
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {
            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            player.transform.position = Vector2.MoveTowards(player.transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);
            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (player.transform.position == waypoints[waypointIndex].transform.position)
            {
                print("advance");
                waypointIndex += 1;
            }
        }
        else
        {
            player.GetComponentInChildren<AnimatorGusano>().remolino = false;
            print("arrival");
            player.GetComponent<PlayerMovement>().enabled = true;
            player.GetComponent<Rigidbody2D>().gravityScale = 2;
            player.GetComponent<Rigidbody2D>().isKinematic = false;
        }
    }
}
