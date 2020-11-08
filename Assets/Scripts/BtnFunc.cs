using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leo;
using UnityEngine.UI;
using System;

public class BtnFunc : MonoBehaviour
{
    public GameObject panel = null;
    public Path path = null;
    private Button btn = null;
    private bool show = false;
    public string modelName = "";
    public bool isEffect = false;
    public List<GameObject> effects = new List<GameObject>();

    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ClickBtn);
        SetState();
        for (int i = 0; i < effects.Count; i++)
        {
            effects[i].SetActive(show);
        }
    }

    private void ClickBtn()
    {
        show = !show;
        SetState();
        if (path != null&&modelName!="")
        {
            path.SetPath(modelName, isEffect);
        }
        if (modelName == "")
        {
            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].SetActive(show);
            }
        }
    }

    private void SetState()
    {
        if (panel != null)
        {
            if (show)
            {
                panel.SetActive(true);
            }
            else
            {
                panel.SetActive(false);
            }
        }
    }
}
