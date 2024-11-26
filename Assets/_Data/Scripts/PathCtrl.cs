using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class PathCtrl : ExtendBehaviour
{
    [SerializeField] protected Transform _spawnPoint;
    public Transform SpawnPoint => _spawnPoint;
    [SerializeField] protected Transform _despawnPoint;
    public Transform DeSpawnPoint => _despawnPoint;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPoint();
        this.LoadDespawnPoint();
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
