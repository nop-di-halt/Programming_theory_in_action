using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Guitar : Instrument
{
    public string GuitarName
    {
        get { return instrumentName; }
        set
        {
            if(!value.Contains("Guitar"))
            {
                Debug.Log("The name should contain the word 'Guitar'!");
            }
            else
            {
                instrumentName = value;
            }
        }
    }
}
