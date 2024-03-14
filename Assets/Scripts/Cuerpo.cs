using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cuerpo : MonoBehaviour
{

    [SerializeField] protected float rotationPeriod;
    protected float rotationAngularSpeed;
    [SerializeField] protected GameObject realBody;


    public Cuerpo() { }

    public Cuerpo(int rotationPeriod)
    {
        this.rotationPeriod = rotationPeriod;
    }

    protected void RotateAroundSelf()
    {
        if(rotationPeriod != 0)
        {
            rotationAngularSpeed = (2 * Mathf.PI) / rotationPeriod;
            realBody.transform.localRotation *= Quaternion.Euler(0, 1 * rotationAngularSpeed * Time.deltaTime, 0);
        }
    }
}
