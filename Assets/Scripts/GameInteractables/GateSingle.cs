using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSingle : MonoBehaviour
{
    [SerializeField] Transform mesh;
    [SerializeField] float delta;
    [SerializeField] float time;

    float closedPosition;
    float openPosition;

    private void Awake()
    {
        delta = (delta == 0) ? 3f : delta;
        time = (time == 0) ? 1f : time;
        closedPosition  = mesh.transform.localPosition.y;
        openPosition    = closedPosition + delta;
    }

    public void Open()
    {
        mesh.DOLocalMoveY(openPosition, time);
    }

    public void Close()
    {
        mesh.DOLocalMoveY(closedPosition, time);
    }
}
