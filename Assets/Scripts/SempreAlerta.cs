using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SempreAlerta : MonoBehaviour
{
    public SearchingTime searchingTime;
    public HomeController homeController;
    [SerializeField] private int preco = 10;
    public TextMeshProUGUI texto;
    public bool alertaAtivo = false;
    public SearchingTime scriptParaAtivar; 

    public int max = 1;
    public Button button;
    
    
    void Start()
    {
        texto.text = (preco + " N$");
    }
    public void sempreAlerta(){

        if(homeController.nozes >= preco){        
            max--;
            homeController.GastarNozes(preco);
            alertaAtivo = true;

            VerificarBotao();
        }
    }

    void Update()
    {
        if(alertaAtivo && scriptParaAtivar != null){
            scriptParaAtivar.enabled = true;
        }
    }

    private void VerificarBotao()
    {
        button.interactable = max > 0;
    }


}
