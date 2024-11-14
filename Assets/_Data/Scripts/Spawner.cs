using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner<T> : ExtendBehaviour where T : ExtendBehaviour
{
    [SerializeField] protected SpawnCtrl _spawnCtrl;
    [SerializeField] protected SpawnCtrlList _spawCtrlList;
    [SerializeField] protected T _component;
    [SerializeField] protected List<T> _components = new();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSpawn();
    }
    protected virtual void LoadSpawn()
    {
        //For overide
    }
    protected virtual T GetSpawn()
    {

        return _component;
    }

}
