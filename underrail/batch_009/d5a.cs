using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000BA3 RID: 2979
[eiz("XPBLSNGL")]
[Serializable]
public sealed class d5a : cze, ISerializable
{
	// Token: 0x060043B0 RID: 17328 RVA: 0x001A98E4 File Offset: 0x001A7AE4
	private d5a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x001A98F0 File Offset: 0x001A7AF0
	public d5a()
	{
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x001A98FC File Offset: 0x001A7AFC
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
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_naga_setGuard", new bool?(false)).Value)
			{
				d60 d = aud.Zone.a();
				if (d != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
					{
						"xpbl_e5_damagedNaga"
					})) as c5x;
					if (c5x != null)
					{
						bm6 aspect = c5x.GetAspect<bm6>();
						if (aspect != null)
						{
							aspect.y6()[ddq.k] = new List<string>
							{
								"naga_patrol1",
								"naga_patrol2",
								"naga_patrol3",
								"naga_patrol2"
							};
							aspect.y6()[ddq.l] = 12000;
							aspect.y6()[ddq.n] = true;
							serviceOrThrow.aqu().r()["loc_xpbl_e5_naga_setGuard"] = true;
						}
						c5x = this.a(c5x);
						bn5 bn = c5x.GetAspect<j7>() as bn5;
						if (bn == null)
						{
							bn = new bn5(c5x);
							c5x.SetAspect<j7>(bn);
						}
						bn.b("support\\xpbl\\le_damagedNaga");
						bn.a("speaker");
						bn.a(false);
						bn.b(true);
						egx egx = new egx();
						egx.a("Защитник доступен.");
						egx.ym(null, c5x, null);
					}
				}
			}
		}
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x001A9ADC File Offset: 0x001A7CDC
	public c5x a(c5x A_0)
	{
		a6p aspect = A_0.GetAspect<a6p>();
		if (aspect != null)
		{
			aspect.d().Add("-jobs");
		}
		if (A_0.h.b != null)
		{
			c4f c4f = new c4f();
			c4f.Properties["npc_xpbl_e5_naga_died"] = true;
			c4f.Properties["loc_xpbl_nagaOnTheLoose"] = null;
			A_0.h.b.ay().Add(c4f);
		}
		return A_0;
	}
}
