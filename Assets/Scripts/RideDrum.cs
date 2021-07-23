using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideDrum : Drum //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Ride Drum";
    }
    protected override void Play() //Abstraction
    {
        PlayRideDrum();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Drum--> Ride Drum";
    }
    private void PlayRideDrum()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
