using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem particle;

    public void OnClick()
    {
         particle.Play();
    }
}
