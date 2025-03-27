using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeController : MonoBehaviour
{
    public int nozes;
    public TextMeshProUGUI texto;
    public GameObject[] objectsToActivate;

    public AudioSource Eating;
    public AudioSource Storing;


    // Start is called before the first frame update
    void Start()
    {
        texto.text = ("Nozes: " + nozes);
    }


    public void GuardarNozes(int add)
    {   
        Storing.pitch = Random.Range(0.90f, 1.05f);
        Storing.Play();
        nozes += add;
        AtualizarObjetosAtivos();
    }

    public void GastarNozes(int sub)
    {
        Eating.Play();
        nozes -= sub;
        AtualizarObjetosAtivos();
    }

    public void AtualizarObjetosAtivos()
    {
        texto.text = ("Nozes: " + nozes);
    
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(i < nozes/5);
        }
    }
}
