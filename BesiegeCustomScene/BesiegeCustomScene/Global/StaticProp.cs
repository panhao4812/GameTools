﻿using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace BesiegeCustomScene
{
    public class Prop : MonoBehaviour
    {
        void Start()
        {
            Isstart = 0;
        }
        private int Isstart = 0;
        public static AssetBundle iteratorVariable1;
        public GameObject TileTemp = null;
        public GameObject WaterTemp = null;
        public GameObject CloudTemp = null;
        public GameObject IceTemp = null;
        public GameObject SnowTemp = null;
        public List<GameObject> MaterialTemp = new List<GameObject>();
        public static string BundlePath = "assets/standard assets/besiegecustomscene/";
        public static Mesh MeshFormBundle(string Objname)
        {
            Mesh mesh = iteratorVariable1.LoadAsset<Mesh>(BundlePath + "Mesh/" + Objname + ".obj");
            return mesh;
        }
        public static Texture TextureFormBundle(string Objname)
        {
            Texture te = iteratorVariable1.LoadAsset<Texture>(BundlePath + "Texture/" + Objname + ".jpg");
            if (te == null) te = iteratorVariable1.LoadAsset<Texture>(BundlePath + "Texture/" + Objname + ".png");
            return te;
        }
        public GameObject GetObjectInScene(string ObjectName)
        {
            try
            {
                GameObject ObjectTemp = (GameObject)Instantiate(GameObject.Find(ObjectName));
                ObjectTemp.name = ObjectName + "Temp";
                UnityEngine.Object.DontDestroyOnLoad(ObjectTemp);
                GeoTools.Log("Get " + ObjectName + "Temp Successfully");
                ObjectTemp.SetActive(false);
                return ObjectTemp;
            }
            catch (Exception ex)
            {
                GeoTools.Log("Error! Get " + ObjectName + "Temp Failed");
                GeoTools.Log(ex.ToString());
                return null;
            }
        }
        private string StartedScene = "";
        public static double t = 5;
        void FixedUpdate()
        {
            if (Isstart > 6 * t) return;
            try
            {
                if (Isstart == 1 * t)
                {
                    try
                    {
                        WWW iteratorVariable0 = new WWW("file:///" + GeoTools.ShaderPath + "water5");
                        iteratorVariable1 = iteratorVariable0.assetBundle;
                        if (iteratorVariable1 != null)
                        {
                              string[] names = iteratorVariable1.GetAllAssetNames();
                              for (int i = 0; i < names.Length; i++) { GeoTools.Log(names[i]); }
                        }
                    }
                    catch (Exception ex)
                    {
                        GeoTools.Log("Error! assetBundle failed");
                        GeoTools.Log(ex.ToString());
                    }

                }
                string startscenename = SceneManager.GetActiveScene().name;
                //GeoTools.Log(startscenename);
                if (startscenename == "TITLE SCREEN"&& Isstart==6*t)
                {
                    Isstart++;
                    StartedScene = SceneManager.GetActiveScene().name;
                   // GeoTools.OpenScene("TITLE SCREEN");
                    CloudTemp = GetObjectInScene("CLoud");
                    ParticleSystemRenderer psr = CloudTemp.GetComponent<ParticleSystemRenderer>();
                    psr.receiveShadows = false;
                    psr.sharedMaterial.mainTexture = iteratorVariable1.LoadAsset<Texture>(
                        "Assets/Standard Assets/ParticleSystems/Textures/ParticleCloudWhite.png");
                    psr.shadowCastingMode = ShadowCastingMode.Off;
                    ParticleSystem ps = CloudTemp.GetComponent<ParticleSystem>();
                    ps.startSize = 30;
                    ps.startLifetime = 60;
                    ps.startSpeed = 0.8f;
                    ps.maxParticles = 15;
                    CloudTemp.name = "CloudTemp";
                    DontDestroyOnLoad(CloudTemp);
                    CloudTemp.SetActive(false);
                    GeoTools.Log("Get " + CloudTemp.name + " Successfully");
                }
                if (Isstart == 3 * t)
                {
                    for(int i = 0; i <= 10; i++) {
                        string jpgName = "WM" + i.ToString();
                        if (! File.Exists(GeoTools.TexturePath + jpgName + ".jpg")) break;
                    GameObject WMTemp = GameObject.CreatePrimitive(PrimitiveType.Plane);
                    WMTemp.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                    WMTemp.GetComponent<Renderer>().material.SetFloat("_Glossiness", 1);
                    WMTemp.GetComponent<Renderer>().material.mainTexture = GeoTools.LoadTexture(jpgName);
                    WMTemp.name = jpgName + "Temp";
                    DontDestroyOnLoad(WMTemp);
                    WMTemp.SetActive(false);
                    this.MaterialTemp.Add(WMTemp);
                    GeoTools.Log("Get " + WMTemp.name + " Successfully");
                    }                   
                }

                if (Isstart == 4 * t)
                {
                    WaterTemp = new GameObject();
                    WaterTemp.AddComponent<WaterBase>();
                    WaterTemp.AddComponent<SpecularLighting>();
                    WaterTemp.AddComponent<PlanarReflection>();
                    WaterTemp.AddComponent<GerstnerDisplace>();
                    TileTemp = iteratorVariable1.LoadAsset<GameObject>(
                        "assets/standard assets/environment/water/water4/prefabs/TileOnly.prefab");
                    TileTemp.AddComponent<WaterTile>();
                    TileTemp.GetComponent<WaterTile>().reflection = WaterTemp.GetComponent<PlanarReflection>();
                    TileTemp.GetComponent<WaterTile>().waterBase = WaterTemp.GetComponent<WaterBase>();
                    Material mat = TileTemp.GetComponent<Renderer>().material;
                    GeoTools.ResetWaterMaterial(ref mat);
                    UnityEngine.Object.DontDestroyOnLoad(TileTemp);
                    TileTemp.name = "TileTemp";
                    TileTemp.SetActive(false);
                    WaterTemp.GetComponent<WaterBase>().sharedMaterial = TileTemp.GetComponent<Renderer>().material;
                    UnityEngine.Object.DontDestroyOnLoad(WaterTemp);
                    WaterTemp.name = "WaterTemp";
                    WaterTemp.SetActive(false);
                    GeoTools.Log("Get " + TileTemp.name + " Successfully");
                }
                if (Isstart == 5 * t)
                {
                    SnowTemp= iteratorVariable1.LoadAsset<GameObject>(
                        "assets/standard assets/particlesystems/prefabs/duststom2.prefab");
                    SnowTemp.name = "SnowTemp";
                    SnowTemp.SetActive(false);
                    UnityEngine.Object.DontDestroyOnLoad(SnowTemp);
                    GeoTools.Log("Get " + SnowTemp.name + " Successfully");
                }
            }
            catch (Exception ex)
            {
                GeoTools.Log(ex.ToString());
            }
            if (Isstart < 6 * t) Isstart++;
        }
    }
}
