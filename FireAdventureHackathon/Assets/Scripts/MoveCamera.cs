using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// mouvement de la caméra, on change l'emplacement de la caméra à la nouvel position

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
