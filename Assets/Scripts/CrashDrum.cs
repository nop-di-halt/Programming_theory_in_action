using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDrum : Drum //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Crash Drum";
    }

    protected override void Play() //Abstraction
    {
        PlayCrashDrum();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Drum--> Crash Drum";
    }
    private void PlayCrashDrum()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
