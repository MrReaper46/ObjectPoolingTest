using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class PathCtrl : ExtendBehaviour
{
    [SerializeField] protected NavMeshSurface _navSurface;
    [SerializeField] protected Transform _spawnPoint;
    [SerializeField] protected Transform _despawnPoint;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadNavMeshSurface();
        this.LoadSpawnPoint();
        this.LoadDespawnPoint();
    }
    protected virtual void LoadNavMeshSurface()
    {
        if (_navSurface != null) return;
        _navSurface = GetComponent<NavMeshSurface>();
        Debug.LogWarning(this.gameObject.name + " Loaded NavMeshSurface", gameObject);
    }
    protected virtual void LoadSpawnPoint()
    {
        if (_spawnPoint != null) return;
        _spawnPoint = GameObject.Find("SpawnPoint").GetComponent<Transform>();
        Debug.LogWarning(this.gameObject.name + " Loaded SpawnPoint", gameObject);
    }
    protected virtual void LoadDespawnPoint()
    {
        if (_despawnPoint != null) return;
        _despawnPoint = GameObject.Find("DespawnPoint").GetComponent<Transform>();
        Debug.LogWarning(this.gameObject.name + " Loaded DespawnPoint", gameObject);
    }
}
