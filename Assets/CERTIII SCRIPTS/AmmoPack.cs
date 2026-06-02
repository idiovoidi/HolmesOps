using UnityEngine;

public class AmmoPack : MonoBehaviour
{
    public int AmmoCount

    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger");
        }
        Debug.Log(other.gameObject.name);
    }
    /// set up an OnTriggerEnter function
    /// check if the collider has the "Player" tag
    /// if it does access:
    /// collider.gameObject.GetComponent<Character>().equippedWeapon.AmmoPickup(yourAmount);
    /// make sure to delete the pack on pickup.
    /// 
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
