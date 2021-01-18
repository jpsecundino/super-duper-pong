using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Placar : MonoBehaviour
{

    public TextMeshProUGUI placarAzul;
    public TextMeshProUGUI placarRosa;

    public int golsAzul;
    public int golsRosa;

    // Start is called before the first frame update
    void Start()
    {
        golsAzul = golsRosa = 0;
        placarAzul.text = "0";
        placarRosa.text = "0";
    }

    public void GolAzul()
    {
        golsAzul++;
        placarRosa.text = golsAzul.ToString();
    }

    public void GolRosa()
    {
        golsRosa++;
        placarAzul.text = golsRosa.ToString();
    }
}
