using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class egg_button : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject startBtn, nextBtn, egg, friedegg, woodspoon, recipe1;
    public Animation eggAni, friedeggAni, woodspoonAni;

    // Use this for initialization
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();


        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);


        //vbBtnObj = GameObject.Find("VirtualButton");
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        egg = GameObject.Find("egg");
        friedegg = GameObject.Find("friedegg");
        woodspoon = GameObject.Find("woodspoon");
        recipe1 = GameObject.Find("recipe1");

        eggAni.GetComponent<Animation>().Stop();
        friedeggAni.GetComponent<Animation>().Stop();
        woodspoonAni.GetComponent<Animation>().Stop();
        recipe1.active = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "backbutton")
        {
            SceneManager.LoadScene(2);
        }
        else if (vbName == "startbutton")
        {
            eggAni.GetComponent<Animation>().Play("egg");
            friedeggAni.GetComponent<Animation>().Play("friedegg");
            woodspoonAni.GetComponent<Animation>().Play("woodspoon");
            Debug.Log("BTN Pressed");
        }
        else if (vbName == "recipebutton")
        {
            recipe1.active = true;
        }
        else if (vbName == "nextbutton")
        {
            SceneManager.LoadScene(4);
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
