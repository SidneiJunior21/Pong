using UnityEngine;

public class Shoyu:MonoBehaviour{
    
     void OnTriggerEnter2D(Collider2D other){
          //surge após 5 pontos 
          
          // ao entrar em contato vai para outro canto do mapa 

          //  acelera o sushi
          Sushi sushi = FindFirstObjectByType<Sushi>();
          sushi.corpo.linearVelocity = sushi.corpo.linearVelocity.normalized * 30;
     }
}