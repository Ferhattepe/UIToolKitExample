using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    private Label counterLabel;
    private Button counterButton;
    private int count;

    private void OnEnable()
    {
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        counterLabel = rootVisualElement.Q<Label>("counter-label");
        counterButton = rootVisualElement.Q<Button>("counter-button");
        counterButton.clicked += IncrementCounter;
    }

    private void IncrementCounter()
    {
        count++;
        counterLabel.text = $"Count: {count}";
    }
}
