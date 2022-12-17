using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class manejoAudio : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioSource audioFuente;
  

    public void OnPointerEnter()
    {

        audioFuente.Play();

    }

    public void OnPointerExit()
    {
        audioFuente.Stop();
    }

    public void OnPointerClick()
    {
        ////
    }
}
