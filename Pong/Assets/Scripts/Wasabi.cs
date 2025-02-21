using UnityEngine;

public class Wasabi:MonoBehaviour{
    
     void OnTriggerEnter2D(Collider2D other){
          // vai para outro ponto do mapa
          mover();
          // ao ser tocado desacelera o sushi      
          Sushi sushi = FindFirstObjectByType<Sushi>();
          sushi.corpo.linearVelocity = sushi.corpo.linearVelocity.normalized * 7;
     }

     public void mover(){//da uma posição aleatoria na mesa
          int randomX = Random.Range(-6, 7);
          int randomY = Random.Range(-6, 4);

          transform.position = new Vector2(randomX, randomY);
     }
}