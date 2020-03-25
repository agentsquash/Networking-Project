using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace GameServer
{
	class Server
	{
		protected string ExternalIP;
		protected string InternalIP;

		public Server()
		{
			InternalIP = "127.0.0.1";

		}

		/// <summary>
		/// This method fetches the IPV4 address of the user establishing the server.
		/// It does this from an online source; partly because its easier, but also
		/// it allows to check if the user is connected to the internet for online play.
		/// </summary>
		private void FetchIPAddress()
		{
			ExternalIP = new WebClient().DownloadString("http://ipv4.icanhazip.com/");

		}
	}
}
