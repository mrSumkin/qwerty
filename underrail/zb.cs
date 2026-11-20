using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012C3 RID: 4803
[eiz("TCX1")]
[Serializable]
public sealed class zb : Aspect<c5x>, ISerializable
{
	// Token: 0x060069EF RID: 27119 RVA: 0x002CAB2C File Offset: 0x002C8D2C
	private zb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("TCX1:L");
		this.c = A_0.GetString("TCX1:O");
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x002CAB68 File Offset: 0x002C8D68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCX1:L", this.b);
		info.AddValue("TCX1:O", this.c);
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x002CAB94 File Offset: 0x002C8D94
	public zb(c5x A_0, string A_1) : base(A_0)
	{
		this.c = A_1;
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x002CABB4 File Offset: 0x002C8DB4
	public void a(double A_0)
	{
		this.b += A_0;
		this.a();
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x002CABCC File Offset: 0x002C8DCC
	public bool b(double A_0)
	{
		this.b -= A_0;
		return this.a();
	}

	// Token: 0x060069F4 RID: 27124 RVA: 0x002CABE4 File Offset: 0x002C8DE4
	public void b()
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		a1q a_ = new a1q(DamageType.Bio, 3 + (int)(this.b * 2.0), 5 + (int)(this.b * 3.0));
		if (!this.b(0.2))
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && !c5x.h.b.aa().Passive && !c5x.h.b.aa().d(CharacterImmunities.AcidPuddles) && c5x.h.b.aa().Defense.af()[DamageType.Acid].c() != 1.0 && c5x.aj().a() == ak.Location)
					{
						cwt cwt = new cwt();
						cwt.i = new ap9("Biomass", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
						cwt.f.Add(euf.a(a_, 1.0));
						cwt.l = true;
						cwt.b = true;
						cwt.w = true;
						c5x.h.b.aa().Defense.a(cwt);
						if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.c == asp.a)
						{
							cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
							if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
							{
								awq.a(serviceOrThrow.aqu().v().b() as c5x, c5x, false, false, true, false, false, false);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060069F5 RID: 27125 RVA: 0x002CAE50 File Offset: 0x002C9050
	public void a(c5x A_0)
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		a1q a_ = new a1q(DamageType.Bio, (int)(2.0 + this.b), (int)(2.0 + this.b * 2.0));
		if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().d(CharacterImmunities.AcidPuddles) && A_0.h.b.aa().Defense.af()[DamageType.Acid].c() != 1.0)
		{
			cwt cwt = new cwt();
			cwt.i = new ap9("Biomass", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
			cwt.f.Add(euf.a(a_, 1.0));
			cwt.l = true;
			cwt.b = true;
			cwt.w = true;
			A_0.h.b.aa().Defense.a(cwt);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.c == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
		}
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x002CB00C File Offset: 0x002C920C
	private bool a()
	{
		if (this.b > 5.0)
		{
			this.b = 5.0;
		}
		if (this.b <= 0.0 && base.a8().Zone != null)
		{
			this.a(0);
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				List<ya> list = ak.a(typeof(d47));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						d47 d = ya as d47;
						if (d != null && d.a() != null && d.a().ao() == this)
						{
							d.o();
						}
					}
				}
			}
			c7 a_ = new c7(base.a8(), true, true, true, false);
			base.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
			return true;
		}
		int a_2 = (int)Math.Round(this.b, 0);
		this.a(a_2);
		return false;
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x002CB15C File Offset: 0x002C935C
	private void a(int A_0)
	{
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
		}
	}

	// Token: 0x04002B96 RID: 11158
	private const double a = 5.0;

	// Token: 0x04002B97 RID: 11159
	private double b = 0.1;

	// Token: 0x04002B98 RID: 11160
	private string c;
}
