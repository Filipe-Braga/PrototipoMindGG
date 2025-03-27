using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NutsText : MonoBehaviour
{
    public float duracao = 1f; // Tempo antes de desaparecer
    public float velocidadeSubida = 2f; // Velocidade do movimento para cima
    private TextMeshProUGUI texto;
    private Color corOriginal;
    private float tempoAtual;


      void Awake()
    {
        texto = GetComponent<TextMeshProUGUI>();
        corOriginal = texto.color;
        gameObject.SetActive(false); 
    }

    public void ReceberNozes(int quantidade)
    {
        texto.text = ("+" + quantidade + " nozes"); 
        transform.localPosition = Vector3.zero; // Define a posição (0,0,0)
        texto.color = corOriginal; // Reseta a transparência
        tempoAtual = 0f;
        gameObject.SetActive(true); // Ativa o texto
    }


    void Update()
    {
         if (tempoAtual < duracao)
        {
            tempoAtual += Time.deltaTime;
            transform.position += Vector3.up * velocidadeSubida * Time.deltaTime;

            // Faz o texto desaparecer suavemente
            float alpha = Mathf.Lerp(1f, 0f, tempoAtual / duracao);
            texto.color = new Color(corOriginal.r, corOriginal.g, corOriginal.b, alpha);
        }
        else
        {
            gameObject.SetActive(false); // Desativa após 3 segundos
        }
    }
}
