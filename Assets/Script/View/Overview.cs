using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overview : MonoBehaviour
{
    public Button btQPCR;
    public Button btAxe;
    public Button btSample;
    public GameObject qpcr;
    public GameObject axe;
    public GameObject sample;

    private void Start()
    {

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
        btQPCR.onClick.Invoke();
    }
}
