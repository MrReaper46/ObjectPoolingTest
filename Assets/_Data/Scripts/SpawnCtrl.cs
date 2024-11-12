using UnityEngine;

public class SpawnCtrl : ExtendBehaviour
{
    [SerializeField] protected float spawnLifetime = 2f;
    [SerializeField] protected float spawnLifetimeCur;
    [SerializeField] protected bool isActive = false;
    [SerializeField] protected SphereSpawner sphereSpawner;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawner();
    }
    protected virtual void LoadSpawner()
    {
        sphereSpawner = GameObject.Find("Spawner").GetComponent<SphereSpawner>();
    }
    private void FixedUpdate()
    {
        if (isActive) return;
        if (this.transform.parent.name == "SpawnDummies") return;
        this.spawnLifetimeCur -= Time.fixedDeltaTime;
        if (this.spawnLifetimeCur > 0) return;
        sphereSpawner.Despawn(this.gameObject);
        this.spawnLifetimeCur = this.spawnLifetime;
    }
}
