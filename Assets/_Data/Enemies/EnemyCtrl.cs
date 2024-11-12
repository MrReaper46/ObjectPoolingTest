using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : ExtendBehaviour
{
    [SerializeField] protected NavMeshAgent _agent;
    [SerializeField] protected Collider _collider;
    [SerializeField] protected Rigidbody _rb;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCollider();
        this.LoadNavMeshAgent();
        this.LoadRigidBody();
    }
    protected virtual void LoadCollider()
    {
        if (_collider != null) return;
        _collider = GetComponentInChildren<Collider>();
        Debug.LogWarning(this.gameObject.name + " Loaded Collider", gameObject);
    }
    protected virtual void LoadRigidBody()
    {
        if (_rb != null) return;
        _rb = GetComponentInChildren<Rigidbody>();
        Debug.LogWarning(this.gameObject.name + " Loaded RigidBody", gameObject);
    }
    protected virtual void LoadNavMeshAgent()
    {
        if (_agent != null) return;
        _agent = GetComponent<NavMeshAgent>();
        Debug.LogWarning(this.gameObject.name + " Loaded NavMeshAgent", gameObject);
    }
}
