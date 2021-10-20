using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BasePopUp : MonoBehaviour
{
	[SerializeField]
	protected GameObject root;

	[SerializeField]
	protected Button closeButton;
	[SerializeField]
	protected Button okButton;

	public void Close()
	{
		root.SetActive(false);
	}
}
