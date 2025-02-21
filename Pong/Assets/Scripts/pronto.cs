using UnityEngine;
using UnityEngine.UI;


public class pronto : MonoBehaviour
{
    public Transform Pronto;
    public float tempo = 3;
    public Text texto;
    public GameObject obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){//inicia o tempo da ocntagem como 3
        tempo = 3;
    }

    // Update is called once per frame
    void Update(){
        if (tempo > 0){//se não tiver zerado o tempo ainda, diminui em um e amostra na tela
            tempo -= Time.deltaTime;
            DisplayTime(tempo);
        } else {//se tiver zerado o tempo inicia o jogo
            Pronto.gameObject.SetActive(false);
            ResumirObjeto();
        }

    }

    void DisplayTime(float timeToDisplay){//função para amostrar quantos segundos faltam em formato de texto na tela
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        texto.text = string.Format("{0}", seconds);
    }

    void ResumirObjeto(){//função para iniciar o jogo apos contagem
        obj.SetActive(true);
    }

}
