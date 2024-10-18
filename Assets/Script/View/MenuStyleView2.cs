using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class MenuStyleView2 : BaseView
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
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 122);
            Toggle toggle = menuItem.GetComponent<Toggle>();
            toggle.onValueChanged.AddListener((bool ison) => { if (ison) onclickMenu1(name); });
        }
        if (menuParent1.transform.childCount > 1)
            menuParent1.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
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
        for (int i = menuParent2.transform.childCount - 1; i >= 1; i--)
        {
            GameObject.Destroy(menuParent2.transform.GetChild(i).gameObject);
        }
        Dictionary<string, MenuModel> child = GameMgr.Ins.menuConfig.menu[_name].child;
        menuContent2.SetActive(child != null && child.Count > 0);
        l2.SetActive(child != null && child.Count > 0);
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
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 70);
            Toggle toggle = menuItem.GetComponent<Toggle>();
            toggle.onValueChanged.AddListener((bool ison) => { if (ison) showContentPage(name); });
        }
        if (menuParent2.transform.childCount > 1)
            menuParent2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
    }

    void showContentPage(string _pagName)
    {
        GameMgr.Ins.showContentPagePrefab(_pagName, contentPage.transform);
    }

    void reSizeContentPage()
    {
        //height
        float width = canvas.pixelRect.width;
        width -= menuContent1_Rect.rect.width;
        if (l2.activeSelf)
            width -= l2_Rect.rect.width;
        contentPage_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
    }
}
