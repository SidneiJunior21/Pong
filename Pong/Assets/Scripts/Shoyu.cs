using UnityEngine;

public class Shoyu:MonoBehaviour{

     void OnTriggerEnter2D(Collider2D other){
          //vai para outro canto do mapa 
          mover();
          //acelera o sushi
          Sushi sushi = FindFirstObjectByType<Sushi>();
          sushi.corpo.linearVelocity = sushi.corpo.linearVelocity.normalized * 30;
     }

     public void mover(){
          int randomX = Random.Range(-6, 7);
          int randomY = Random.Range(-6, 4);

          transform.position = new Vector2(randomX, randomY);
     }
}