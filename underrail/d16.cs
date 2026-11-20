using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012AC RID: 4780
[eiz("RCX8")]
[Serializable]
public sealed class d16 : Aspect<c5x>, ISerializable
{
	// Token: 0x060068D4 RID: 26836 RVA: 0x002C47F8 File Offset: 0x002C29F8
	private d16(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("RCX8:L");
		this.c = A_0.GetString("RCX8:O");
	}

	// Token: 0x060068D5 RID: 26837 RVA: 0x002C4834 File Offset: 0x002C2A34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCX8:L", this.b);
		info.AddValue("RCX8:O", this.c);
	}

	// Token: 0x060068D6 RID: 26838 RVA: 0x002C4860 File Offset: 0x002C2A60
	public d16(c5x A_0, string A_1) : base(A_0)
	{
		this.c = A_1;
	}

	// Token: 0x060068D7 RID: 26839 RVA: 0x002C4880 File Offset: 0x002C2A80
	public void b(double A_0)
	{
		this.b += A_0;
		this.a();
	}

	// Token: 0x060068D8 RID: 26840 RVA: 0x002C4898 File Offset: 0x002C2A98
	public bool a(double A_0)
	{
		this.b -= A_0;
		return this.a();
	}

	// Token: 0x060068D9 RID: 26841 RVA: 0x002C48B4 File Offset: 0x002C2AB4
	public void b()
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		a1q a_ = new a1q(DamageType.Acid, 3 + (int)(this.b * 2.0), 5 + (int)(this.b * 3.0));
		if (!this.a(0.2))
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && !c5x.h.b.aa().Passive && !c5x.h.b.aa().d(CharacterImmunities.AcidPuddles) && c5x.h.b.aa().Defense.af()[DamageType.Acid].c() != 1.0 && c5x.aj().a() == ak.Location)
					{
						double num = 1.0;
						if (c5x.h.b.aa().c(d8o.e))
						{
							num += d9b.a;
						}
						cwt cwt = new cwt();
						cwt.i = new ap9("Acid pool", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
						cwt.f.Add(euf.a(a_, num));
						cwt.l = true;
						cwt.b = true;
						cwt.w = true;
						cwt.ad["IsAcidWeapon"] = true;
						c5x.h.b.aa().Defense.a(cwt);
						if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.c == asp.a)
						{
							cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
							if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
							{
								awq.a(serviceOrThrow.aqu().v().b() as c5x, c5x, false, false, true, false, false, false);
							}
						}
						c5x.h.b.aa().StatusEffects.a(new ce(ce.b * d0u.b), false, false, false);
					}
				}
			}
		}
	}

	// Token: 0x060068DA RID: 26842 RVA: 0x002C4B90 File Offset: 0x002C2D90
	public void a(c5x A_0)
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		a1q a_ = new a1q(DamageType.Acid, (int)(2.0 + this.b), (int)(2.0 + this.b * 2.0));
		if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().d(CharacterImmunities.AcidPuddles) && A_0.h.b.aa().Defense.af()[DamageType.Acid].c() != 1.0)
		{
			double num = 1.0;
			if (A_0.h.b.aa().c(d8o.e))
			{
				num += d9b.a;
			}
			cwt cwt = new cwt();
			cwt.i = new ap9("Acid pool", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
			cwt.f.Add(euf.a(a_, num));
			cwt.l = true;
			cwt.v = "лужа кислоты";
			cwt.b = true;
			cwt.w = true;
			cwt.ad["IsAcidWeapon"] = true;
			A_0.h.b.aa().Defense.a(cwt);
			if (zoneControlLevel != ZoneControlLevel.Uncontrolled && this.c == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					awq.a(serviceOrThrow.aqu().v().b() as c5x, A_0, false, false, true, false, false, false);
				}
			}
			if (cuo.a.NextDouble() < 0.25)
			{
				A_0.h.b.aa().StatusEffects.a(new ce(ce.b * d0u.b), false, false, false);
			}
		}
	}

	// Token: 0x060068DB RID: 26843 RVA: 0x002C4DE4 File Offset: 0x002C2FE4
	public void a(TimeSpan A_0)
	{
		double num = A_0.TotalMilliseconds;
		while (num > (double)d0u.b)
		{
			num -= (double)d0u.b;
			if (this.a(0.2))
			{
				break;
			}
		}
	}

	// Token: 0x060068DC RID: 26844 RVA: 0x002C4E24 File Offset: 0x002C3024
	public void b(TimeSpan A_0)
	{
	}

	// Token: 0x060068DD RID: 26845 RVA: 0x002C4E28 File Offset: 0x002C3028
	public void a(eds A_0)
	{
	}

	// Token: 0x060068DE RID: 26846 RVA: 0x002C4E2C File Offset: 0x002C302C
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
				List<ya> list = ak.a(typeof(s8));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						s8 s = ya as s8;
						if (s != null && s.a() != null && s.a().ao() == this)
						{
							s.o();
						}
					}
				}
			}
			c7 a_ = new c7(base.a8(), true, true, false, false);
			base.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
			return true;
		}
		int a_2 = (int)Math.Round(this.b, 0);
		this.a(a_2);
		return false;
	}

	// Token: 0x060068DF RID: 26847 RVA: 0x002C4F7C File Offset: 0x002C317C
	private void a(int A_0)
	{
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
		}
	}

	// Token: 0x04002B50 RID: 11088
	private const double a = 5.0;

	// Token: 0x04002B51 RID: 11089
	private double b = 0.1;

	// Token: 0x04002B52 RID: 11090
	private string c;
}
