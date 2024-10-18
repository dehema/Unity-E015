using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class MenuStyleView3 : BaseView
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
    public GameObject menuContent1;
    [HideInInspector]
    public RectTransform menuContent1_Rect;
    [HideInInspector]
    public GameObject menuParent1;
    [HideInInspector]
    public GameObject menu1;
    [HideInInspector]
    public Toggle menu1_Toggle;
    [HideInInspector]
    public GameObject menuContent2;
    [HideInInspector]
    public RectTransform menuContent2_Rect;
    [HideInInspector]
    public GameObject menuParent2;
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
        menuContent1 = transform.Find("$content#Rect/$menuContent1#Rect").gameObject;
        menuContent1_Rect = menuContent1.GetComponent<RectTransform>();
        menuParent1 = transform.Find("$content#Rect/$menuContent1#Rect/$menuParent1").gameObject;
        menu1 = transform.Find("$content#Rect/$menuContent1#Rect/$menuParent1/$menu1#Toggle").gameObject;
        menu1_Toggle = menu1.GetComponent<Toggle>();
        menuContent2 = transform.Find("$content#Rect/menuHor/$menuContent2#Rect").gameObject;
        menuContent2_Rect = menuContent2.GetComponent<RectTransform>();
        menuParent2 = transform.Find("$content#Rect/menuHor/$menuContent2#Rect/$menuParent2").gameObject;
        menu2 = transform.Find("$content#Rect/menuHor/$menuContent2#Rect/$menuParent2/$menu2#Toggle").gameObject;
        menu2_Toggle = menu2.GetComponent<Toggle>();
        contentPage = transform.Find("$content#Rect/menuHor/$contentPage#Rect").gameObject;
        contentPage_Rect = contentPage.GetComponent<RectTransform>();
    }
}