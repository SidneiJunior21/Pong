using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeDoJogador;
    public bool Jogador1;

    public float BordaInferior;
    public float BordaSuperior;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jogador1 == true)
        {
            moverJogador1();
        }else{moverJogador2();}
        
    }
    private void moverJogador1()//verificar se não existe outro jeito de limitar o player mais tarde
    {//W e S para mover, só move se estiver dentro da área do jogo
        if(Input.GetKey(KeyCode.W) && transform.position.y <= BordaSuperior)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) && transform.position.y >= BordaInferior)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
    private void moverJogador2()
    {//setas para cima e baixo para mover, só move se estiver dentro da área do jogo
        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y <= BordaSuperior)
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow) && transform.position.y >= BordaInferior)
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
