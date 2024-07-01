using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {


	private RuntimeAnimatorController[] CurrentGroup {
		get {
			switch (groupID) {
				default:
				case 0:
					return m_Anis0;
				case 1:
					return m_Anis1;
				case 2:
					return m_Anis2;
				case 3:
					return m_Anis3;
			}
		}
	}


	[SerializeField] private RuntimeAnimatorController[] m_Anis0;
	[SerializeField] private RuntimeAnimatorController[] m_Anis1;
	[SerializeField] private RuntimeAnimatorController[] m_Anis2;
	[SerializeField] private RuntimeAnimatorController[] m_Anis3;
	[SerializeField] private Animator m_PlayerAni;
	[SerializeField] private Text m_GroupLabel;
	[SerializeField] private Text m_AniLabel;


	private int groupID = 0;
	private int aniID = 0;
	private readonly string[] GROUP_NAMES = { "Animal", "Fighter", "Monster", "NPC" };



	private void Start () {
		SwitchTo(0);
	}



	public void SwitchGroup (bool right) {
		groupID = Mathf.Clamp(right ? groupID + 1 : groupID - 1, 0, 3);
		m_GroupLabel.text = GROUP_NAMES[groupID];
		SwitchTo(aniID);
	}


	public void SwitchAni (bool right) {
		SwitchTo(right ? aniID + 1 : aniID - 1);
	}



	private void SwitchTo (int index) {
		aniID = Mathf.Clamp(index, 0, CurrentGroup.Length - 1);
		m_PlayerAni.runtimeAnimatorController = CurrentGroup[aniID];
		m_AniLabel.text = CurrentGroup[aniID].name;
		m_GroupLabel.text = GROUP_NAMES[groupID];
	}




}
