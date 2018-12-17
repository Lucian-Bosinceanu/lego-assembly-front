using UnityEngine;

public class CameraOrbit : MonoBehaviour {

    private Transform XformCamera;
    private Transform XformParent;
    private Vector3 LocalRotation;
    private float CameraDistance = 10f;
    public float MouseSensitivity = 4f;
    public float ScrollSensitivity = 2f;
    public float OrbitSpeed = 10f;
    public float ScrollSpeed = 6f;
    public bool CameraDisabled = false;

	// Use this for initialization
	void Start () {
        this.XformCamera = this.transform;
        this.XformParent = this.transform.parent;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        if (Input.GetKeyDown(KeyCode.LeftShift))
            CameraDisabled = !CameraDisabled;

        if (!CameraDisabled)
        {
            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;

                LocalRotation.y = Mathf.Clamp(LocalRotation.y, 0f, 90f);
            }

            if(Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity;

                ScrollAmount *= (this.CameraDistance * 0.3f);

                this.CameraDistance += ScrollAmount * -1f;
                this.CameraDistance = Mathf.Clamp(this.CameraDistance, 1.5f, 100f);
            }
        }

        Quaternion QT = Quaternion.Euler(LocalRotation.y, LocalRotation.x, 0);
        this.XformParent.rotation = Quaternion.Lerp(this.XformParent.rotation, QT, Time.deltaTime * OrbitSpeed);
        if(this.XformCamera.localPosition.z != this.CameraDistance * -1f)
        {
            this.XformCamera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this.XformCamera.localPosition.z, this.CameraDistance * -1f, Time.deltaTime * ScrollSpeed));
        }
    	}
}
