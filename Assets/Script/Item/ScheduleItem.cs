using UnityEngine;

public partial class ScheduleItem : BaseUI
{
    DetectProcessInfo info;

    public void init(DetectProcessInfo _info)
    {
        _LoadUI();
        info = _info;
        scheduleID_TextMeshProUGUI.text = _info.scheduleID;
        detectProject_TextMeshProUGUI.text = _info.detectProject;
        ScheduleGanttChart scheduleGanttChart = GetComponentInParent<ScheduleGanttChart>();
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, scheduleGanttChart.getScheduleItemWidth(_info.estimateDuration));
        toggle_Toggle.isOn = false;
        status_Image.sprite = Resources.Load<Sprite>("Art/Icon/" + (_info.status == DetectProcessStatus.Detect ? "进行中" : "未处理"));
    }
}
