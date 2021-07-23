using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Instrument : MonoBehaviour
{
    protected AudioSource audioSource;
    [SerializeField] protected AudioClip sample;
    [SerializeField] protected Text info;
    protected string instrumentName;

    protected abstract void Play();
    protected abstract void DisplayInfo();

    protected void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DisplayInfo();
    }
    protected void OnMouseDown()
    {
        Play();
    }
    protected void OnMouseEnter()
    {
        info.gameObject.SetActive(true);
    }
    protected void OnMouseExit()
    {
        info.gameObject.SetActive(false);
    }
}
