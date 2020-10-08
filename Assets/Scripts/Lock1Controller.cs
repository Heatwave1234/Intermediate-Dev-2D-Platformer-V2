using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock1Controller : MonoBehaviour
{
    //GOAL: Indicate a key and lock. When the key enters the lock,
    //      destroy the door.
    public GameObject key1;
    public GameObject lock1;
    public GameObject door1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Key1")
        {
            Debug.Log("Key in lock");
            Destroy(door1);
        }
    }
}
