using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class MainView : BaseView
{
    string currFirstMenu;
    public List<Toggle> menuToggleList2 = new List<Toggle>();
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
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 108);
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
        bool isShowMenu = child != null && child.Count > 0;
        menuContent2.SetActive(isShowMenu);
        contentPage_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, isShowMenu ? canvas.pixelRect.width - 100 : canvas.pixelRect.width);
        showContentPage(_name);
        if (child == null)
        {
            return;
        }
        menuToggleList2.Clear();
        foreach (var _item in child)
        {
            string name = _item.Key;
            MenuModel menuModel = _item.Value;
            GameObject menuItem = GameMgr.Ins.getMenuItem(name, menuModel, menu2);
            TextMeshProUGUI text = menuItem.transform.Find("Label").GetComponent<TextMeshProUGUI>();
            if (menuModel.lang.Length == 2)
                menuItem.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);
            Toggle toggle = menuItem.GetComponent<Toggle>();
            menuToggleList2.Add(toggle);
            toggle.onValueChanged.AddListener((bool ison) => { if (ison) showContentPage(name); });
        }
        if (menuParent2.transform.childCount > 1)
            menuParent2.transform.GetChild(1).GetComponent<Toggle>().isOn = true;
    }

    public void showContentPage(string _pagName)
    {
        GameMgr.Ins.showContentPagePrefab(_pagName, contentPage.transform);
    }
}
