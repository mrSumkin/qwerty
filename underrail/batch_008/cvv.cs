using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B7D RID: 2941
[eiz("CCPTDCJ")]
[Serializable]
public sealed class cvv : cze, ISerializable
{
	// Token: 0x0600432D RID: 17197 RVA: 0x001A4260 File Offset: 0x001A2460
	private cvv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x001A426C File Offset: 0x001A246C
	public cvv()
	{
	}

	// Token: 0x0600432F RID: 17199 RVA: 0x001A4278 File Offset: 0x001A2478
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_sergiosDen_timesSmokedShishaAfterKillingSergio", new int?(0)).Value > 3)
			{
				c5x c5x2 = A_1 as c5x;
				if (c5x2 != null && c5x2.s.b != null)
				{
					c5x2.s.b.g(false);
					alv aspect = c5x2.GetAspect<alv>();
					if (aspect != null)
					{
						etz etz = aspect.a[0] as etz;
						etz.c(1);
						etz.c = new Color?(new Color(220, 220, 220, 255));
						aspect.a[0] = etz;
					}
					if (c5x != null && c5x.u.b != null)
					{
						c5x.u.b.a("Хм-м-м... Я не вхожу в движение.", true, null, null);
					}
					return;
				}
			}
			serviceOrThrow.aqu().r()["npc_cc_sergio_youGotInMotion"] = true;
			bpo.GetServiceOrThrow<ps>();
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didTannerTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didTannerTrip"] = true;
				this.a("Cc_TrippyDrugs1", c5x);
				return;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didSurgeryTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didSurgeryTrip"] = true;
				this.a("Cc_TrippyDrugs2", c5x);
				return;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didCliffTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didCliffTrip"] = true;
				this.a("Cc_TrippyDrugs3", c5x);
				return;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didFacelessTrip", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didFacelessTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didFacelessTrip"] = true;
				this.a("Cc_TrippyDrugs4", c5x);
				return;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didSpinningTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didSpinningTrip"] = true;
				this.a("Cc_TrippyDrugs5", c5x);
				return;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sergio_didSquareTrip", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["npc_cc_sergio_didSquareTrip"] = true;
				this.a("Cc_TrippyDrugs6", c5x);
				return;
			}
			this.a("Cc_TrippyDrugs" + cuo.a.Next(1, 7).ToString(), c5x);
		}
	}

	// Token: 0x06004330 RID: 17200 RVA: 0x001A45EC File Offset: 0x001A27EC
	public void a(string A_0, c5x A_1)
	{
		bpo.GetServiceOrThrow<ps>().am3(A_0);
		c7w.a(A_1, 30);
	}
}
