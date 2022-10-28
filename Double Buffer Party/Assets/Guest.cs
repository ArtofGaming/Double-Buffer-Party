using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guest
{
    public string ladyName;
    public Guest()
    {
        currentTalking = false;
    }
    public bool currentTalking;
    public bool nextTalking;
    public virtual void update() { }

    public void Swap()
    {
        currentTalking = nextTalking;
        nextTalking = false;
    }

    /*public void Reset()
    {
        talking = false;
    }*/
    public void Talk()
    {
        nextTalking = true;
        //Debug.Log( " is talking");
    }
    bool wasTalking()
    {
        Debug.Log(currentTalking);
        return currentTalking;
    }


}
