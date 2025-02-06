using UnityEngine;

public class Sushi : MonoBehaviour
{
    public float Velocidade;

    public Rigidbody2D corpo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mover();//so move uma vez no começo, o movimento é preservado ao decorrer do jogo
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void mover(){
        corpo.linearVelocity = new Vector2(Velocidade, velocidade);//se move na diagonal superior esquerda(x e y positivos), alterar no futuro
    }
}
