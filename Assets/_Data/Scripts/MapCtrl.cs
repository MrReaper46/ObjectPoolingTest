using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class MapCtrl : ExtendBehaviour
{
    [SerializeField] protected NavMeshSurface _navSurface;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadNavMeshSurface();
    }
    protected virtual void LoadNavMeshSurface()
    {
        if (_navSurface != null) return;
        this._navSurface = GetComponent<NavMeshSurface>();
        Debug.LogWarning(this.gameObject.name + " Loaded NavMeshSurface", gameObject);
    }
}
