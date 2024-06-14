using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameSP : MonoBehaviour
{
    // Spawn des flammes on commence avec la liste des points on donne un nombre à l'item de 0 jusqu'a la fin de la liste des spawn
    // on transforme la position de l'objet du feu à une position random

    public GameObject[] listOfPoints;
    void Start()
    {
        int luckNumber = Random.Range(0, listOfPoints.Length);
        this.transform.position = listOfPoints[luckNumber].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
