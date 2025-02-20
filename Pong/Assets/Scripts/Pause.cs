using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Transform pause;
    public GameObject pronto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause.gameObject.activeSelf)
            {
                pause.gameObject.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                pronto.gameObject.SetActive(true);
            }
            else
            {
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                if(pronto.gameObject.activeSelf){
                    pronto.gameObject.SetActive(false);
                };
            };
        }
    }
    public void LoadScenes(string cena)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(cena);
    }
    public void resume()
    {
        pause.gameObject.SetActive(false);
            Time.timeScale = 1; 
            Cursor.visible = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
