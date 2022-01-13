using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeButtonManager : MonoBehaviour
{
	[SerializeField]
	private string sceneName;
	[SerializeField]
	private float timeToFade;
	//[SerializeField]
	//private float EndTime;

	public void OnClickStartButton()
	{
		FadeManager.Instance.LoadScene(sceneName, timeToFade);
	}

	public void FadeScene()
	{
		FadeManager.Instance.LoadScene(sceneName, timeToFade);
	}
}
