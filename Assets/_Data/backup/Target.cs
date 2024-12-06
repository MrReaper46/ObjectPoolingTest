using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : ExtendBehaviour
{
    [SerializeField] EnemyCtrl enemy;
    [SerializeField] GameObject turretRotator;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
        turretRotator = GameObject.Find("Top");
    }

    protected void LoadEnemyCtrl()
    {
        if (enemy != null) return;
        enemy = GameObject.Find("Enemy1").GetComponent<EnemyCtrl>();
    }

    private void FixedUpdate()
    {
        TrackingTarget();
    }

    private void TrackingTarget()
    {
        GameObject.Find("Top").transform.LookAt(enemy.transform.position);
    }
}
