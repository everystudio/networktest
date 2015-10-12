using UnityEngine;
using System.Collections;
using EveryStudioLibrary;

public class main_network_test : MonoBehaviour {

	bool m_bConnected;
	int m_iSerial;

	// Use this for initialization
	void Start () {
		m_bConnected = false;
		m_iSerial = CommonNetwork.Instance.Request ("http://www.yahoo.co.jp/" , "");
	}
	
	// Update is called once per frame
	void Update () {

		if (m_bConnected == false) {
			if (CommonNetwork.Instance.IsConnected (m_iSerial)) {
				m_bConnected = true;
				string strRecieveData = CommonNetwork.Instance.GetString (m_iSerial);
				Debug.Log (strRecieveData);
			}
		}
	
	}
}
