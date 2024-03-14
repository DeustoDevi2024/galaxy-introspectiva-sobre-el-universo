using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manageInput();
    }

    private void manageInput()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, transform.position.y, transform.position.z + Input.GetAxis("Vertical") * speed * Time.deltaTime);
        if (Input.GetKey("space"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
            transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"));
            //transform.rotation = Quaternion.Euler(transform.r)
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
