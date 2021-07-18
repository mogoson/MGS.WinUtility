/*************************************************************************
 *  Copyright © 2019 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  NetworkBox.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  20/10/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using MGS.WinCommon.Network;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.WinUtility.Demo
{
    public class NetworkBox : MonoBehaviour
    {
        #region Field and Property
        public Text txt_State;
        #endregion

        #region Protected Method
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
        #endregion
    }
}