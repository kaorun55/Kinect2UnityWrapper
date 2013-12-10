using UnityEngine;
using System;
using System.Collections;
using Kinect2;
using System.Runtime.InteropServices;

public class KinectBehaviourScript : MonoBehaviour {

	KinectSensor kinect;
	ColorFrameReader colorReader;
	TextMesh tm;
	TextMesh tm2;
	TextMesh tm3;
	Texture2D texture;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find("TextMessage");
		tm = (TextMesh)go.GetComponent("TextMesh");
		tm.text = "Kinect Initialize";
		
		go = GameObject.Find("TextMessage2");
		tm2 = (TextMesh)go.GetComponent("TextMesh");
		
		go = GameObject.Find("TextMessageFPS");
		tm3 = (TextMesh)go.GetComponent("TextMesh");

		kinect = KinectSensor.Default;
		kinect.Open();
		colorReader = kinect.ColorFrameSource.OpenReader();

		if (texture == null) {
			texture = new Texture2D(1920,1080, TextureFormat.BGRA32,false);
			renderer.material.mainTexture = texture;
			tm.text = "texture created.";
		}

	}

	int frameCount = 0;

	// Update is called once per frame
	void Update () {
		try {
			if ( colorReader == null ) {
				tm.text = "colorReader == null";
				return;
			}

			using ( var colorFrame = colorReader.AcquireLatestFrame() ) {
				if ( colorFrame == null ) {
					tm.text = "colorFrame == null";
					return;
				}
				frameCount++;
				tm3.text = frameCount.ToString();
				
				
				UInt64 count = 1920*1080*4;
				var pixels = new byte[count];
				colorFrame.CopyConvertedFrameDataToArray( pixels, ColorImageFormat.Bgra );
				
				tm2.text = string.Format( "{0},{1},{2},{3}", pixels[0], pixels[1], pixels[2], pixels[3] );
				
				texture.LoadRawTextureData( pixels );
				texture.Apply();
			}
		} catch (Exception ex) {
			tm.text = ex.StackTrace;
		}
		finally{
		}
	}
}
