using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace TikTokLiveSharp.Client.Proxy
{
    /// <summary>
    /// Proxy with list of rotating Addresses
    /// </summary>
    public class RotatingProxy : IWebProxy
    {
        /// <summary>
        /// List of addresses
        /// </summary>
        public List<string> Addresses;
        /// <summary>
        /// Current Index
        /// </summary>
        private int index;

        /// <summary>
        /// Creates an instance of proxy client factory.
        /// </summary>
        /// <param name="isEnabled">Are proxies enabled.</param>
        /// <param name="settings">The inital rotation settings to use.</param>
        /// <param name="addresses">The list of inital addresses.</param>
        public RotatingProxy(bool isEnabled = false,
            RotationSettings settings = RotationSettings.CONSECUTIVE,
            params string[] addresses)
        {
            IsEnabled = isEnabled;
            Settings = settings;
            Addresses = addresses.ToList();
        }

        /// <summary>
        /// The number of currently available addresses.
        /// </summary>
        public int Count => Addresses.Count;

        /// <summary>
        /// Not implemented
        /// </summary>
        public ICredentials Credentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// The index of the current address.
        /// </summary>
        public int Index
        {
            get => index;
            set
            {
                if (value < 0 || value > Count - 1)
                    throw new IndexOutOfRangeException();
                index = value;
            }
        }

        /// <summary>
        /// Whether this Proxy is enabled
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The rotation settings
        /// </summary>
        public RotationSettings Settings { get; set; }

        /// <summary>
        /// Proxies for Url
        /// </summary>
        /// <param name="destination">Url to Proxy</param>
        /// <returns>Proxied Address</returns>
        public Uri GetProxy(Uri destination)
        {
            if (!IsEnabled || Addresses?.Count <= 0) 
                return destination;
            switch (Settings)
            {
                case RotationSettings.CONSECUTIVE:
                    string address = Addresses[Index];
                    Index = (Index + 1) % Count;
                    return new Uri(address);

                case RotationSettings.RANDOM:
                    Index = new Random().Next(Count - 1);
                    return new Uri(Addresses[Index]);

                case RotationSettings.PINNED:
                    return new Uri(Addresses[Index]);

                default:
                    return destination;
            }
        }
        /// <summary>
        /// Whether this Proxy is Bypassed
        /// <para>
        /// Inverse of IsEnabled
        /// </para>
        /// </summary>
        /// <returns></returns>
        public bool IsBypassed(Uri host)
        {
            return !IsEnabled;
        }
    }
}