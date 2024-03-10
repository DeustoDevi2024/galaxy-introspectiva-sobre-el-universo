using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cuerpo : MonoBehaviour
{

    [SerializeField] protected int rotationPeriod;
    protected int rotationAngularSpeed;

    public Cuerpo() { }

    public Cuerpo(int rotationPeriod)
    {
        this.rotationPeriod = rotationPeriod;
        calculateRotationAngularSpeed();
    }

    protected void calculateRotationAngularSpeed()
    {
        
    }
}
