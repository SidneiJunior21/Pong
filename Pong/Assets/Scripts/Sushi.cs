using Unity.VisualScripting;
using UnityEngine;

public class Sushi : MonoBehaviour
{
    public float Velocidade;
    public float randomizadorX;
    public float randomizadorY;

    private Rigidbody2D corpo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        corpo = GetComponent<Rigidbody2D>();//agr ele associa os 2 sozinhos, n precisa setar na unity
        mover();//so move uma vez no começo, o movimento é preservado ao decorrer do jogo
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void mover(){
        corpo.linearVelocity = new Vector2(Velocidade, Velocidade);//se move na diagonal superior esquerda(x e y positivos), alterar no futuro
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        corpo.linearVelocity += new Vector2(randomizadorX, randomizadorY);
    }
}