using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnCtrl : ExtendBehaviour
{
    [SerializeField] List<EnemyCtrl> _enemyCtrls = new();
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        foreach(EnemyCtrl _enemyCtrl in this.GetComponentsInChildren<EnemyCtrl>())
        {
            _enemyCtrls.Add(_enemyCtrl);
        }
    }
}
