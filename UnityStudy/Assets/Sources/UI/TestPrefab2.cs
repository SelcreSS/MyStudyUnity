using System;
using UnityEngine;
using UnityEngine.Events;

public class TestPrefab2 : BasePopUp
{
    private void Awake()
    {
        closeButton.onClick.AddListener(() =>StackPopupOpener._Instance.Close());
    }

    public override void Open()
    {
        root.SetActive(true);
    }

    public void OnClick(int index)
    {
        Debug.Log("ClickÅF" + index);
    }
}