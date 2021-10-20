using System;
using UnityEngine.Events;

public class TestPrefab : PopupSystem<TestPopupData>
{
    public override void Open(TestPopupData setupData)
    {
        root.SetActive(true);
        Setup(setupData);
    }

    protected override void Setup(TestPopupData definition)
    {
        closeButton.onClick.AddListener(definition.button1);
        okButton.onClick.AddListener(definition.button2);
    }
}

public class TestPopupData
{
    public UnityAction button1;
    public UnityAction button2;

    public TestPopupData(UnityAction button1, UnityAction button2)
    {
        this.button1 = button1;
        this.button2 = button2;
    }
}


