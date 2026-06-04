using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private int HealthAdd = 10;

// Trigger for player tag
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Adds health to the Character's current Health
            other.gameObject.GetComponent<Character>().ChangeCurrentHealth(HealthAdd);
            // Destroys object 
            Destroy(gameObject);
        }
    }
}
