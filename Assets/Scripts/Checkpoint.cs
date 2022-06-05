using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] Transform location;
    [SerializeField] int index;

    public Transform Location { get => location; }
    public int Index { get => index; }
    

    private void OnTriggerEnter (Collider other)
    {
        Player player = other.transform.parent.GetComponent<Player>();

        if (player != null)
        {
            if (player.LastCheckPoint == null)
            
                player.LastCheckPoint = this;
             else
            
                if (player.LastCheckPoint.Index < this.Index)
                    player.LastCheckPoint = this;
            
        }
    }
}
