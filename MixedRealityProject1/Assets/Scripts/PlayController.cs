using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    bool rockFound = false;
    bool paperFound = false;
    bool scissorsFound = false;
    public Text winMessage;

    public void RockFound()
    {
        rockFound = true;
    }

    public void PaperFound()
    {
        paperFound = true;
    }

    public void ScissorsFound()
    {
        scissorsFound = true;
    }
    public void RockLost()
    {
        rockFound = false;
    }

    public void PaperLost()
    {
        paperFound = false;
    }

    public void ScissorsLost()
    {
        scissorsFound = false;
    }

    public void WhoWins ()
    {
        winMessage.text = "The someone wins!";

        if (rockFound)
        {
            winMessage.text = "I found a rock";
        }
        if (paperFound)
        {
            winMessage.text = "I found some paper";
        }
        if (scissorsFound)
        {
            winMessage.text = "I found the scissors";
        }
        if (scissorsFound && rockFound)
        {
            winMessage.text = "Oh gosh, you rock! You are so hard! The Rock wins!";
        }

        if (paperFound && rockFound)
        {
            winMessage.text = "The tree power man... What can you do? Seems like Paper wins!";
        }

        if (scissorsFound && paperFound)
        {
            winMessage.text = "Damn, he cut you off!! Yep, those Scissors win this time!";
        }
    }

}
