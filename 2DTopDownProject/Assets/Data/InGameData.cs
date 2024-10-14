using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class InGameData : ScriptableObject
{
	public List<InGameDataPlayerName> PlayerName; // Replace 'EntityType' to an actual type that is serializable.
	public List<InGameDataNPCDialog> NPCDialog; // Replace 'EntityType' to an actual type that is serializable.



}
