using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Link()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=76CSbAYpHic");
    }
}
