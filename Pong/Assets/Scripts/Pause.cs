using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public Transform pause;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            }
            else
            {
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
            };
        }
    }
    public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    public void resume()
    {
        pause.gameObject.SetActive(false);
            Time.timeScale = 1; 
    }
    public void Quit()
    {
        Application.Quit();
    }
}
