using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using BepInEx.Unity.IL2CPP.UnityEngine;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.SceneManagement;
using SOD.Common; 
using SOD.Common.Extensions;

namespace MurderMayhem
{
    [HarmonyPatch(typeof(Player), "Update")]
    public class PlayerPatch
    {
        
    }
}