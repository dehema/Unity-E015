using UnityEngine;

public partial class ScheduleItem : BaseUI
{
    ScheduleInfo info;

    public void init(ScheduleInfo _info)
    {
        _LoadUI();
        info = _info;
        scheduleID_TextMeshProUGUI.text = _info.scheduleID;
        detectProject_TextMeshProUGUI.text = _info.detectProject;
        ScheduleGanttChart scheduleGanttChart = GetComponentInParent<ScheduleGanttChart>();
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, scheduleGanttChart.getScheduleItemWidth(_info.duration));
        toggle_Toggle.isOn = false;
        status_Image.sprite = Resources.Load<Sprite>("Art/Icon/" + (_info.isStart ? "进行中" : "未处理"));
    }
}
