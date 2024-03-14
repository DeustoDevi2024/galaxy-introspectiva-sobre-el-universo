using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : Cuerpo
{
    [SerializeField] protected Cuerpo center;
    [SerializeField] private float orbitalPeriod;
    [SerializeField] private Vector3 axis = Vector3.up;
    protected float angularSpeed;

    public Cuerpo Center { get => center; set => center = value; }
    public float OrbitalPeriod { get => orbitalPeriod; set => orbitalPeriod = value; }
    public Vector3 Axis { get => axis; set => axis = value; }

    public Planeta()
    {
        center = null;
        orbitalPeriod = 0;
        axis = Vector3.zero;
        angularSpeed = 0;
    }

    public Planeta(Cuerpo center, float orbitalPeriod, Vector3 axis, int rotationPeriod) : base(rotationPeriod)
    {
        this.center = center;
        this.orbitalPeriod = orbitalPeriod;
        this.axis = axis;
        calculateAngularSpeed();
    }

    public virtual void Rotate()
    {
        if (center != null)
        {
            transform.RotateAround(center.transform.position, axis, angularSpeed * Time.deltaTime);
        }

    }

    protected virtual void Start()
    {
        calculateAngularSpeed();
    }

    protected virtual void Update()
    {
        Rotate();
        RotateAroundSelf();
    }

    protected void calculateAngularSpeed()
    {
        angularSpeed = (2 * Mathf.PI) / (orbitalPeriod / 1000000);
    }
}
