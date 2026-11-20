using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012C1 RID: 4801
[eiz("PBG5")]
[Serializable]
public sealed class a4b : cry, ISerializable, chb, c98
{
	// Token: 0x060069DB RID: 27099 RVA: 0x002C9DCC File Offset: 0x002C7FCC
	private a4b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x002C9DD8 File Offset: 0x002C7FD8
	public override string gv()
	{
		return "psimorphicBiocide";
	}

	// Token: 0x060069DD RID: 27101 RVA: 0x002C9DE0 File Offset: 0x002C7FE0
	public override bool gw()
	{
		return true;
	}

	// Token: 0x060069DE RID: 27102 RVA: 0x002C9DE4 File Offset: 0x002C7FE4
	protected override bool ur()
	{
		return true;
	}

	// Token: 0x060069DF RID: 27103 RVA: 0x002C9DE8 File Offset: 0x002C7FE8
	public a4b(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x060069E0 RID: 27104 RVA: 0x002C9DF4 File Offset: 0x002C7FF4
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && (A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0 || A_0.h.b.aa().FactionId == asp.e6))
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("Toxic gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.a(a_), 0.33));
			cwt.l = true;
			cwt.v = "токсичный газ";
			cwt.b = true;
			cwt.w = true;
			cwt.ad["IsToxicGas"] = true;
			if (A_0.h.b.aa().FactionId == asp.e6)
			{
				cwt.p = true;
			}
			A_0.h.b.aa().Defense.a(cwt);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && base.d() == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
		}
	}

	// Token: 0x060069E1 RID: 27105 RVA: 0x002C9FFC File Offset: 0x002C81FC
	protected override void gy(c5x A_0)
	{
		this.a(A_0);
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e))
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("Toxic gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.a(a_), 1.0));
			cwt.l = true;
			cwt.v = "токсичный газ";
			cwt.b = true;
			cwt.w = true;
			if (A_0.h.b.aa().FactionId == asp.e6)
			{
				cwt.p = true;
			}
			A_0.h.b.aa().Defense.a(cwt);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && base.d() == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
		}
	}

	// Token: 0x060069E2 RID: 27106 RVA: 0x002CA194 File Offset: 0x002C8394
	private void a(c5x A_0)
	{
		if (A_0 != null)
		{
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect != null && aspect.a.Contains("tchortBarricade"))
			{
				A_0.RemoveAspect<e3l>();
				awx awx = new awx();
				awx.b(false);
				awx.c(false);
				c4f c4f = new c4f();
				c4f.Properties["loc_dc_gateSlimeRemoved"] = true;
				List<auv> list = awx.ad();
				ad6 ad = new ad6(A_0);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(0.0005);
				list.Add(ad);
				List<auv> list2 = awx.ad();
				c7 c = new c7(A_0, false, false, true, false);
				c.a(true);
				list2.Add(c);
				awx.ad().Add(new a4s(c4f, null, null, null));
				A_0.Zone.ActionManager.g9(awx, atp.a);
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqz() != null)
				{
					serviceOrThrow.aqz().atc("dc_removeEntanglement", true);
				}
				foreach (b0b b0b in A_0.Area.Entities)
				{
					c5x c5x = (c5x)b0b;
					e3l aspect2 = c5x.GetAspect<e3l>();
					if (aspect2 != null && aspect2.a.Contains("tchortBarricade"))
					{
						c5x.RemoveAspect<e3l>();
						awx awx2 = new awx();
						awx2.b(false);
						awx2.c(false);
						List<auv> list3 = awx2.ad();
						ad6 ad2 = new ad6(c5x);
						ad2.b(1.0);
						ad2.c(0.0);
						ad2.a(0.0005);
						list3.Add(ad2);
						List<auv> list4 = awx2.ad();
						c7 c2 = new c7(c5x, false, false, true, false);
						c2.a(true);
						list4.Add(c2);
						c5x.Zone.ActionManager.g9(awx2, atp.a);
					}
				}
			}
		}
	}
}
