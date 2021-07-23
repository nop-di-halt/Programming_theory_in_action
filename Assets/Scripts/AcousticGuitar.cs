using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcousticGuitar : Guitar //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Acoustic Guitar";
    }
    protected override void Play() //Abstraction
    {
        PlayAcousticGuitar();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Guitar--> Acoustic Guitar";
    }
    private void PlayAcousticGuitar()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
