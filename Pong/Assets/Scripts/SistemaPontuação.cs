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

    void Start(){//deixa o cursor invisivel e inicia as contagens com 0
        Cursor.visible = false;
        pontuacao1 = 0;
        pontuacao2 = 0;
        attPont();
    }
  
    public void pontuarP1(){//aumenta pontuação do jogador 1, e toca som
        pontuacao1 += 1;
        som.Play();
        attPont();
    }

    public void pontuarP2(){//aumenta pontuação do jogador 2, e toca som
        pontuacao2 += 1;
        som.Play();
        attPont();
    }

    public void attPont(){//atualiza o texto da pontuação e finaliza se alcançar 10
        txtPont.text = pontuacao1 + " : " + pontuacao2;
        if (pontuacao1 == 10)
            SceneManager.LoadScene(cena1);  
        if (pontuacao2 == 10)
            SceneManager.LoadScene(cena2);
        }
}
