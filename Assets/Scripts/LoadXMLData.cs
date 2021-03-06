﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class LoadXMLData : MonoBehaviour {
	public TextAsset gameData;
	public static List<string> idNumbers = new List<string>();
	private char[] delimiters = {','};
	public static Hashtable allData = new Hashtable();
	public int initArraySize = 0;
	
	void Start () {
		getLevel();
	}
	
	void getLevel() {
		XmlDocument xml = new XmlDocument();
		xml.LoadXml(gameData.text);
		
		foreach(XmlNode node in xml.SelectNodes("levels/level")) {
			Hashtable hLevelData = new Hashtable();
			hLevelData["maxClicks"] = int.Parse(node.Attributes.GetNamedItem("maxClicks").Value);
			hLevelData["rawLevel"] = node.InnerXml.Split(delimiters).Select(s => int.Parse(s)).ToArray();
			hLevelData["locked"] = (bool)(node.Attributes.GetNamedItem("locked").Value == "yes");
			allData[node.Attributes.GetNamedItem("id").Value] = hLevelData;
			idNumbers.Add(node.Attributes.GetNamedItem("id").Value);
			initArraySize++;
		}
	}
}
