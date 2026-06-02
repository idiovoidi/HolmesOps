using UnityEngine;

// Ammo pickup - Adds ammo to the player's equipped weapon on contact.

public class AmmoPack : MonoBehaviour
{
    // Amount of ammo to give the player on pickup
    public int ammoAmount = 10;

    // Triggers when player enters
    private void OnTriggerEnter(Collider other)
    {
        // Only respond to player tag
        if (other.CompareTag("Player"))
        {
            // Adds ammo to the player's equipped weapon
            other.gameObject.GetComponent<Character>().equippedWeapon.AmmoPickup(ammoAmount);
            Debug.Log("Player picked up 10 ammo");

            // Remove from game
            Destroy(gameObject);
        }
    }
}
