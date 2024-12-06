using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : ExtendBehaviour
{
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected int spawnCountMax = 10;
    [SerializeField] protected Queue<GameObject> bulletPool = new();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletPrefabs();
    }
    protected void Start()
    {
        Invoke("LoadBulletQueue", 1f);
    }
    
    protected virtual void LoadBulletPrefabs()
    {
        if (bulletPrefab != null) return;
        bulletPrefab = Resources.Load<GameObject>("_prefabs/Sphere");
        Debug.Log(Resources.Load<GameObject>("_prefabs/Sphere"));
    }

    protected virtual void LoadBulletQueue()
    {
        for (int i = 0; i < spawnCountMax; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            bulletPool.Enqueue(obj);
        }
    }

}
