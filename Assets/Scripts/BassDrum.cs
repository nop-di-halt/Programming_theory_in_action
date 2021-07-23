using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassDrum : Drum //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Bass Drum"; 
    }
    protected override void Play() //Abstraction
    {
        PlayBassDrum();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Drum--> Bass Drum";
    }
    private void PlayBassDrum()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
