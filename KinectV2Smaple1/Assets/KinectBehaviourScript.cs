using UnityEngine;
using System;
using System.Collections;
using KinectSensor;

public class KinectBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IntPtr sensor = IntPtr.Zero;
		var hr = NativeMethods.GetDefaultKinectSensor( ref sensor );
		print( "Kinect Initialize : " + hr.ToString() );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
