using System;
using UnityEngine;
using UnityEngine.UI;

public class BasePopUp : MonoBehaviour
{
	[SerializeField]
	protected GameObject root;

	[SerializeField]
	protected Button closeButton;
	[SerializeField]
	protected Button okButton;

	public virtual void Open() { }
	public void Close()
	{
		root.SetActive(false);
	}
}
