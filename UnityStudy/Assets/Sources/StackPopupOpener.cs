using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPopupOpener : MonoBehaviour
{
    public static StackPopupOpener _Instance;

    private BasePopUp[] _stackPopups;
    private string _displayPopupName;

    // TODO
    // �ȈՓI�ɕ\���~�|�b�v�A�b�v�������邩�Ń`�F�b�N
    public static bool IsOpened => !string.IsNullOrEmpty(_Instance._displayPopupName);

    void Awake()
    {
        _Instance = this;
        _stackPopups = GetComponentsInChildren<BasePopUp>();
    }

    public void Open<TData>(string popupName, TData setupData) where TData : class
    {
        Close(); // ��dpopup�u���b�N
        foreach(var prefab in _stackPopups)
        {
            if (prefab.name == popupName)
            {
                _displayPopupName = popupName;
                var openPrefab = (PopupSystem<TData>)prefab;
                openPrefab.Open((TData)(object)setupData);
            }
        }
    }

    public void Close()
    {
        foreach (var prefab in _stackPopups)
        {
            if (prefab.name == _displayPopupName)
            {
                _displayPopupName = string.Empty;
                prefab.Close();
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var prefabName in _stackPopups)
        {
            prefabName.Close();
        }
        _Instance = null;
    }
}