using UnityEngine;
using TMPro;

// text de l'inventaire, met un texte intéractif qui s'update quand le joueur attrape un objet

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI FlameText;

    void Start()
    {
        FlameText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFlameText(PlayerInventory playerInventory)
    {
        FlameText.text = playerInventory.NumberOfFlame.ToString();
    }
}