using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Drum : Instrument
{
   public string DrumName
    {
        get { return instrumentName; }
        set
        {
            if(!value.Contains("Drum"))
            {
                Debug.Log("The name should contain the word 'Drum'!");
            }
            else
            {
                instrumentName = value;
            }
        }
    }
}
