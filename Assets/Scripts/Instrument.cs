using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Instrument : MonoBehaviour
{
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected AudioClip sample;
    [SerializeField] protected Text info;
    protected string instrumentName;
    protected void OnMouseDown()
    {
        audioSource.PlayOneShot(sample, 1.0f);
    }
    protected abstract void DisplayInfo();
}
