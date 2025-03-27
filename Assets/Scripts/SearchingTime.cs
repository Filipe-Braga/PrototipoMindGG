using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchingTime : MonoBehaviour
{
    public Slider slider; 
    public float tempoTotal = 10f; // Tempo para a barra esvaziar
    private float tempoRestante;
    public NutsText Mensagem;
    public HomeController homeController;    
    public int nozesPorBusca = 5;



    void OnEnable()
    {
        tempoRestante = tempoTotal;
        slider.maxValue = tempoTotal; 
        slider.value = tempoTotal; 
    }

    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            AtualizarBarra();
        }
        else
        {
            homeController.GuardarNozes(nozesPorBusca);
            Mensagem.ReceberNozes(nozesPorBusca);
            this.enabled = false;
        }
    }

    void AtualizarBarra()
    {
        slider.value = Mathf.Clamp(tempoRestante, 0, tempoTotal);
    }

    public void ResetarTempo()
    {
        tempoRestante = tempoTotal;
        AtualizarBarra();
    }
}
