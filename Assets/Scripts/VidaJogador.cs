using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJogador : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Inimigo Body")){
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
        
    }

    void Morre(){
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MovementPlayer>().enabled = false;
        Invoke(nameof(LevelReload), 1.3f);
    }

    void LevelReload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
