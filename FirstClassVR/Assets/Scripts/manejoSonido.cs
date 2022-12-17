using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manejoSonido : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource fuenteSonido;




    public void OnPointerEnter()
    {
        fuenteSonido.Play();
    }

    public void OnPointerExit()
    {
        fuenteSonido.Stop();
    }

    public void OnPointerClick()
    {
        ///
    }



}
