using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class MenuStyleView1 : BaseView
{
    [HideInInspector]
    public GameObject bg;
    [HideInInspector]
    public Image bg_Image;
    [HideInInspector]
    public Button bg_Button;
    [HideInInspector]
    public GameObject content;
    [HideInInspector]
    public RectTransform content_Rect;
    [HideInInspector]
    public GameObject top1;
    [HideInInspector]
    public RectTransform top1_Rect;
    [HideInInspector]
    public GameObject topMenuParent1;
    [HideInInspector]
    public GameObject menu1;
    [HideInInspector]
    public Toggle menu1_Toggle;
    [HideInInspector]
    public GameObject account;
    [HideInInspector]
    public Button account_Button;
    [HideInInspector]
    public GameObject shutdown;
    [HideInInspector]
    public Button shutdown_Button;
    [HideInInspector]
    public GameObject top2;
    [HideInInspector]
    public RectTransform top2_Rect;
    [HideInInspector]
    public GameObject topMenuParent2;
    [HideInInspector]
    public GameObject menu2;
    [HideInInspector]
    public Toggle menu2_Toggle;
    [HideInInspector]
    public GameObject contentPage;
    [HideInInspector]
    public RectTransform contentPage_Rect;

    internal override void _LoadUI()    
    {
        base._LoadUI();
        bg = transform.Find("$bg#Image,Button").gameObject;
        bg_Image = bg.GetComponent<Image>();
        bg_Button = bg.GetComponent<Button>();
        content = transform.Find("$content#Rect").gameObject;
        content_Rect = content.GetComponent<RectTransform>();
        top1 = transform.Find("$content#Rect/$top1#Rect").gameObject;
        top1_Rect = top1.GetComponent<RectTransform>();
        topMenuParent1 = transform.Find("$content#Rect/$top1#Rect/$topMenuParent1").gameObject;
        menu1 = transform.Find("$content#Rect/$top1#Rect/$topMenuParent1/$menu1#Toggle").gameObject;
        menu1_Toggle = menu1.GetComponent<Toggle>();
        account = transform.Find("$content#Rect/$top1#Rect/shotDown/$account#Button").gameObject;
        account_Button = account.GetComponent<Button>();
        shutdown = transform.Find("$content#Rect/$top1#Rect/shotDown/$shutdown#Button").gameObject;
        shutdown_Button = shutdown.GetComponent<Button>();
        top2 = transform.Find("$content#Rect/$top2#Rect").gameObject;
        top2_Rect = top2.GetComponent<RectTransform>();
        topMenuParent2 = transform.Find("$content#Rect/$top2#Rect/$topMenuParent2").gameObject;
        menu2 = transform.Find("$content#Rect/$top2#Rect/$topMenuParent2/$menu2#Toggle").gameObject;
        menu2_Toggle = menu2.GetComponent<Toggle>();
        contentPage = transform.Find("$content#Rect/$contentPage#Rect").gameObject;
        contentPage_Rect = contentPage.GetComponent<RectTransform>();
    }
}