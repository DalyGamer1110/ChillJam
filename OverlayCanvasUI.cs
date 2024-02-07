using UnityEngine;

public class OverlayCanvas : MonoBehaviour
{
    public GameObject pauseGameComponent;
    public GameObject shopComponent;
    public GameObject pauseMenu;
    public GameObject victoryMenu;
    public GameObject gameOverMenu;
    public GameObject dialogueTextBox;

    // Use this method to toggle the Pause Game component
    public void TogglePauseGame()
    {
        if (pauseGameComponent != null)
        {
            pauseGameComponent.SetActive(!pauseGameComponent.activeSelf);
            // You can add more logic, like pausing the game, here
        }
    }

    // Use this method to toggle the Shop component
    public void ToggleShop()
    {
        if (shopComponent != null)
        {
            shopComponent.SetActive(!shopComponent.activeSelf);
            // You can add more logic related to the shop here
        }
    }

    // Use this method to show/hide the Pause Menu
    public void TogglePauseMenu()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            // You can add more logic related to the pause menu here
        }
    }

    // Use this method to show/hide the Victory Menu
    public void ToggleVictoryMenu()
    {
        if (victoryMenu != null)
        {
            victoryMenu.SetActive(!victoryMenu.activeSelf);
            // You can add more logic related to the victory menu here
        }
    }

    // Use this method to show/hide the Game Over Menu
    public void ToggleGameOverMenu()
    {
        if (gameOverMenu != null)
        {
            gameOverMenu.SetActive(!gameOverMenu.activeSelf);
            // You can add more logic related to the game over menu here
        }
    }

    // Use this method to set the text in the Dialogue Text Box
    public void SetDialogueText(string text)
    {
        if (dialogueTextBox != null)
        {
            // You can use the UI text component to display the dialogue
            dialogueTextBox.GetComponent<UnityEngine.UI.Text>().text = text;
        }
    }
}
