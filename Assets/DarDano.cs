using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarDano : MonoBehaviour
{
    public int quantidadeDeDano = 1;

    void OnCollisionEnter(Collision bateu)
    {
        if (bateu.gameObject.GetComponent<Dano>())
        {
            bateu.gameObject.GetComponent<Dano>().TomarDano(quantidadeDeDano);
        }
    }
}
