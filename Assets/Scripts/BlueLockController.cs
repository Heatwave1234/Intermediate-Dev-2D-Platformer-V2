using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLockController : MonoBehaviour
{
    //GOAL: Indicate a blue and red key and define what happens when they enter
    //      the red lock. When the blue key enters, remove the blue door. When the
    //      red key enters, remove the red key and re-instantiate it at its
    //      original position.
    public GameObject blueLock;
    public GameObject blueKey;
    public GameObject blueDoor;

    public GameObject redKey;
    public Vector3 redKeyPos;
    // Start is called before the first frame update
    void Start()
    {
        redKeyPos = redKey.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("blue key, blue lock");
            Destroy(blueDoor);
        }

        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("red key, blue lock");

            Instantiate(redKey, new Vector3(redKeyPos.x, redKeyPos.y, 0), Quaternion.identity);
            Destroy(redKey);
        }
    }
}
