using UnityEngine;

/// <summary>
/// クラスやprefabの使い方の意味を教えるときなどに利用して下さい
/// 使い方
/// 1 コメントの意味を持たせたいクラスでserializeFiledかpublicでメンバ変数として持つ
/// 2 インスペクターからコメントを記載する
/// </summary>
[System.Serializable]
public class InspectorComment : MonoBehaviour
{
	[Header("==== Comment ====")]
	[TextArea(2, 5)] public string info;
}
