using UnityEngine;
using UnityEngine.UI;

public class LocationController : MonoBehaviour
{
    public GameObject livingRoomSphere;
    public GameObject cantinaRoomSphere;
    public GameObject cubeRoomSphere;
    public GameObject mezannineSphere;
    public GameObject cameraVr;

    private void DesactiveSphere()
    {
        transform.parent.parent.gameObject.SetActive(false);
    }
    public void OncantinaClick()
    {
        DesactiveSphere();
        cantinaRoomSphere.SetActive(true);
        cameraVr.transform.position = new Vector3(-3, 0, 0);
    }

    public void OnCubeClick()
    {
        DesactiveSphere();
        cubeRoomSphere.SetActive(true);
        cameraVr.transform.position = new Vector3(2, 0, 0);
    }

    public void OnLivingRoomClick()
    {
        DesactiveSphere();
        livingRoomSphere.SetActive(true);
        cameraVr.transform.position = new Vector3(0, 0, 0);
    }

    public void OnMezannineClick()
    {
        DesactiveSphere();
        mezannineSphere.SetActive(true);
        cameraVr.transform.position = new Vector3(0, 0, 2);
    }
}
