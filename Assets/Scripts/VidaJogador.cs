using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJogador : MonoBehaviour
{

    bool morto = false;

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Inimigo Body")){
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<MovementPlayer>().enabled = false;
            Morre();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1f && !morto){
            Morre();
        }
        
    }

    void Morre(){
        Invoke(nameof(LevelReload), 1.3f);
        morto = true;
    }

    void LevelReload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
