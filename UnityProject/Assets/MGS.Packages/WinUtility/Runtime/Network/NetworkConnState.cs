﻿/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  NetworkConnState.cs
 *  Description  :  Define state of network connected state.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  8/8/2019
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.WinUtility
{
    /// <summary>
    /// State of network connected state.
    /// </summary>
    public enum NetworkConnState
    {
        /// <summary>
        /// Local system is in offline mode.
        /// </summary>
        OFFLINE = 0,

        /// <summary>
        /// Local system uses a modem to connect to the Internet.
        /// </summary>
        ONLINE_MODEM = 1,

        /// <summary>
        /// Local system uses a local area network to connect to the Internet.
        /// </summary>
        ONLINE_LAN = 2
    }
}