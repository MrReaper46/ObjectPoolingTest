using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : ExtendBehaviour
{
    [SerializeField] private EnemyCtrl _enemyCtrl;
    [SerializeField] private PathCtrl _pathCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
        this.LoadPathCtrl();
        Move();
    }
    
    protected virtual void LoadEnemyCtrl()
    {
        if (this._enemyCtrl != null) return;
        this._enemyCtrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.LogWarning(this.gameObject.name + " Loaded EnemyCtrl", gameObject);
    }
    protected virtual void LoadPathCtrl()
    {
        if (this._pathCtrl != null) return;
        this._pathCtrl = GameObject.Find("PathCtrl").GetComponent<PathCtrl>();
        Debug.LogWarning(this.gameObject.name + " Loaded EnemyCtrl", gameObject);
    }
    protected virtual void Move()
    {
        _enemyCtrl.Agent.SetDestination(_pathCtrl.DeSpawnPoint.position);
    }
}
