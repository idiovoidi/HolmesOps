using UnityEngine;

public class HealthPack : MonoBehaviour
{
    // Variable used to set amount of health added by the HealthPack upon pickup
    private int healthAdd = 10;

// Trigger for player tag
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Adds health to the Character's current Health
            other.gameObject.GetComponent<Character>().ChangeCurrentHealth(healthAdd);
            // Destroys object 
            Destroy(gameObject);
        }
    }
}
