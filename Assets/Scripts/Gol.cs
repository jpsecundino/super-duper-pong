using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golAzul;
    public Placar p;
    public Bola b;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (golAzul)
        {
            p.GolAzul();
        }
        else
        {
            p.GolRosa();
        }

        b.Reseta();
    }
}
