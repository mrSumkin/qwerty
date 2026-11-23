using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B9A RID: 2970
[eiz("XPBLMRIMFJ")]
[Serializable]
public sealed class ect : cze, ISerializable
{
	// Token: 0x06004394 RID: 17300 RVA: 0x001A8238 File Offset: 0x001A6438
	private ect(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004395 RID: 17301 RVA: 0x001A8244 File Offset: 0x001A6444
	public ect()
	{
	}

	// Token: 0x06004396 RID: 17302 RVA: 0x001A8250 File Offset: 0x001A6450
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
				d60 d = aud.Zone.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"dsp_xpbl_mc2_servants",
						"xpbl_mc2_servants"
					});
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_mriActivated", new bool?(false)).Value)
					{
						if (list != null && Enumerable.Any<b0b>(list))
						{
							foreach (b0b b0b in list)
							{
								c5x c5x = (c5x)b0b;
								if (c5x != null && !c5x.a("xpbl_mc2_servantsAffectedByMRI") && c5x.Location.X >= 11f && c5x.Location.X < 23f && c5x.Location.Y >= 14f && c5x.Location.Y < 25f)
								{
									c5x.h.b.aa().StatusEffects.a(new clt(0), false, false, false);
									c5x.h.b.aa().FactionId = asp.a3;
									c5x.h.b.aa().Passive = true;
									c5x.h.b.aa().c(asp.a);
									cgh.b(c5x);
									c5x.b("xpbl_mc2_servantsAffectedByMRI");
								}
							}
						}
						c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
						if (c5x2 != null && c5x2.h.b != null && c5x2.Location.X >= 11f && c5x2.Location.X < 23f && c5x2.Location.Y >= 14f && c5x2.Location.Y < 25f && serviceOrThrow.aqu().v().Gear.l().Item != null && serviceOrThrow.aqu().v().Gear.l().Item.fu().d().GetValueOrDefault() == ai5.g)
						{
							c5x2.h.b.aa().StatusEffects.a(new ab2(0.7f, 10, 0.3f, 1500), false, false, false);
							return;
						}
					}
					else if (list != null && Enumerable.Any<b0b>(list))
					{
						foreach (b0b b0b2 in list)
						{
							c5x c5x3 = (c5x)b0b2;
							if (c5x3 != null && c5x3.a("xpbl_mc2_servantsAffectedByMRI"))
							{
								clt clt = Enumerable.FirstOrDefault<clt>(c5x3.h.b.aa().StatusEffects.Get<clt>());
								if (clt != null)
								{
									c5x3.h.b.aa().StatusEffects.d(clt);
								}
								c5x3.h.b.aa().Passive = false;
								c5x3.h.b.aa().FactionId = asp.f9;
								c5x3.h.b.aa().a(asp.a, h.a);
								e3l aspect = c5x3.GetAspect<e3l>();
								if (aspect != null)
								{
									aspect.a.Remove("xpbl_mc2_servantsAffectedByMRI");
								}
							}
						}
					}
				}
			}
		}
	}
}
