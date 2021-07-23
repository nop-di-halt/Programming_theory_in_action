using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomDrum : Drum //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Tom Drum";
    }

    protected override void Play() //Abstraction
    {
        PlayTomDrum();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Drum--> Tom Drum";
    }
    private void PlayTomDrum()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
