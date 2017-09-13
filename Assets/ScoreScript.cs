using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

	public Text showScore;
	public int score = 0;
	public bool flg = false;


	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (flg)
			plius ();
	}

	public void plius ()
	{
		score++;
		showScore.text = score.ToString ();
	}

	public void minus ()
	{
		score--;
		showScore.text = score.ToString ();
	}

	public void	Change_Flg ()
	{
		flg = !flg;
	}
}
