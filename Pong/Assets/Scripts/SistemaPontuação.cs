using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SistemaPontuação : MonoBehaviour
{//gerencia a pontuação de cada um dos jogadores, uma funçõa para aumentar a pontuação de cada um
    public int pontuacao1; 
    public int pontuacao2;

    public Text txtPont;
    public AudioSource som;
    public string cena1;
    public string cena2;

    void Start(){
        Cursor.visible = false;
        pontuacao1 = 0;
        pontuacao2 = 0;
        attPont();
        attFinal();
    }

    void Update(){
        
    }
  
    public void pontuarP1(){
        pontuacao1 += 1;
        attPont();
        som.Play();
        attFinal();
    }

    public void pontuarP2(){
        pontuacao2 += 1;
        attPont();
        som.Play();
        attFinal();
    }

    public void attPont(){
        txtPont.text = pontuacao1 + " : " + pontuacao2;
    }
    public void attFinal(){
        if (pontuacao1 == 5){
            SceneManager.LoadScene(cena1);  // Carregar cena1
        } else if (pontuacao2 == 5){
            SceneManager.LoadScene(cena2);
        }
    }
}
