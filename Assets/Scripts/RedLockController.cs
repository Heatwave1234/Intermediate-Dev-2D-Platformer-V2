using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLockController : MonoBehaviour
{
    //GOAL: Indicate a blue and red key and define what happens when they enter
    //      the red lock. When the red key enters, remove the red door. When the
    //      blue key enters, remove the blue key and re-instantiate it at its
    //      original position.

    public GameObject redLock;
    public GameObject redKey;
    public GameObject redDoor;

    public GameObject blueKey;
    public Vector3 blueKeyPos;


    // Start is called before the first frame update
    void Start()
    {
        blueKeyPos = blueKey.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("Red key, red lock");
            Destroy(redDoor);
        }
        
        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("Blue key, red lock");
            
            Instantiate(blueKey, new Vector3(blueKeyPos.x, blueKeyPos.y, 0), Quaternion.identity);
            Destroy(blueKey);
        }
    }
}
