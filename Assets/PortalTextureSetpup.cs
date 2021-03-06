using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetpup : MonoBehaviour
{

    public List<Camera> cams = new List<Camera>();
    public List<Material> mats = new List<Material>();

    void Start()
    {
        for (int i = 0; i < cams.Count; i++)
        {
            if (cams[i].targetTexture != null)
            {
                cams[i].targetTexture.Release();
            }
            cams[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            mats[i].mainTexture = cams[i].targetTexture;
        }
    }

    
    void Update()
    {
        
    }
}
