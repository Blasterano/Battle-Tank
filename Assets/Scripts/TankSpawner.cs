using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tank;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tank, transform.position, Quaternion.identity);    
    }

}
