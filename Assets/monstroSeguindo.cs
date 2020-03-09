using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class monstroSeguindo : MonoBehaviour
{
    NavMeshAgent agente;

    public Transform player;

    public Image imagem1;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agente.SetDestination(player.position);
    }

    void PegarPlayer()
    {
        imagem1.enabled = true;
        Debug.Log("Peguei");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Toquei Em Algo");
        if (collision.gameObject.GetComponent<movimentoPlayer>())
        {
            PegarPlayer();
        }
    }
}
