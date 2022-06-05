using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZone : MonoBehaviour
{
    private bool isOn = false;
    [SerializeField] float windForce;
    [SerializeField] Vector3 windDirection;

    public Vector3 WindDirection { get => windDirection; }
    public bool IsOn { set => isOn =  value ; }

    private void OnTriggerStay (Collider other)
    {
        if (!isOn)
            return;

        Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = other.transform.parent.gameObject.GetComponent<Rigidbody>();

        if (rigidbody != null)
            rigidbody.AddForce( windForce * WindDirection );
    }

    void OnDrawGizmos ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine( transform.position, transform.position + windDirection );
    }


    public void TurnOn ()
    {
        isOn = true;
    }

    public void TurnOff ()
    {
        isOn = false;
    }
}
