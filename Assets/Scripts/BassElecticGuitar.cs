using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassElecticGuitar : Guitar //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = " Bass Electiric Guitar";
    }

    protected override void Play() //Abstraction
    {
        PlayBassGuitar();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Guitar--> Electric Bass Guitar";
    }
    private void PlayBassGuitar()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
