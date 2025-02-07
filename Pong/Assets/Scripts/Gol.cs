using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golP1;

    void OnTriggerEnter2D(Collider2D other){//função ativdada ao entrar em trigger(as areas de colisão do gol)
        
        if(golP1 == true){//se for gol no gol do jogador 1, aumenta  a pontuação do jogador 2 e reseta posição da bolinha
            FindFirstObjectByType<SistemaPontuação>().pontuarP2();
            other.gameObject.transform.position = Vector2.zero;
        }else{//se for gol no gol do jogador 2, aumenta  a pontuação do jogador 1 e reseta posição da bolinha
            FindFirstObjectByType<SistemaPontuação>().pontuarP1();
            other.gameObject.transform.position = Vector2.zero;
        }

    }
}
