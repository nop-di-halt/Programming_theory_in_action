using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricGuitar : Guitar //Inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        Name = "Electric Guitar";
    }

    protected override void Play() //Abstraction
    {
        PlayElectricGuitar();
    }
    protected override void DisplayInfo() //Polymorphism
    {
        info.text = "Inheritance graph: Instrument--> Guitar--> Electric Guitar";
    }
    private void PlayElectricGuitar()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
}
