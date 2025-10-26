using UnityEngine;
using UnityEngine.UI;

public class ShapeUIController : MonoBehaviour
{
    public Toggle simulationToggle;
    public Button deleteButton;
    public InputField K_Vlaue;
    public InputField M_Vlaue, Damping_Value, StiffnessFactor_Value, PlasticThreshold_Value, DragCoefficient, FrictionCoefficient, γ;

    private MeshObject1 targetObject;

    private void Start()
    {
        targetObject.isSimulating = false;                    

    }
    public void Initialize(MeshObject1 meshObject)
    {
        targetObject = meshObject;
        //targetObject.SetDefaults();
        //Vector3 pos = transform.position;
        //pos.x = meshObject.transform.position.x;
        //transform.position = pos;
        simulationToggle.onValueChanged.RemoveAllListeners(); 
        simulationToggle.isOn = false;                       
        targetObject.isSimulating = false;                         

        // ثم أضف الـ listener
        simulationToggle.onValueChanged.AddListener((on) =>
        {
            if (targetObject != null)
                targetObject.isSimulating = on;
        });

        deleteButton.onClick.AddListener(() =>
        {
            Destroy(targetObject.gameObject);
            Destroy(gameObject);
        });

        UpdateUIFromTarget();

        K_Vlaue.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.K_Value = f));
        M_Vlaue.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.M_Value = f));
        Damping_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.Damping_Value = f));
        StiffnessFactor_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.StiffnessFactor_Value = f));
        PlasticThreshold_Value.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.PlasticThreshold_Value = f));
        DragCoefficient.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.DragCoefficient = f));
        FrictionCoefficient.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.FrictionCoefficient = f));
        γ.onEndEdit.AddListener(val => TrySetFloat(val, f => targetObject.γ = f));
    }

    private void TrySetFloat(string value, System.Action<float> setter)
    {
        if (float.TryParse(value, out float result))
        {
            setter(result);
        }
    }

    private void UpdateUIFromTarget()
    {

        K_Vlaue.text = targetObject.K_Value.ToString();
        M_Vlaue.text = targetObject.M_Value.ToString();
        Damping_Value.text = targetObject.Damping_Value.ToString();
        StiffnessFactor_Value.text = targetObject.StiffnessFactor_Value.ToString();
        PlasticThreshold_Value.text = targetObject.PlasticThreshold_Value.ToString();
        DragCoefficient.text = targetObject.DragCoefficient.ToString();
        FrictionCoefficient.text = targetObject.FrictionCoefficient.ToString();
        γ.text = targetObject.γ.ToString();
    }
}
