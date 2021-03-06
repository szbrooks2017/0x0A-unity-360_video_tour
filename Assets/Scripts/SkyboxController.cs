using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkyboxController : MonoBehaviour
{
    // Render Textures to swap to for on-click
    public Material LivingRoomMat, CatinaMat, MezzanineMat, CubeMat;
    public GameObject LivingRoomObject, CatinaObject, MezzanineObject, CubeObject;
    public VideoClip LivingRoomVid, CatinaVid, MezzanineVid, CubeVid;

    // living room
    ///<summary>StartLivingRoom initializes the living room video </summary>
    public void StartLivingRoom()
    {
        StartCoroutine(LivingRoom());
    }

    IEnumerator LivingRoom()
    {
        yield return new WaitForSeconds(0.2f);
        // set new skybox
        RenderSettings.skybox = LivingRoomMat;
        // set object controlling video player
        CatinaObject.SetActive(false);
        MezzanineObject.SetActive(false);
        CubeObject.SetActive(false);
        LivingRoomObject.SetActive(true);
        // handle video player
        GetComponent<VideoPlayer>().clip = LivingRoomVid;
        GetComponent<VideoPlayer>().Play();

    }

    // catina
    ///<summary>StartCatina initializes the catina video </summary>
    public void StartCatina()
    {
        StartCoroutine(Catina());
    }

    IEnumerator Catina()
    {
        yield return new WaitForSeconds(0.2f);
        // set object controlling video player
        MezzanineObject.SetActive(false);
        CubeObject.SetActive(false);
        LivingRoomObject.SetActive(false);
        // handle video player
        GetComponent<VideoPlayer>().clip = CatinaVid;
        CatinaObject.SetActive(true);
        GetComponent<VideoPlayer>().Play();
    }

    // mezzanine
    ///<summary>StartMezzanine goes to the mez video </summary>
    public void StartMezzanine()
    {
        StartCoroutine(Mezzanine());
    }

    IEnumerator Mezzanine()
    {
        yield return new WaitForSeconds(0.2f);
        // set new skybox
        RenderSettings.skybox = MezzanineMat;

        // set object controlling video player
        MezzanineObject.SetActive(true);
        CubeObject.SetActive(false);

        // handle video player
        GetComponent<VideoPlayer>().clip = MezzanineVid;
        MezzanineObject.SetActive(true);
        GetComponent<VideoPlayer>().Play();
    }

    // cube
    ///<summary>StartCube goes to the cube video </summary>
    public void StartCube()
    {
        StartCoroutine(Cube());
    }

    IEnumerator Cube()
    {
        Debug.Log("I'm being clicked");
        yield return new WaitForSeconds(0.2f);
        // set new skybox
        // RenderSettings.skybox = MezzanineMat;
        // set object controlling video player
        CatinaObject.SetActive(false);
        MezzanineObject.SetActive(false);
        LivingRoomObject.SetActive(false);
        // handle video player
        GetComponent<VideoPlayer>().clip = CubeVid;
        CubeObject.SetActive(true);
        GetComponent<VideoPlayer>().Play();
    }
}
