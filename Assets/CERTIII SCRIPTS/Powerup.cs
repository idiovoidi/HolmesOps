using UnityEngine;

public class Powerup : MonoBehaviour
{

    // Value of the Powerup's effect
    private int powerupValue = 25;
    // Seconds the powerup is active
    private int powerupLifetime = 15;
    
    /// YOU NEED A VARIABLE FOR THE AMOUNT YOU ARE CHANGING AND ONE FOR THE AMOUNT OF
    /// TIME THE POWERUP IS ACTIVE FOR (POWERUP DEPENDING) 
    /// set up an OnTriggerEnter function
    /// check if the collider has the "Player" tag
// Trigger for Character component
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Character>() != null)
        {
            // Adds overhealth to the Character, allowing health to exceed maximum
            collider.gameObject.GetComponent<Character>().ChangeCurrentHealth(PowerupValue);
            // Destroys object 
            Destroy(gameObject);
        }
    }
    /// if it does access:
    /// collider.gameObject.GetComponent<Character>() FOR CHARACTER POWERUPS
    /// collider.gameObject.GetComponent<Character>().equippedWeapon FOR WEAPON POWERUPS
    /// 
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
