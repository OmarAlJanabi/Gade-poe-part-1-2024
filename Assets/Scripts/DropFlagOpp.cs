using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFlagOpp : MonoBehaviour
{
    public GameObject flagPrefab;
    public GrabFlagOpp flagPickupScriptOp;

    // Method to drop the flag

    public void DropFlag()
    {
        if (GrabFlagOpp.instance.IsCarryingFlag() == true)
        {
          
            flagPrefab.SetActive(true);
            flagPickupScriptOp.RandomPickUp();
            
        }
    }
    // handles collision with the player

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerCharacter")
        {
         
            DropFlag();
        }
    }
}