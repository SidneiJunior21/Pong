using UnityEngine;

public class Jogadores : MonoBehaviour
{
    public float velocidadeDoJogador;
    public bool Jogador1;
    
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
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
    private void moverJogador2()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
