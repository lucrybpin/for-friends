using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        Player player = other.transform.parent.GetComponent<Player>();

        if (player != null)
        {
            Debug.Log( "DeadZone Triggered" );
            player.Die();
        }
    }
}
