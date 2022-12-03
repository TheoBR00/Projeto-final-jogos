using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoFollow : MonoBehaviour
{
    [SerializeField] GameObject[] pontos;
    int pontoAtualIndex = 0;

    [SerializeField] float vel = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, pontos[pontoAtualIndex].transform.position) < .1f){
            pontoAtualIndex++;
            if(pontoAtualIndex >= pontos.Length){
                pontoAtualIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, pontos[pontoAtualIndex].transform.position, vel * Time.deltaTime);

    }
}
