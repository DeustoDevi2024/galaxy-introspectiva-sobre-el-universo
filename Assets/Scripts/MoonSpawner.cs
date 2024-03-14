using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonSpawner : MonoBehaviour
{

    public int numberOfMoons;
    public int offset;
    public float minPeriod;
    public float maxPeriod;
    public GameObject moonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfMoons; i++)
        {
            GameObject moon = Instantiate(moonPrefab, Vector3.zero, Quaternion.identity);
            moon.AddComponent(typeof(Luna));
            moon.GetComponent<Luna>().Center = GetComponent<Cuerpo>();
            moon.GetComponent<Luna>().OrbitalPeriod = Random.Range(minPeriod, maxPeriod);
            moon.GetComponent<Luna>().Axis = Random.insideUnitSphere.normalized;
            moon.transform.SetParent(transform);
            moon.transform.localPosition = Random.insideUnitSphere.normalized * offset; //Como marcar un radio mínimo o máximo
            Debug.Log("Position: " + moon.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
    }
}
