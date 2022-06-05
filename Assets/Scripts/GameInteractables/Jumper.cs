using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

    [SerializeField] Vector3 forceDirection;
    [SerializeField] float force = 1f;
    [SerializeField] Collider collider;
    [SerializeField] LayerMask m_LayerMask;
    [SerializeField] Collider [ ] hitColliders;

    public void AddImpulse (GameObject other)
    {
        Debug.Log( "Adding Impulse" );
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            Debug.Log( "Adding Impulse to RB" );
            rigidbody.AddForce( force * Vector3.up, ForceMode.Impulse );
        }
    }

    [Button]
    public void AddImpulse ()
    {

        hitColliders = Physics.OverlapBox( gameObject.transform.position, transform.localScale / 2, Quaternion.identity, m_LayerMask );
        Player player;
        foreach (Collider collider in hitColliders)
        {
            if (collider.transform.parent != null)
            {
                player = collider.transform.parent.gameObject.GetComponent<Player>();
                if (player != null)
                    player.GetComponent<Rigidbody>().AddForce( force * forceDirection, ForceMode.Impulse );
            }

        }

        hitColliders = null;
    }

    void OnDrawGizmos ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine( transform.position, transform.position + forceDirection );
    }
}
