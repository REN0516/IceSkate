using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScroll : MonoBehaviour
{
	[SerializeField, Range(-1f, 1f)] private float speed_x_;
	[SerializeField, Range(-1f, 1f)] private float speed_y_;
	private float scroll_x_;
	private float scroll_y_;

	void Update()
	{
		scroll_x_ = Mathf.Repeat(Time.time * speed_x_, 1);
		scroll_y_ = Mathf.Repeat(Time.time * speed_y_, 1);
		Vector2 offset = new Vector2(scroll_x_, scroll_y_);
		GetComponent<Image>().material.SetTextureOffset("_MainTex", offset);
	}
}
