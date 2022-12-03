using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jump = 5f;
    [SerializeField] Transform chaoCheck;
    [SerializeField] LayerMask chao;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, verticalInput * speed);

        if(Input.GetButtonDown("Jump") && IsGround()){
            Pula();
        }
        
    }

    void Pula(){
        rb.velocity = new Vector3(rb.velocity.x, jump, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Inimigo Cabeca")){
            Destroy(collision.transform.parent.gameObject);
            Pula();
        }
    }

    
    bool IsGround()
    {
        return Physics.CheckSphere(chaoCheck.position, 0.1f, chao);
    }
    
}
