using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coletor : MonoBehaviour
{
    int moedas = 0;

    [SerializeField] Text textoMoedinhas;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Moeda")){
            Destroy(other.gameObject);
            moedas++;
            textoMoedinhas.text = "Moedas: " + moedas;
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
