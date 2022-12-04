using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaciona : MonoBehaviour
{
    [SerializeField] float vx;
    [SerializeField] float vy;
    [SerializeField] float vz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * vx * Time.deltaTime, 360 * vy * Time.deltaTime, 360 * vz * Time.deltaTime);
        
    }
}
