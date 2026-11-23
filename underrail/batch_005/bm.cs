using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B58 RID: 2904
[eiz("JYRFTGTF")]
[Serializable]
public sealed class bm : cze, ISerializable
{
	// Token: 0x06004292 RID: 17042 RVA: 0x0019CFDC File Offset: 0x0019B1DC
	private bm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x0019CFE8 File Offset: 0x0019B1E8
	public bm()
	{
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x0019CFF4 File Offset: 0x0019B1F4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && new ar7(new Guid("dd16c89e-9cc6-4568-abfd-75d1e1892f6f"), serviceOrThrow.aqw().n("jy3")).ao() is c5x)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveAnglerfish", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveBlackDragon", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveDemonSquid", new bool?(false)).Value;
			bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveGhostface", new bool?(false)).Value;
			bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveMinihead", new bool?(false)).Value;
			bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gavePentapus", new bool?(false)).Value;
			bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gavePhantomJelly", new bool?(false)).Value;
			bool value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveShrimp", new bool?(false)).Value;
			bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveSlackjaw", new bool?(false)).Value;
			bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_gaveWalkingFish", new bool?(false)).Value;
			bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jy_ford_caughtThemAll", new bool?(false)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_jy_ford_numberOfActiveItems", new int?(0)).Value;
			string text = "";
			if (!value)
			{
				text += " удильщика,";
				num++;
			}
			if (!value2)
			{
				text += " чёрного дракона,";
				num++;
			}
			if (!value3)
			{
				text += " демонического кальмара,";
				num++;
			}
			if (!value4)
			{
				text += " фантома,";
				num++;
			}
			if (!value5)
			{
				text += " минимолота,";
				num++;
			}
			if (!value6)
			{
				text += " пятинога,";
				num++;
			}
			if (!value7)
			{
				text += " призрачный студень,";
				num++;
			}
			if (!value8)
			{
				text += " креветку,";
				num++;
			}
			if (!value9)
			{
				text += " разирота,";
				num++;
			}
			if (!value10)
			{
				text += " ходячую рыбу,";
				num++;
			}
			if (num == 0)
			{
				serviceOrThrow.aqu().r()["npc_jy_ford_caughtThemAll"] = true;
				return;
			}
			text = text.TrimEnd(new char[]
			{
				','
			});
			text += ".";
			serviceOrThrow.aqu().r()["npc_jy_ford_whatHeNeeds"] = text;
		}
	}
}
