using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrudaPlataforma : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Jogador"){
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.name == "Jogador"){
            collision.gameObject.transform.SetParent(null);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
