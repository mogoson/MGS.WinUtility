/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  WinNetworkUtility.cs
 *  Description  :  Utility for windows network.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  8/8/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace MGS.WinUtility
{
    /// <summary>
    /// Utility for windows network.
    /// </summary>
    public sealed class NetworkUtility
    {
        /// <summary>
        /// Retrieves the connected state of the local system.
        /// </summary>
        /// <returns>The connected state of the local system.</returns>
        public static NetworkState GetNetworkState()
        {
            uint lpdwFlags;
            if (Wininet.InternetGetConnectedState(out lpdwFlags, 0))
            {
                if ((lpdwFlags & InetFlags.INTERNET_CONNECTION_MODEM) != 0)
                {
                    return NetworkState.ONLINE_MODEM;
                }
                else if ((lpdwFlags & InetFlags.INTERNET_CONNECTION_LAN) != 0)
                {
                    return NetworkState.ONLINE_LAN;
                }
            }
            return NetworkState.OFFLINE;
        }

        /// <summary>
        /// Get the mac address of pc.
        /// </summary>
        /// <returns>Mac address of pc.</returns>
        public static ICollection<string> GetMacAddress()
        {
            var macAdress = new List<string>();
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in interfaces)
            {
                var physicalAddress = item.GetPhysicalAddress();
                if (physicalAddress == null)
                {
                    continue;
                }

                var addressBytes = physicalAddress.GetAddressBytes();
                if (addressBytes == null)
                {
                    continue;
                }

                var adress = BitConverter.ToString(addressBytes);
                macAdress.Add(adress);
            }
            return macAdress;
        }
    }
}