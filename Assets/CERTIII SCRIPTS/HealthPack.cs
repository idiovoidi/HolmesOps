using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private int HealthAdd = 10;
    /// set up an OnTriggerEnter function
    /// check if the collider has the "Player" tag
    /// if it does access:
    /// collider.gameObject.GetComponent<Character>().ChangeCurrentHealth(yourAmount);
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
