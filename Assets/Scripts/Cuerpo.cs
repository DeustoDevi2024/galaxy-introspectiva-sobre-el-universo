using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cuerpo : MonoBehaviour
{

    [SerializeField] protected Cuerpo center;
    [SerializeField] protected float orbitalPeriod;
    [SerializeField] protected Vector3 axis = Vector3.up;
    protected float angularSpeed;

    public Cuerpo(Cuerpo center, float orbitalPeriod, Vector3 axis)
    {
        this.center = center;
        this.orbitalPeriod = orbitalPeriod;
        this.axis = axis;
        this.angularSpeed = (2 * Mathf.PI) / (orbitalPeriod / 1000000);
    }

    public virtual void Rotate()
    {
        if (center != null)
        {
            Debug.Log("Hola");
            transform.RotateAround(center.transform.position, axis, angularSpeed);
        }
        
    }

    protected virtual void Start()
    {
        calculateAngularSpeed();
    }

    protected virtual void Update()
    {
        Rotate();
        //Debug.Log("Hola");
    }

    protected void calculateAngularSpeed()
    {
        angularSpeed = (2 * Mathf.PI) / (orbitalPeriod / 1000000);
    }
}
