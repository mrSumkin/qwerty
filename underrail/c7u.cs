using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AB7 RID: 2743
[eiz("UPALWA")]
[Serializable]
public sealed class c7u : cze, ISerializable
{
	// Token: 0x0600400F RID: 16399 RVA: 0x00184B8C File Offset: 0x00182D8C
	private c7u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x00184B98 File Offset: 0x00182D98
	public c7u()
	{
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x00184BA4 File Offset: 0x00182DA4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null && A_1.Area != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("up_lw_alarmState", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["up_lw_alarmState"] = true;
			d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					"alarmSpeaker"
				});
				if (list != null && list.Count > 0)
				{
					foreach (b0b b0b in list)
					{
						((c5x)b0b).c().a("alarm", "PrisonAlarm", 0.3f, c9z.b, true, false);
					}
				}
			}
			ah7 ah = serviceOrThrow.aqw().i("interior");
			if (ah != null)
			{
				ah.Light = new ae8(new Color(255, 25, 25), ah.Light.c(), ah.Light.a());
				ah.d();
			}
			this.a("f0956c39-e0b6-492f-8e08-80c7098a76b7", A_1.Zone, "cmnAlert1");
			this.a("664d2625-71dc-47b2-9f43-7e487a9c32a4", A_1.Zone, "cmnAlert2");
			this.a("2679f887-24a6-4e31-ba75-eb9494c09d56", A_1.Zone, "alert1");
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_FreeDrones_joined", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "up-lw_l3") + ".uzl");
				A_1.Zone.a(a_, 1, null);
			}
		}
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x00184DA4 File Offset: 0x00182FA4
	private void a(string A_0, c1a A_1, string A_2)
	{
		foreach (aud a_ in A_1.Areas)
		{
			c5x c5x = new ar7(new Guid("f0956c39-e0b6-492f-8e08-80c7098a76b7"), a_).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4(A_2);
			}
		}
	}
}
