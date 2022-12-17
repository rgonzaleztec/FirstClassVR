using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionParticulas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem sistemaparticulas;





    public void OnPointerEnter()
    {
        sistemaparticulas.Play();
    }

    public void OnPointerExit()
    {
        sistemaparticulas.Stop();
    }




}
