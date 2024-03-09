using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour
{
    private GameObject sun;
    private Vector3 axis;
    public float period;
    private float angularSpeed;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Sun");
        axis = new Vector3(0, 1, 0);
        angularSpeed = (2 * Mathf.PI) / (period/1000000);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.transform.position, axis, angularSpeed);
    }
}
