using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bochechas : MonoBehaviour // Esse script, assim como os outros de compra poderiam ser modularizados para evitar uso de código repetido
{
    public SearchingTime searchingTime;
    public HomeController homeController;
    [SerializeField] private int preco = 10;
    public TextMeshProUGUI texto;
    public int max = 5;
    public Button button;

    void Start()
    {
        texto.text = (preco + " N$");
    }
    

    public void aumentarBochechas(){

        if(homeController.nozes >= preco){ 
            atualizarPreco();

            searchingTime.nozesPorBusca = searchingTime.nozesPorBusca + 1;
            homeController.AtualizarObjetosAtivos();

            VerificarBotao();
        }
    }

    private void atualizarPreco(){
        max--;
        homeController.GastarNozes(preco);
        preco = preco + 5;

        texto.text = ( preco + " N$"); 

    }

    private void VerificarBotao()
    {
        button.interactable = max > 0;
    }
}
