﻿using Sandbox;
using Sandbox.UI;

namespace Cinema.UI
{
	[Library]
	public class CinemaHud : HudEntity<RootPanel>
	{
		public CinemaHud()
		{
			if ( !IsClient ) return;

			RootPanel.AddChild<VideoStreamPanel>();
			RootPanel.AddChild<VideoRequestPanel>();
			RootPanel.AddChild<CinemaInfoPanel>();
			RootPanel.AddChild<ChatBox>();
		}
	}
}
