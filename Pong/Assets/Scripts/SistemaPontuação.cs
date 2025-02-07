using UnityEngine;

public class SistemaPontuação : MonoBehaviour
{//gerencia a pontuação de cada um dos jogadores, uma funçõa para aumentar a pontuação de cada um
    public int pontuacao1; 
    public int pontuacao2;
  
    public void pontuarP1(){
        pontuacao1 += 1;
    }

    public void pontuarP2(){
        pontuacao2 += 1;
    }
}
