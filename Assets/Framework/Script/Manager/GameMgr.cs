using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using YamlDotNet.Core;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class GameMgr : MonoBehaviour
{
    public static GameMgr Ins;
    public bool enterGame = false;
    public MenuConfig menuConfig;

    private void Awake()
    {
        Ins = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        LoadMenuConfig();
        ConfigMgr.Ins.Init();
        ConfigMgr.Ins.LoadAllConfig();
        DataMgr.Ins.Load();
        LangMgr.Ins.Init();
        if (Application.isEditor)
        {
            Application.runInBackground = true;
        }
        UIMgr.Ins.OpenView<DebugView>();
        //if (Application.isEditor)
        //{
        //    UIMgr.Ins.OpenView<DebugView>();
        //}
        //else
        //{
        //    StartGame();
        //}
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartGame()
    {
        SceneMgr.Ins.ChangeScene(SceneID.MainScene, () => { EnterGame(); });
    }

    /// <summary>
    /// 完成loading进入游戏
    /// </summary>
    public void EnterGame()
    {
        Debug.Log("-----------------------EnterGame-----------------------");
        enterGame = true;
        CheckFirstEnterGame();
        InitEnterGameTimer();
    }

    /// <summary>
    /// 数据初始化之后 首次进入游戏
    /// </summary>
    private void CheckFirstEnterGame()
    {
    }

    private void InitEnterGameTimer()
    {
        //每十秒保存数据 游戏时长
        //Timer.Ins.SetInterval(() =>
        //{
        //    DataMgr.Ins.gameData.lastOffLine = DateTime.Now;
        //    DataMgr.Ins.SaveGameData();
        //}, 10);
    }

    private void OnApplicationPause(bool pause)
    {
        if (!pause && !Application.isEditor)
        {
            DataMgr.Ins.SaveGameData();
        }
    }

    public MenuConfig LoadMenuConfig()
    {
        Utility.Log("开始读取UI配置");
        string configPath = "Config/Menu";
        string config = Resources.Load<TextAsset>(configPath).text;
        var deserializer = new DeserializerBuilder()
              .WithNamingConvention(CamelCaseNamingConvention.Instance)
              .Build();
        Utility.Dump(config);
        menuConfig = deserializer.Deserialize<MenuConfig>(config);
        return menuConfig;
    }

    public void showContentPagePrefab(string _name, Transform _parent)
    {
        if (_parent.childCount > 0)
        {
            GameObject.Destroy(_parent.GetChild(0).gameObject);
        }
        string path = "View/" + _name;
        GameObject prefab = Resources.Load<GameObject>(path);
        GameObject content = null;
        if (prefab)
        {
            content = Instantiate(prefab, _parent);
        }
        if (content != null)
        {
            RectTransform rect = content.GetComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 0);
            rect.anchorMax = new Vector2(1, 1);
            RectTransform parent_rect = _parent.GetComponent<RectTransform>();
            rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, parent_rect.rect.width);
            rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, parent_rect.rect.height);
            rect.anchoredPosition3D = Vector3.zero;
            rect.localScale = Vector3.one;
        }
    }

    public GameObject getMenuItem(string _name, MenuModel _model, GameObject _origin)
    {
        GameObject go = Instantiate<GameObject>(_origin, _origin.transform.parent);
        go.transform.Find("icon").GetComponent<Image>().sprite = Resources.Load<Sprite>(_model.icon);
        go.transform.Find("icon/icon").GetComponent<Image>().sprite = Resources.Load<Sprite>(_model.icon);
        go.transform.SetAsLastSibling();
        go.SetActive(true);
        go.name = _name;
        TextMeshProUGUI text = go.transform.Find("Label").GetComponent<TextMeshProUGUI>();
        text.text = _model.lang;
        go.GetComponent<Toggle>().group = _origin.transform.parent.GetComponent<ToggleGroup>();
        return go;
    }
}
