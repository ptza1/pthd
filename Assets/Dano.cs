using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int HP = 10;

    public void TomarDano(int quantidade)
    {
        HP -= quantidade;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
