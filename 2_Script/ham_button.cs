using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ham_button : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject startBtn, nextBtn, ham1, ham2, knife;
    public Animation slice_ham1, slice_ham2, cut_ham;

    // Use this for initialization
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();


        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);


        //vbBtnObj = GameObject.Find("VirtualButton");
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ham1 = GameObject.Find("ham1");
        ham2 = GameObject.Find("ham2");
        knife = GameObject.Find("knife");
        slice_ham1.GetComponent<Animation>().Stop();
        slice_ham2.GetComponent<Animation>().Stop();
        cut_ham.GetComponent<Animation>().Stop();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "backbutton")
        {
            SceneManager.LoadScene(3);
        }
        else if (vbName == "startbutton")
        {
            slice_ham1.GetComponent<Animation>().Play("slice_ham1");
            slice_ham2.GetComponent<Animation>().Play("slice_ham2");
            cut_ham.GetComponent<Animation>().Play("cut_ham");
            Debug.Log("BTN Pressed");
        }
        else if (vbName == "recipebutton")
        {

        }
        else if (vbName == "nextbutton")
        {
            SceneManager.LoadScene(1);
        }


    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BTN Realesed");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
