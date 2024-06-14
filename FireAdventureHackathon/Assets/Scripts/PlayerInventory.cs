using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// inventaire : on ajoute les flammes lorsque il y a une collision

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfFlame { get; private set; }

    public UnityEvent<PlayerInventory> OnFlameCollected;

    public void FlameCollected()
    {
        NumberOfFlame++;
        OnFlameCollected.Invoke(this);

        if(NumberOfFlame==3)
        {
            SceneManager.LoadScene(2);
        }
    }

        void OnTriggerEnter(Collider touch)
    {
        if (touch.gameObject.name == "Flame")
        {
            touch.gameObject.SetActive(false);
            FlameCollected();
        }
    }
}