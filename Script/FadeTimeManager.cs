using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTimeManager : MonoBehaviour
{
	[SerializeField]
	private string sceneName;
	[SerializeField]
	private float timeToFade;
	[SerializeField]
	private float EndTime;

	private int flag = 1;

	void Update()
	{
		if (Time.time > EndTime && flag == 1)
		{
			flag = 0;
			FadeScene();
		}
	
	}
	public void FadeScene()
	{
		FadeManager.Instance.LoadScene(sceneName, timeToFade);
		//Debug.Log(sceneName);
	}
}
