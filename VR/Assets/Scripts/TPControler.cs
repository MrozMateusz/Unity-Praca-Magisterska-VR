using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TPControler : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button teleporActivButton;
    public float activationTreshold = 0.1f;
    public GameObject TPRectangleLeft;
    public GameObject TPRectangleRight;

    public XRRayInteractor xRRayInteractorleft;
    public XRRayInteractor xRRayInteractorright;

    public bool EnbaleLeftTeleport { get; set; } = true;
    public bool EnbaleRightTeleport { get; set; } = true;

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        Vector3 pos = new Vector3();
        Vector3 norm = new Vector3();
        int index = 0;
        bool validTarget = false;

        if (leftTeleportRay)
        {
            bool isLefInteractorRayHovering = xRRayInteractorleft.TryGetHitInfo(ref pos, ref norm, ref index, ref validTarget);
           
            leftTeleportRay.gameObject.SetActive(EnbaleLeftTeleport && CheckifActivated(leftTeleportRay) && !isLefInteractorRayHovering);
            if (leftTeleportRay.isActiveAndEnabled)
            {
                TPRectangleLeft.SetActive(true);
            }
            else
            {
                TPRectangleLeft.SetActive(false);
            }
        }

        if (rightTeleportRay)
        {
            bool isRightnteractorRayHovering = xRRayInteractorright.TryGetHitInfo(ref pos, ref norm, ref index, ref validTarget);
            rightTeleportRay.gameObject.SetActive(EnbaleRightTeleport && CheckifActivated(rightTeleportRay) && !isRightnteractorRayHovering);
            if (rightTeleportRay.isActiveAndEnabled)
            {
                TPRectangleRight.SetActive(true);
            }
            else
            {
                TPRectangleRight.SetActive(false);
            }
        }

    }

    public bool CheckifActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleporActivButton, out bool isActivated, activationTreshold);
        return isActivated;
    }
}
