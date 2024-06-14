using UnityEngine;

public class Flame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Code pour less objets flammes, si l'inventaire est pas vide on prend la fonction FlameCollected et on désactive l'objet

        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.FlameCollected();
            gameObject.SetActive(false);
        }
    }
}