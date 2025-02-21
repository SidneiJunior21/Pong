using UnityEngine;

public class Shoyu:MonoBehaviour{

     public AudioSource som;

     void OnTriggerEnter2D(Collider2D other){
          //vai para outro canto do mapa 
          mover();
          som.Play();
          //acelera o sushi
          Sushi sushi = FindFirstObjectByType<Sushi>();
          sushi.corpo.linearVelocity = sushi.corpo.linearVelocity.normalized * 30;
     }

     public void mover(){//da uma posição aleatoria dentro da mesa
          int randomX = Random.Range(-6, 7);
          int randomY = Random.Range(-6, 4);
          
          transform.position = new Vector2(randomX, randomY);
     }
}