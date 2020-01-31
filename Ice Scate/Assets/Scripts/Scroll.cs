using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
	[SerializeField,Range(0.1f,1f)] private float speed_;
	private float scroll_;

	void Update()
	{
		if(StateManager.manager_.state_ == StateManager.State.ACTIVE)
		{
			scroll_ = Mathf.Repeat(Time.time * speed_, 1);
			Vector2 offset = new Vector2(0, scroll_);
			GetComponent<Image>().material.SetTextureOffset("_MainTex", offset);
		}
	}
}
