using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFlagPlayer : MonoBehaviour
{
    public static GrabFlagPlayer instance;
    public GameObject flag;
    private bool carryingFlagPl = false;

    void Awake()
    {
        instance = this;
    }

    //makes flag innactive when touching it

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerCharacter" && !carryingFlagPl)
        {
            carryingFlagPl = true;
            flag.SetActive(false);
            
        }
       
    }
    //shows if player is carrying a flag or not

    public bool IsCarryingFlag()
    {
       
        return carryingFlagPl;
    }
    //method for when the player drops the flag

    public void RandomPickUp()
    {
        carryingFlagPl = false;
    }
    //removes flag from opponent when it touches base, reactivates flag

    public void RemoveFlag()
    { 
        carryingFlagPl = false;
        flag.SetActive(true);

    }
    

}