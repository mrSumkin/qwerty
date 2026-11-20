using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012A6 RID: 4774
[eiz("HGEA2")]
[Serializable]
public sealed class d4c : cry, ISerializable, chb, c98
{
	// Token: 0x06006872 RID: 26738 RVA: 0x002C2860 File Offset: 0x002C0A60
	private d4c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006873 RID: 26739 RVA: 0x002C286C File Offset: 0x002C0A6C
	public override string gv()
	{
		return "herbicideGas";
	}

	// Token: 0x06006874 RID: 26740 RVA: 0x002C2874 File Offset: 0x002C0A74
	public override bool gw()
	{
		return true;
	}

	// Token: 0x06006875 RID: 26741 RVA: 0x002C2878 File Offset: 0x002C0A78
	protected override bool ur()
	{
		return true;
	}

	// Token: 0x06006876 RID: 26742 RVA: 0x002C287C File Offset: 0x002C0A7C
	public d4c(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x06006877 RID: 26743 RVA: 0x002C288C File Offset: 0x002C0A8C
	public override void gx(c5x A_0)
	{
		if (A_0 != null)
		{
			if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e) && A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)
			{
				ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
				int a_ = base.f();
				bool flag = A_0.h.b.aa().c(d8o.i);
				cwt cwt = new cwt();
				cwt.i = new ap9("Pesticide gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
				cwt.f.Add(euf.a(c18.a(a_, flag), 0.33));
				cwt.l = true;
				cwt.p = flag;
				cwt.v = "пестицидный газ";
				cwt.b = true;
				cwt.w = true;
				cwt.ad["IsToxicGas"] = true;
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
			d8r aspect = A_0.GetAspect<d8r>();
			if (aspect != null)
			{
				aspect.tt(base.f(), true);
			}
		}
	}

	// Token: 0x06006878 RID: 26744 RVA: 0x002C2A90 File Offset: 0x002C0C90
	protected override void gy(c5x A_0)
	{
		this.a(A_0);
		if (A_0 != null)
		{
			if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().b(d8o.e))
			{
				ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
				int a_ = base.f();
				bool flag = A_0.h.b.aa().c(d8o.i);
				cwt cwt = new cwt();
				cwt.i = new ap9("Pesticide gas", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
				cwt.f.Add(euf.a(c18.a(a_, flag), 1.0));
				cwt.l = true;
				cwt.p = flag;
				cwt.v = "пестицидный газ";
				cwt.b = true;
				cwt.w = true;
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
			d8r aspect = A_0.GetAspect<d8r>();
			if (aspect != null)
			{
				aspect.tt(base.f(), false);
			}
		}
	}

	// Token: 0x06006879 RID: 26745 RVA: 0x002C2C44 File Offset: 0x002C0E44
	private void a(c5x A_0)
	{
	}
}
