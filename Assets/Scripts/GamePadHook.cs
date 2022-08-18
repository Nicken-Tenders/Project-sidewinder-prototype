using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LeoLuz
{
    public class GamePadHook : MonoBehaviour
    {
        public InputAction.CallbackContext Context;

        public void GamePadInput(InputAction.CallbackContext context)
        {
            Context = context;
        }
    }
}