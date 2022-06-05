using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMeshColor : MonoBehaviour
{
    [SerializeField] Renderer objectToChangeTheColor;
    [SerializeField] Color finalColor;

    public void ChangeColor()
    {
        objectToChangeTheColor.material.color = finalColor;
    }
}
