using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFlagPlayer : MonoBehaviour
{
    public GameObject flagPrefab;
    public GrabFlagPlayer flagPickupScriptPl;

    // Method to drop the flag
    public void DropFlag()
    {
        if (GrabFlagPlayer.instance.IsCarryingFlag() == true)
        {

            flagPrefab.SetActive(true);
            flagPickupScriptPl.RandomPickUp();

        }
    }

    // Handle collision with the opponent
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy")
        {
   
            DropFlag();
        }
    }
}
