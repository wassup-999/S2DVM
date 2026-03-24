using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;
public class SmallEnemyAnget : MonoBehaviour
{
    public Transform Target;
    public NavMeshAgent agent;
    void Start()
    {
        GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if(!agent.hasPath)
        {
            print("No existe cmaino");
        }
        if(Target != null)
        {
            agent.SetDestination(Target.position);
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (agent.path == null) return;
        Vector3[] corners = agent.path.corners;
        for (int i = 0; i < corners.Length - 1; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 1]);
            Gizmos.DrawSphere(corners[i], 0.2f);
        }       
    }
}
