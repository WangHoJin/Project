using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class bread_button : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject startBtn, nextBtn, butter, melted_butter, toast, toast_2, recipe1;
    public Animation butterAni, Melted_butterAni, toastAni, toast_2Ani;
    bool sw = false;
    // Use this for initialization
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);

        butter = GameObject.Find("butter");
        melted_butter = GameObject.Find("friedegg");
        toast = GameObject.Find("toast");
        toast_2 = GameObject.Find("toast_2");
        recipe1 = GameObject.Find("recipe1");
        butterAni.GetComponent<Animation>().Stop();
        Melted_butterAni.GetComponent<Animation>().Stop();
        toastAni.GetComponent<Animation>().Stop();
        toast_2Ani.GetComponent<Animation>().Stop();
        recipe1.active = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "backbutton")
        {
            SceneManager.LoadScene(1);
        }
        else if (vbName == "startbutton")
        {
            butterAni.GetComponent<Animation>().Play("butter");
            Melted_butterAni.GetComponent<Animation>().Play("Melted_butter");
            toastAni.GetComponent<Animation>().Play("toast");
            toast_2Ani.GetComponent<Animation>().Play("toast_2");      
            Debug.Log("BTN Pressed");
        }
        else if (vbName == "recipebutton")
        {
            if (sw == false)
            {
                recipe1.active = true;
                sw = true;
            }
            else if (sw == true)
            {
                recipe1.active = false;
                sw = false;
            }
        }
        else if (vbName == "nextbutton")
        {
            SceneManager.LoadScene(3);
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
