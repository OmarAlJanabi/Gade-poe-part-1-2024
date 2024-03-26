using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFlagOpp : MonoBehaviour
{
    public static GrabFlagOpp instance;
    public GameObject flag;
    private bool carryingFlagOpp = false;


    void Awake()
    {
        instance = this;
    }
    //makes flag innactive when touching it
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy" && !carryingFlagOpp)
        {
       
            carryingFlagOpp = true;
            flag.SetActive(false);
        }
    }
    //removes flag from opponent when it touches base, reactivates flag
   public void RemoveFlag()
    {
        carryingFlagOpp = false;
        flag.SetActive(true);

    }
    //method for when the opponent drops the flag
    public void RandomPickUp()
    {
        carryingFlagOpp = false;
    }
    //shows if opponent is carrying a flag or not
    public bool IsCarryingFlag()
    {
        return carryingFlagOpp;
    }


}