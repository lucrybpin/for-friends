using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbine : MonoBehaviour
{
    [SerializeField] bool startTurnedOn = true;
    [SerializeField] bool isOn = false;

    [SerializeField] WindZone windZone;

    [SerializeField] Transform helix;

    [SerializeField] float baseSpeed;
    [SerializeField] float currentSpeed;

    private void Start ()
    {
        if (startTurnedOn)
            TurnOn();
    }

    private void Update ()
    {
        RotateHelix();
    }

    private void RotateHelix ()
    {
        helix.transform.Rotate( 0f, 0f, - 700f * currentSpeed * Time.deltaTime );
    }

    [ContextMenu("Turn On")]
    public void TurnOn()
    {
        isOn = true;
        windZone.TurnOn();
        StartCoroutine( LerpSpeed( 1f, baseSpeed ) );
    }

    [ContextMenu( "Turn Off" )]
    public void TurnOff ()
    {
        isOn = false;
        windZone.TurnOff();
        StartCoroutine( LerpSpeed( 1f, 0f ) );
    }

    private IEnumerator LerpSpeed(float totalTime, float desiredSpeed)
    {
        yield return null;
        float elapsedTime = 0f;

        while (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            currentSpeed = Mathf.Lerp( currentSpeed, desiredSpeed, elapsedTime / totalTime );
            yield return null;
        }
        currentSpeed = desiredSpeed;
    }
}
