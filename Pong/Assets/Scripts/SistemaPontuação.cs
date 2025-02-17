using UnityEngine;
using UnityEngine.UI;

public class SistemaPontuação : MonoBehaviour
{//gerencia a pontuação de cada um dos jogadores, uma funçõa para aumentar a pontuação de cada um
    public int pontuacao1; 
    public int pontuacao2;

    public Text txtPont;
    public AudioSource som;

    void Start(){
        Cursor.visible = false;
        pontuacao1 = 0;
        pontuacao2 = 0;
        attPont();
    }

    void Update(){
        
    }
  
    public void pontuarP1(){
        pontuacao1 += 1;
        attPont();
        som.Play();
    }

    public void pontuarP2(){
        pontuacao2 += 1;
        attPont();
        som.Play();
    }

    public void attPont(){
        txtPont.text = pontuacao1 + " : " + pontuacao2;
    }
}
