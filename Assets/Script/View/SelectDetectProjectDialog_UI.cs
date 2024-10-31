using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class SelectDetectProjectDialog : BaseView
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
    public GameObject save;
    [HideInInspector]
    public Button save_Button;
    [HideInInspector]
    public GameObject saveAll;
    [HideInInspector]
    public Button saveAll_Button;

    internal override void _LoadUI()    
    {
        base._LoadUI();
        bg = transform.Find("$bg#Image,Button").gameObject;
        bg_Image = bg.GetComponent<Image>();
        bg_Button = bg.GetComponent<Button>();
        content = transform.Find("$content#Rect").gameObject;
        content_Rect = content.GetComponent<RectTransform>();
        save = transform.Find("$content#Rect/bg/$save#Button").gameObject;
        save_Button = save.GetComponent<Button>();
        saveAll = transform.Find("$content#Rect/bg/$saveAll#Button").gameObject;
        saveAll_Button = saveAll.GetComponent<Button>();
    }
}