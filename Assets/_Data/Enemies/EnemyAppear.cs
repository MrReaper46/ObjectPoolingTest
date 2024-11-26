using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyAppear : ExtendBehaviour
{
    [SerializeField] private EnemyCtrl _enemyCtrl;
    private void Start()
    {
        Appear();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        if (this._enemyCtrl != null) return;
        this._enemyCtrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.LogWarning(this.gameObject.name + " Loaded EnemyCtrl", gameObject);
    }
    protected virtual void Appear()
    {
        _enemyCtrl.Rigidbody.AddForce(Vector3.up*10);
    }
}
