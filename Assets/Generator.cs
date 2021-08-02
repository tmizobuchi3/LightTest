using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject tamaPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject tama = Instantiate(tamaPrefab, new Vector3(0, 3, 0), Quaternion.identity);
        tama.GetComponent<Rigidbody>().AddForce(Vector3.up);
    }

}

