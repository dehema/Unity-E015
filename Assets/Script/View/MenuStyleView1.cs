using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class MenuStyleView1 : BaseView
{
    string currFirstMenu;
    public override void Init(params object[] _params)
    {
        base.Init(_params);
        initMenu1();
    }

    void initMenu1()
    {
        menu1.SetActive(false);
        menu2.SetActive(false);
        foreach (var _item in GameMgr.Ins.menuConfig.menu)
        {
            string name = _item.Key;
            MenuModel menuModel = _item.Value;
            GameObject menuItem = GameMgr.Ins.getMenuItem(name, menuModel, menu1);
            if (menuModel.lang.Length == 2)
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 110);
            Toggle toggle = menuItem.GetComponent<Toggle>();
            toggle.onValueChanged.AddListener((bool ison) => { if (ison) onclickMenu1(name); });
        }
        if (topMenuParent1.transform.childCount > 1)
            topMenuParent1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
    }

    void onclickMenu1(string name)
    {
        if (currFirstMenu == name)
        {
            return;
        }
        currFirstMenu = name;
        refreshMenu2(name);
    }

    void refreshMenu2(string _name)
    {
        for (int i = topMenuParent2.transform.childCount - 1; i >= 1; i--)
        {
            GameObject.Destroy(topMenuParent2.transform.GetChild(i).gameObject);
        }
        Dictionary<string, MenuModel> child = GameMgr.Ins.menuConfig.menu[_name].child;
        top2.SetActive(child != null && child.Count > 0);
        reSizeContentPage();
        showContentPage(_name);
        if (child == null)
        {
            return;
        }
        foreach (var _item in child)
        {
            string name = _item.Key;
            MenuModel menuModel = _item.Value;
            GameObject menuItem = GameMgr.Ins.getMenuItem(name, menuModel, menu2);
            TextMeshProUGUI text = menuItem.transform.Find("Label").GetComponent<TextMeshProUGUI>();
            if (menuModel.lang.Length == 2)
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 110);
            Toggle toggle = menuItem.GetComponent<Toggle>();
            toggle.onValueChanged.AddListener((bool ison) => { if (ison) showContentPage(name); });
        }
        if (topMenuParent2.transform.childCount > 1)
            topMenuParent2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
    }

    public void showContentPage(string _pagName)
    {
        GameMgr.Ins.showContentPagePrefab(_pagName, contentPage.transform);
    }

    void reSizeContentPage()
    {
        //height
        float height = canvas.pixelRect.height;
        height -= top1_Rect.rect.height;
        if (top2.activeSelf)
            height -= top2_Rect.rect.height;
        contentPage_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }
}