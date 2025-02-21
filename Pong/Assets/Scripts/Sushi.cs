using Unity.VisualScripting;
using UnityEngine;

public class Sushi : MonoBehaviour
{
    public float Velocidade;
    public float randomizadorX = 0.5f;

    public Rigidbody2D corpo;
    public AudioSource som;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        corpo = GetComponent<Rigidbody2D>();//agr ele associa os 2 sozinhos, n precisa setar na unity
        mover();//so move uma vez no começo, o movimento é preservado ao decorrer do jogo
    }

    public void mover(){
        float Xaleatorio = Random.Range(5, Velocidade);//gera um valor aleatorio para os componentes x e y
        float Yaleatorio = Random.Range(3, Velocidade);

        float rand = Random.Range(0, 4);//escolhe um caso aleatorio

        switch(rand){//os casos para 0,1,2,3 so respectivamente, x e y positivos, x e y negativos, x negativo e y negativo
            case 1:
                Xaleatorio = -Xaleatorio;
                Yaleatorio = -Yaleatorio;
                break;
            case 2:
                Xaleatorio = -Xaleatorio;
                break;
            case 3:
                Yaleatorio = -Yaleatorio;
                break;
            default:
                break;
        }

        corpo.linearVelocity = new Vector2(Xaleatorio, Yaleatorio);//se move na diagonal superior esquerda(x e y positivos), alterar no futuro
    }

    void OnCollisionEnter2D(Collision2D collisionInfo){//incrementa velocidadeX em um sentido aleatorio ao bater em algo, evita da bola ficar completamente vertical

        float rand = Random.Range(0, 2);

        if(rand == 0)
            corpo.linearVelocity += new Vector2(randomizadorX, 0);
        else
            corpo.linearVelocity -= new Vector2(randomizadorX, 0);

        som.Play();
    }
}