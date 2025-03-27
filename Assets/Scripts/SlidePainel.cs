using System.Collections;
using UnityEngine;

public class SlidePainel : MonoBehaviour
{
    public GameObject painel;
    public float duracao = 1f; // Tempo da animação em segundos
    public bool emTela = false;

    public void puxaGalho()
    {


        if (emTela)
            StartCoroutine(MoverPainel(510));
        else
            StartCoroutine(MoverPainel(230));
    }

    private IEnumerator MoverPainel(int z)
    {
        Vector3 posicaoInicial = painel.transform.localPosition;
        Vector3 posicaoFinal = new Vector3(z, 0, 0);
        float tempoDecorrido = 0f;

        while (tempoDecorrido < duracao)
        {
            tempoDecorrido += Time.deltaTime;
            float t = tempoDecorrido / duracao;
            painel.transform.localPosition = Vector3.Lerp(posicaoInicial, posicaoFinal, t);
            yield return null;
        }

        painel.transform.localPosition = posicaoFinal;
        emTela = !emTela;
    }
}
