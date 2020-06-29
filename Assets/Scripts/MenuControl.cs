using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGAME()
    {
       
        SceneManager.LoadScene("Scenes/01FirstStartSD", LoadSceneMode.Single);
       
    }
    public void ExitGAME()
    {
        Application.Quit();
    }

}
