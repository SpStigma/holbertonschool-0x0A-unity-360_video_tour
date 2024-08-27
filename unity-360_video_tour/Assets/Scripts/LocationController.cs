using UnityEngine;

public class LocationController : MonoBehaviour
{
    public GameObject sphereLivingRoom;
    public GameObject sphereCantina;
    public GameObject sphereCube;
    public GameObject sphereMezzanine;
    public GameObject cameraVr;

    private void DesactiveSphere()
    {
        transform.parent.parent.gameObject.SetActive(false);
    }

    public void OnCantinaClick()
    {
        DesactiveSphere();
        sphereCantina.SetActive(true);
        cameraVr.transform.position = new Vector3(0, -10, 0);
    }

    public void OnLivingRoomClick()
    {
        DesactiveSphere();
        sphereLivingRoom.SetActive(true);
        cameraVr.transform.position = new Vector3(0, 0, 0);
    }

    public void OnCubeClick()
    {
        DesactiveSphere();
        sphereCube.SetActive(true);
        cameraVr.transform.position = new Vector3(10, 0, 0);
    }

    public void OnMezannineClick()
    {
        DesactiveSphere();
        sphereMezzanine.SetActive(true);
        cameraVr.transform.position = new Vector3(0, 10, 0);
    }
}
