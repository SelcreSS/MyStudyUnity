using System;
using UnityEngine;
using UnityEngine.Events;

public class TestPrefab2 : PopupSystem<TestPopupData2>
{
    private void Awake()
    {
        closeButton.onClick.AddListener(() =>StackPopupOpener._Instance.Close());
    }

    public override void Open(TestPopupData2 setupData)
    {
        root.SetActive(true);
        Setup(setupData);
    }

    public void OnClick(int index)
    {
        Debug.Log("Click�F" + index);
    }
}

public class TestPopupData2
{
}
