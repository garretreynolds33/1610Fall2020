using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehaviour : MonoBehaviour
{
 private NavMeshAgent agent;
 public Transform player;

 private void Start()
 {
  agent = GetComponent<NavMeshAgent>();
 }

 private void Update()
 {
  agent.destination = player.position;
 }
}
