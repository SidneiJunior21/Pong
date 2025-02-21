using UnityEngine;

public class Wasabi:MonoBehaviour{
    
     void OnTriggerEnter2D(Collider2D other){
          //surge após 5 pontos

          // vai para outro ponto do mapa

          // ao ser tocado desacelera o sushi      
          Sushi sushi = FindFirstObjectByType<Sushi>();
          sushi.corpo.linearVelocity = sushi.corpo.linearVelocity.normalized * 7;
     }
}