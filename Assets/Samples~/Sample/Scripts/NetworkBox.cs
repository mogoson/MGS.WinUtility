/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  NetworkBox.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  20/10/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.WinUtility.Sample
{
    public class NetworkBox : MonoBehaviour
    {
        public Text txt_State;

        private void Update()
        {
            var state = NetworkUtility.GetNetworkState();
            ShowNetworkConnState(state);
        }

        private void ShowNetworkConnState(NetworkState state)
        {
            var stateText = string.Empty;
            if (state == NetworkState.OFFLINE)
            {
                stateText = "OFFLINE";
            }
            else if (state == NetworkState.ONLINE_MODEM)
            {
                stateText = "ONLINE_MODEM";
            }
            else if (state == NetworkState.ONLINE_LAN)
            {
                stateText = "ONLINE_LAN";
            }
            txt_State.text = stateText;
        }
    }
}