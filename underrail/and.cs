using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x0200126E RID: 4718
[eiz("WPGEA")]
[Serializable]
public sealed class and : cry, ISerializable, chb, c98
{
	// Token: 0x06006655 RID: 26197 RVA: 0x002B8078 File Offset: 0x002B6278
	private and(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006656 RID: 26198 RVA: 0x002B8084 File Offset: 0x002B6284
	public override string gv()
	{
		return "whitePhosphorusGas";
	}

	// Token: 0x06006657 RID: 26199 RVA: 0x002B808C File Offset: 0x002B628C
	public override bool gw()
	{
		return true;
	}

	// Token: 0x06006658 RID: 26200 RVA: 0x002B8090 File Offset: 0x002B6290
	public override double q4()
	{
		return 3.0;
	}

	// Token: 0x06006659 RID: 26201 RVA: 0x002B809C File Offset: 0x002B629C
	public and(c5x A_0, string A_1, Guid? A_2) : base(A_0, A_1, A_2)
	{
	}

	// Token: 0x0600665A RID: 26202 RVA: 0x002B80AC File Offset: 0x002B62AC
	public override void gx(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa().Defense.af()[DamageType.Heat].c() < 1.0)
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("White phosphorus", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.c(a_), 0.33));
			cwt.l = true;
			cwt.v = "white phosphorus";
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
	}

	// Token: 0x0600665B RID: 26203 RVA: 0x002B8218 File Offset: 0x002B6418
	protected override void gy(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa().Defense.af()[DamageType.Heat].c() < 1.0 && (A_0.h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0 || A_0.IsPlayer))
		{
			ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
			int a_ = base.f();
			cwt cwt = new cwt();
			cwt.i = new ap9("White phosphorus", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? base.d() : null);
			cwt.f.Add(euf.a(c18.c(a_), 1.0));
			cwt.l = true;
			cwt.v = "white phosphorus";
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
	}
}
