using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeDoJogador = 5;
    private float momentum;
    public bool Jogador1;

    public float BordaInferior = -6f;
    public float BordaSuperior = 0.3f;
    
    void Update()
    {
        if(Jogador1 == true){//define qual método de movimentação será usado a depender de player é
            moverJogador1();
        }else{
            moverJogador2();
        }
        
    }

    private void moverJogador1()
    {//W e S para mover, só move se estiver dentro da área do jogo definida por borda superior e inferior
        if(Input.GetKey(KeyCode.W) && transform.position.y <= BordaSuperior)
        {
            momentum = velocidadeDoJogador/4;
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) && transform.position.y >= BordaInferior)
        {
            momentum = -velocidadeDoJogador/4;
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    private void moverJogador2()
    {//setas para cima e baixo para mover, só move se estiver dentro da área do jogo definida por borda superior e inferior
        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y <= BordaSuperior)
        {
            momentum = velocidadeDoJogador/4;
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow) && transform.position.y >= BordaInferior)
        {
            momentum = -velocidadeDoJogador/4;
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo){//ativa quando algo(sushi) colide no jogador
    Sushi sushi = FindFirstObjectByType<Sushi>();

        if(sushi.corpo.linearVelocity.magnitude < 30 ) //se não tiver passado do limite de velocidade incrmenta
            sushi.corpo.linearVelocity *= new Vector2(1.1f, 1);
        sushi.corpo.linearVelocity += new Vector2(0, momentum); // adiciona uma parte do momentum do jogador na bola
    }
}
