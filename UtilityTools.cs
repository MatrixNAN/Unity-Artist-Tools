using UnityEngine;
using System.Collections;

public class UtilityTools : MonoBehaviour 
{
	public static UtilityTools Instance;

	IEnumerator LoadTexture2DFromDisk(string file_loc = "", Texture2D textureShader = null)
	{
		Debug.Log (file_loc);
		textureShader = new Texture2D(4, 4, TextureFormat.DXT5, false);
		WWW www = new WWW(file_loc);
		yield return www;
		textureShader = www.texture;
	}

	void Awake()
	{
		Instance = this;
	}
}
