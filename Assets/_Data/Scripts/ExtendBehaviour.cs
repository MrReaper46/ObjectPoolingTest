using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ExtendBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        //For overide
    }
}
