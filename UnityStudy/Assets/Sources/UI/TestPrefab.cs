using System;
using UnityEngine.Events;

using UnityEngine;
using UnityEngine.UI;

public class TestPrefab : PopupSystem<TestPopupData>
{
    [SerializeField]
    private Text _text;
    public override void Open(TestPopupData setupData)
    {
        root.SetActive(true);
        Setup(setupData);
    }

    protected override void Setup(TestPopupData data)
    {
        _text.text = data.text;
        closeButton.onClick.AddListener(data.button1);
        okButton.onClick.AddListener(data.button2);
    }
}

public class TestPopupData
{
    public string text;
    public UnityAction button1;
    public UnityAction button2;

    public TestPopupData(string title, UnityAction button1, UnityAction button2)
    {
        text = title;
        this.button1 = button1;
        this.button2 = button2;
    }
}


