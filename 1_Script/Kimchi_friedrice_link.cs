using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kimchi_friedrice_link : MonoBehaviour
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
        SceneManager.LoadScene(5);
    }

    public void Link()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=AohIKHIB4cc");
    }
}
