using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeDoJogador = 5;
    private float momentum;
    public bool Jogador1;

    public float BordaInferior = -5.3f;
    public float BordaSuperior = 2.25f;
    
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
    private void moverJogador1()
    {//W e S para mover, só move se estiver dentro da área do jogo
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
    {//setas para cima e baixo para mover, só move se estiver dentro da área do jogo
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

    void OnCollisionEnter2D(Collision2D collisionInfo){
        if(FindFirstObjectByType<Sushi>().corpo.linearVelocity.magnitude < 30 )
            FindFirstObjectByType<Sushi>().corpo.linearVelocity *= new Vector2(1.1f, 0);
        FindFirstObjectByType<Sushi>().corpo.linearVelocity += new Vector2(0, momentum);
    }
}
