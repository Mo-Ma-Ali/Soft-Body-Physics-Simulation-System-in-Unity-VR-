using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SceneSpawner : MonoBehaviour
{
    public Dropdown shapeDropdown;
    public InputField inputX, inputY, inputZ;
    public InputField inputX1, inputY1, inputZ1;
    public Button addButton;

    public List<GameObject> shapePrefabs;

    public GameObject shapeUIPrefab;      
    public Transform canvasPanelParent;  

    void Start()
    {
        addButton.onClick.AddListener(AddShapeToScene);
    }

    void AddShapeToScene()
    {
        int index = shapeDropdown.value;
        if (index < 0 || index >= shapePrefabs.Count)
        {
            Debug.LogWarning("Shape index out of bounds.");
            return;
        }

        if (!float.TryParse(inputX.text, out float x) ||
            !float.TryParse(inputY.text, out float y) ||
            !float.TryParse(inputZ.text, out float z))
        {
            Debug.LogWarning("Invalid position input.");
            return;
        }
        if (!float.TryParse(inputX1.text, out float x1) ||
            !float.TryParse(inputY1.text, out float y1) ||
            !float.TryParse(inputZ1.text, out float z1))
        {
            Debug.LogWarning("Invalid position input.");
            return;
        }

        Vector3 position = new Vector3(x, y, z);
        Vector3 Velocuty = new Vector3(x1, y1, z1);

        GameObject shapeInstance = Instantiate(shapePrefabs[index], position, Quaternion.identity);

        MeshObject1 meshObj = shapeInstance.GetComponentInChildren<MeshObject1>();

        if (meshObj == null)
        {
            Debug.LogError("❌ MeshObject1 not found in the spawned shape prefab.");
            return;
        }
        GameObject ui = Instantiate(shapeUIPrefab, canvasPanelParent);
        ShapeUIController controller = ui.GetComponent<ShapeUIController>();
        if (controller == null)
        {
            Debug.LogError("❌ ShapeUIController not found on shapeUIPrefab.");
            return;
        }
        meshObj.SetDefaults();
        meshObj.SetInitialVelocity(Velocuty);

        controller.Initialize(meshObj);

    }
}
