using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSingleton<T> : ExtendBehaviour where T : ExtendBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null) Debug.LogError("Singleton Instance has not been created!");
            return instance;
        }
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInstance();
    }
    protected void LoadInstance()
    {
        if(instance == null)
        {
            instance = this as T;
            return;
        }
        if (instance != this)
        {
            Debug.LogError("Another instance of SingletonExample already exists!");
            Destroy(gameObject);
        }
    }
}
