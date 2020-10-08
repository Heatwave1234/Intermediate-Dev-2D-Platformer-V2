using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomChanger : MonoBehaviour
{
    //GOAL: When the player passes a the roomchanger trigger, a wall activates behind them.

    public GameObject wall;
    public BoxCollider2D wallCollider;
    public SpriteRenderer wallRenderer;
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
        if (collision.gameObject.tag == "Player")
        {
            wallCollider.enabled = true;
            wallRenderer.enabled = true;
        }
    }
}
