using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.HabboHotel.Items;
namespace GoldTree.HabboHotel.Items.Interactors
{
	internal sealed class InteractorHabboWheel : FurniInteractor
	{
		public override void OnPlace(GameClient Session, RoomItem RoomItem_0)
		{
			RoomItem_0.ExtraData = "-1";
			RoomItem_0.ReqUpdate(10);
		}
		public override void OnRemove(GameClient Session, RoomItem RoomItem_0)
		{
			RoomItem_0.ExtraData = "-1";
		}
		public override void OnTrigger(GameClient Session, RoomItem RoomItem_0, int int_0, bool bool_0)
		{
			if (bool_0 && RoomItem_0.ExtraData != "-1")
			{
				RoomItem_0.ExtraData = "-1";
				RoomItem_0.method_4();
				RoomItem_0.ReqUpdate(10);
			}
		}
	}
}
