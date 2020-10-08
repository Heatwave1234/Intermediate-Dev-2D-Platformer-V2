using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLockController : MonoBehaviour
{

    //GOAL: Indicate a green, blue, and red key and define what happens when they enter
    //      the green lock. When the green key enters, remove the green door. When the
    //      red or blue key enters, remove the key and re-instantiate it at its
    //      original position.


    public GameObject greenLock;
    public GameObject greenKey;
    public GameObject greenDoor;

    public GameObject redKey;
    public Vector2 redKeyPos;

    public GameObject blueKey;
    public Vector2 blueKeyPos;

    // Start is called before the first frame update
    void Start()
    {
        redKeyPos = redKey.transform.position;
        blueKeyPos = blueKey.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green")
        {
            Debug.Log("green key, green lock");
            Destroy(greenDoor);
        }

        if (collision.gameObject.tag == "Red")
        {
            Debug.Log("red key, green lock");

            Instantiate(redKey, new Vector3(redKeyPos.x, redKeyPos.y, 0), Quaternion.identity);
            Destroy(redKey);
        }

        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("blue key, green lock");

            Instantiate(blueKey, new Vector3(blueKeyPos.x, blueKeyPos.y, 0), Quaternion.identity);
            Destroy(blueKey);
        }
    }
}
