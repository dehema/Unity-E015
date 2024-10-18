using DotLiquid;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuModel
{
    public string lang;
    public Dictionary<string, MenuModel> child;
    public string icon;

}

public class MenuConfig
{
    public Dictionary<string, MenuModel> menu;
}
