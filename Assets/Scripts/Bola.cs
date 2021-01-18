using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidade;
    public Vector3 posicaoInicial;
    public bool emJogo = false;
    public AudioSource[] sons;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = posicaoInicial;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !emJogo)
        {
            emJogo = true;
            LancaBola();
        }
    }

    private void LancaBola()
    {
        Vector2 direcao = new Vector2(Random.Range(0.8f, 1f), Random.Range(-1f, 1f)).normalized;

        //Vector2 direcao = Quaternion.Euler(0, 0, Random.Range(0f, 360f)) * Vector2.right;
        //direcao = direcao.normalized;

        bool signal = Random.Range(0, 2) == 0;

        if (signal)
        {
            direcao = - direcao;
        }

        if (direcao == Vector2.zero)
        {
            Debug.Log("anao");
        }

        meuRigidbody.velocity = direcao * velocidade;
    }

    public void Reseta()
    {
        meuRigidbody.velocity = Vector2.zero;
        emJogo = false;
        Start();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int _rand = Random.Range(0,sons.Length);
        sons[_rand].Play();
    }


}
