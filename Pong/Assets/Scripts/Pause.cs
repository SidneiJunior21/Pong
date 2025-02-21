using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Transform pause;
    public GameObject pronto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))//ao pressionar a tecla esc
        {
            if(pause.gameObject.activeSelf){// se estiver pausado, retorna ao jogo
                pause.gameObject.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                pronto.gameObject.SetActive(true);
            }
            else{//se não estiver pausado, pausa
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                if(pronto.gameObject.activeSelf){
                    pronto.gameObject.SetActive(false);
                };
            };
        }
    }

    public void LoadScenes(string cena){//carrega cena passada como string, volta ao timescale 1, havia sido passado para 0 ao pausar
        Time.timeScale = 1;
        SceneManager.LoadScene(cena);
    }

    public void resume(){//função usada para o botão de resume, resume o jogo.
        pause.gameObject.SetActive(false);
            Time.timeScale = 1; 
            Cursor.visible = false;
    }
}
