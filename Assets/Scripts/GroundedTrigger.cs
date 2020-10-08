using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedTrigger : MonoBehaviour
{
    public PlayerController myPlayer; //connects the 2 scripts

    private void OnTriggerStay2D(Collider2D activator)
    {
        myPlayer.grounded = true;
    }

    private void OnTriggerExit2D(Collider2D activator)
    {
        myPlayer.grounded = false;
    }
}
