using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B0F RID: 2831
[eiz("XPBLPDCJ")]
[Serializable]
public sealed class d0 : cze, ISerializable
{
	// Token: 0x0600417D RID: 16765 RVA: 0x00191500 File Offset: 0x0018F700
	private d0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x0019150C File Offset: 0x0018F70C
	public d0()
	{
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x00191518 File Offset: 0x0018F718
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_totalPiratesKilled", new int?(0)).Value;
				serviceOrThrow.aqu().r()["faction_xpbl_pirates_totalPiratesKilled"] = value + 1;
				int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_jetPiratesKilled", new int?(0)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_outskirtPiratesKilled", new int?(0)).Value;
				int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_cragPiratesKilled", new int?(0)).Value;
				if (A_1 != null)
				{
					amc aspect = A_1.GetAspect<amc>();
					if (aspect != null)
					{
						if (aspect.aa().FactionId == asp.ft)
						{
							serviceOrThrow.aqu().r()["faction_xpbl_pirates_jetPiratesKilled"] = value2 + 1;
							return;
						}
						if (aspect.aa().FactionId == asp.fu)
						{
							serviceOrThrow.aqu().r()["faction_xpbl_pirates_outskirtPiratesKilled"] = value3 + 1;
							return;
						}
						if (aspect.aa().FactionId == asp.fs)
						{
							serviceOrThrow.aqu().r()["faction_xpbl_pirates_cragPiratesKilled"] = value4 + 1;
							return;
						}
						if (aspect.aa().FactionId == asp.fr)
						{
							serviceOrThrow.aqu().r()["faction_xpbl_pirates_totalHostility"] = true;
						}
					}
				}
			}
		}
	}
}
