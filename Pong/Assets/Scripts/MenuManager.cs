using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string Jogo;
    [SerializeField] private GameObject Menu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Jogar(){
        SceneManager.LoadScene(Jogo);
        Menu.SetActive(false);
    }

    public void Sair(){
        Application.Quit();
    }
}
