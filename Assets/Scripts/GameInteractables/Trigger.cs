using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameEvent : UnityEvent<GameObject>
{}

public class Trigger : MonoBehaviour
{
    [SerializeField] private List<Collider> collidersList = new List<Collider>();

    [SerializeField] UnityEvent OnEnter;
    [SerializeField] UnityEvent OnExit;

    [SerializeField] GameEvent OnEnterGameObject;
    [SerializeField] GameEvent OnExitGameObject;

    public void OnTriggerEnter(Collider other)
    {
        collidersList.Add(other.GetComponent<Collider>());
        if (other.transform.parent.GetComponent<Player>())
            OnEnter?.Invoke();

        if (other.transform.parent.GetComponent<Player>())
            OnEnterGameObject?.Invoke(other.transform.parent.gameObject);
    }

    public void OnTriggerExit(Collider other)
    {
        collidersList.Remove(other.GetComponent<Collider>());
        int numOfPlayers = 0;
        foreach (Collider collider in collidersList)
            if (collider.transform.parent.GetComponent<Player>())
                numOfPlayers++;

        if (numOfPlayers == 0)
        {
            OnExit?.Invoke();
            OnExitGameObject?.Invoke(other.gameObject);
        }

    }

}
