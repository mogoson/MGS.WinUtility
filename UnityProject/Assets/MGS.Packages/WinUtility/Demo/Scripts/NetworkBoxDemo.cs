/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  NetworkBoxDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  20/10/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.WinUtility.Demo
{
    public class NetworkBoxDemo : MonoBehaviour
    {
        public Text txt_State;

        private void Update()
        {
            var state = NetworkUtility.GetNetworkConnectState();
            ShowNetworkConnState(state);
        }

        private void ShowNetworkConnState(NetworkConnState state)
        {
            var stateText = string.Empty;
            if (state == NetworkConnState.OFFLINE)
            {
                stateText = "OFFLINE";
            }
            else if (state == NetworkConnState.ONLINE_MODEM)
            {
                stateText = "ONLINE_MODEM";
            }
            else if (state == NetworkConnState.ONLINE_LAN)
            {
                stateText = "ONLINE_LAN";
            }
            txt_State.text = stateText;
        }
    }
}