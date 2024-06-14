using UnityEngine;

// 

public class PositionManager : MonoBehaviour
{
    public GameObject objectToMove;  // L'objet que vous souhaitez déplacer
    public Transform[] positions;    // Tableau de positions (Empty GameObjects)

    void Start()
    {
        MoveObjectToRandomPosition();
    }

    public void MoveObjectToPosition(int index)
    {
        if (index >= 0 && index < positions.Length)
        {
            objectToMove.transform.position = positions[index].position;
        }
        else
        {
            Debug.LogError("Index de position hors limites !");
        }
    }

    public void MoveObjectToRandomPosition()
    {
        int randomIndex = Random.Range(0, positions.Length);
        MoveObjectToPosition(randomIndex);
    }
}
