using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : ExtendBehaviour
{
    [SerializeField] GameObject spawnPrefab;
    [SerializeField] int spawnCount = 10;
    [SerializeField] List<GameObject> spawnPool = new();

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPrefab();
    }
    protected override void Awake()
    {
        base.Awake();
        this.LoadSpawn();
    }

    protected void LoadSpawnPrefab()
    {
        if (spawnPrefab != null) return;
        spawnPrefab = GameObject.Find("Sphere");
    }

    protected void LoadSpawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(spawnPrefab, this.transform);
            obj.SetActive(false);
            spawnPool.Add(obj);
        }
    }

    public virtual GameObject Spawn(Vector3 spawnLocation)
    {
        if (spawnPool.Count <= 0) return null;
        foreach (Transform spawn in transform)
        {
            if (!spawn.gameObject.activeInHierarchy)
            {
                spawn.gameObject.SetActive(true);
                spawnPool.Remove(spawn.gameObject);
                return spawn.gameObject;
            }
            spawn.position = spawnLocation;
        }
        return null;
    }

    public virtual void Despawn (GameObject spawn)
    {
        spawn.SetActive(false);
        spawnPool.Add(spawn);
    }
}
