using System;
using UnityEngine;

public class BagOfHolding : MonoBehaviour
{

    public GameObject[] stuff = new GameObject[8];  
    int curSlot = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    public bool AddSomething(GameObject theThing)
    {
        if(curSlot >= stuff.Length)
        {
            Debug.Log("Bag of Holding is full!! Infinity does not exist unless you are a quantum mechanic, in a parallel universe");
            return false;
        }
        
        //check if the thing is another bag of holding, not allowed!!
        if( theThing.GetComponent<BagOfHolding>()  )  //if it has the bag of holding, no way, no how!
        {
            Debug.Log("Dude, what are you thinking, any GM does not allow this, unless they are a fool.");
            return false;
        }

        //otherwise, all cool
        stuff[curSlot] = theThing;

        //increment to the next slot
        curSlot++;

        return true;       
        
    }
}
