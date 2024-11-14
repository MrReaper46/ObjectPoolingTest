using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner<EnemyCtrl>
{
    [SerializeField] List<EnemySpawnCtrl> _enemySpawnCtrlList;
    [SerializeField] EnemySpawnCtrl _enemySpawnCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemySpawnCtrl();
    }
    protected virtual void LoadEnemySpawnCtrl()
    {
        if (this._enemySpawnCtrl != null) return;
        this._enemySpawnCtrl = this.transform.parent.GetComponentInChildren<EnemySpawnCtrl>();
    }
    protected virtual void AddEnenmySpawnCtrl()
    {

    }
}
