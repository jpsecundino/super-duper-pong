using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlataforma : MonoBehaviour
{
    public bool plataformaAzul = false;
    public float velocidade = 5f;
    public Rigidbody2D meuRigidbody2D;
    
    // Update is called once per frame
    void Update()
    {
        
        if(plataformaAzul == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.up;
            }
            else if(Input.GetKey(KeyCode.S))
            {
                meuRigidbody2D.velocity =  velocidade * Vector2.down;
            }
            else
            {
                meuRigidbody2D.velocity = Vector2.zero;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.down;
            }
            else
            {
                meuRigidbody2D.velocity = Vector2.zero;
            }
        }


    }
}
