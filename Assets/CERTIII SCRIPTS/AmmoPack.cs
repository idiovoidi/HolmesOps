using UnityEngine;

// Ammo pickup - restores ammo to the player's equipped weapon on contact.
// Requires a Trigger Collider on this GameObject.
public class AmmoPack : MonoBehaviour
{
    // Amount of ammo to give the player on pickup
    public int ammoAmount = 10;

    // Triggers when player enters
    private void OnTriggerEnter(Collider other)
    {
        // Only respond to the player
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
