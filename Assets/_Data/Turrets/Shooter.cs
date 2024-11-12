using UnityEngine;

public class Shooter : ExtendBehaviour
{
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
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.sphereSpawner.Spawn(this.transform.position);
        }
    }
}
