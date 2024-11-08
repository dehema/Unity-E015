using com.adjust.sdk;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class Overview : BaseUI
{
    public Button btQPCR;
    public Button btAxe;
    public Button btSample;
    public GameObject qpcr;
    public GameObject axe;
    public GameObject sample;

    private void Start()
    {
        _LoadUI();
        btQPCR.onClick.AddListener(() =>
        {
            btQPCR.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 1);
            btAxe.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            btSample.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            qpcr.SetActive(true);
            axe.SetActive(false);
            sample.SetActive(false);
        });
        btAxe.onClick.AddListener(() =>
        {
            btQPCR.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            btAxe.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 1);
            btSample.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            qpcr.SetActive(false);
            axe.SetActive(true);
            sample.SetActive(false);
        });
        btSample.onClick.AddListener(() =>
        {
            btQPCR.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            btAxe.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 0);
            btSample.GetComponent<Image>().color = new Color(0, 0.627451f, 0.9137255f, 1);
            qpcr.SetActive(false);
            axe.SetActive(false);
            sample.SetActive(true);
        });

        reagent_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            pageOverview.SetActive(_ison);
        });

        equip_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            pageEqupState.SetActive(_ison);
        });

        pageOverview.SetActive(true);
        pageEqupState.SetActive(false);


        btQPCR.onClick.Invoke();
        reagent_Toggle.isOn = true;
    }
}
