using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Toast_link : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ARClick()
    {
        SceneManager.LoadScene(2);
    }

    public void Link()
    {
        Application.OpenURL("http://203.255.77.160:8080/Main/index.jsp");
    }
}
