using UnityEngine;
using UnityEngine.UI;


public class pronto : MonoBehaviour
{
    public Transform Pronto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > 0)
        {
            tempo -= Time.deltaTime;
            DisplayTime(tempo);
        } else {
            Pronto.gameObject.SetActive(false);
            ResumirObjeto();
        }

    }

    public float tempo = 3;
    public Text texto;
    public GameObject obj;
    void DisplayTime(float timeToDisplay)
    {  
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        texto.text = string.Format("{0}", seconds);
    }
    void ResumirObjeto()
    {
        obj.SetActive(true);
    }

}
