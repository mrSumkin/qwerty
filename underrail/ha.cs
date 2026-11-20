using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000972 RID: 2418
[eiz("DCSRK")]
[Serializable]
public sealed class ha : bdw, ISerializable
{
	// Token: 0x06003AC3 RID: 15043 RVA: 0x0015CAA4 File Offset: 0x0015ACA4
	private ha(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x0015CAAC File Offset: 0x0015ACAC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x0015CAB0 File Offset: 0x0015ACB0
	public ha()
	{
	}

	// Token: 0x06003AC6 RID: 15046 RVA: 0x0015CABC File Offset: 0x0015ACBC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow != null)
		{
			aud aud = A_0.n("dc-rh");
			if (aud != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rathoundKing_flees", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-rh_importedRHstuff", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["loc_dc-rh_importedRHstuff"] = true;
				serviceOrThrow.aqu().r()["rathoundKing_met"] = false;
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-rh_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				d02 serviceOrThrow2 = bpo.GetServiceOrThrow<d02>();
				if (serviceOrThrow2 != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(serviceOrThrow2.ahl()))
					{
						if (d4n.b != null && d4n.b.aa().FactionId == asp.av)
						{
							d4n.b.aa().FactionId = asp.cy;
						}
					}
				}
				c5x c5x = new ar7(new Guid("232f640f-1c40-4340-b7e2-01050496e885"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("9a0b7923-0024-48e8-b2f2-6170713cc112"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("bd2d41ba-a3a7-4880-970e-a9fca148b4fc"), aud).ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "guard_ancient", true);
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						aspect.b("soldierPatrol");
						aspect.y6()[ddq.ay] = new bt4("guard_ancient");
					}
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "guard_alpha", true);
					bm6 aspect2 = c5x2.GetAspect<bm6>();
					if (c5x2 != null)
					{
						aspect2.b("soldierPatrol");
						aspect2.y6()[ddq.ay] = new bt4("guard_alpha");
					}
				}
				if (c5x3 != null)
				{
					amc aspect3 = c5x3.GetAspect<amc>();
					aspect3.aa().c(asp.a);
					(serviceOrThrow.aqu().ac() as bv9).a(asp.cy, asp.a, h.c, null, true, false, false);
					if (aspect3 != null)
					{
						aspect3.aa().Defense.a(1000, null, null, false, false, false, null);
						aspect3.aa().Level = 25;
						aspect3.aa().Skills.Get<e5n>().a(135);
						aspect3.aa().Skills.Get<e74>().a(120);
						aspect3.aa().Skills.Get<erc>().a(120);
						aspect3.aa().Skills.Get<c0b>().a(135);
						aspect3.aa().Skills.Get<dei>().a(135);
					}
				}
				serviceOrThrow.aqu().r()["loc_dc-rh_importedRHstuff"] = true;
			}
		}
	}
}
