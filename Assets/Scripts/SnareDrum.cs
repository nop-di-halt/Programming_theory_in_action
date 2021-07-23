using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareDrum : Drum //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Snare Drum";
    }
    protected override void Play() //Abstraction
    {
        PlaySnareDrum();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Drum--> Snare Drum";
    }
    private void PlaySnareDrum()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
