using UnityEngine;
using UnityEngine.AI;

public class AgenteMovimiento : MonoBehaviour
{
    public Transform destino;

    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.SetDestination(destino.position);
    }
}
