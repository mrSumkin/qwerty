using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012C2 RID: 4802
[eiz("CCX6")]
[Serializable]
public sealed class ey7 : Aspect<c5x>, ISerializable
{
	// Token: 0x060069E3 RID: 27107 RVA: 0x002CA3B0 File Offset: 0x002C85B0
	private ey7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("CCX6:L");
		this.c = A_0.GetString("CCX6:O");
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x002CA3EC File Offset: 0x002C85EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCX6:L", this.b);
		info.AddValue("CCX6:O", this.c);
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x002CA418 File Offset: 0x002C8618
	public ey7(c5x A_0, string A_1) : base(A_0)
	{
		this.c = A_1;
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x002CA438 File Offset: 0x002C8638
	public void b(double A_0)
	{
		this.b += A_0;
		this.a();
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x002CA450 File Offset: 0x002C8650
	public bool a(double A_0)
	{
		this.b -= A_0;
		return this.a();
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x002CA468 File Offset: 0x002C8668
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
						cwt cwt = new cwt();
						cwt.i = new ap9("Acid pool", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
						cwt.f.Add(euf.a(a_, 1.0));
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
						c5x.h.b.aa().StatusEffects.a(new deu(deu.c * d0u.b), false, false, false);
					}
				}
			}
		}
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x002CA718 File Offset: 0x002C8918
	public void a(c5x A_0)
	{
		ZoneControlLevel zoneControlLevel = eir.d(base.a8().Zone);
		a1q a_ = new a1q(DamageType.Acid, (int)(2.0 + this.b), (int)(2.0 + this.b * 2.0));
		if (A_0.h.b != null && !A_0.h.b.aa().Passive && !A_0.h.b.aa().d(CharacterImmunities.AcidPuddles) && A_0.h.b.aa().Defense.af()[DamageType.Acid].c() != 1.0)
		{
			cwt cwt = new cwt();
			cwt.i = new ap9("Acid pool", (zoneControlLevel != ZoneControlLevel.Uncontrolled) ? this.c : null);
			cwt.f.Add(euf.a(a_, 1.0));
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
				A_0.h.b.aa().StatusEffects.a(new deu(deu.c * d0u.b), false, false, false);
			}
		}
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x002CA93C File Offset: 0x002C8B3C
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

	// Token: 0x060069EB RID: 27115 RVA: 0x002CA97C File Offset: 0x002C8B7C
	public void b(TimeSpan A_0)
	{
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x002CA980 File Offset: 0x002C8B80
	public void a(eds A_0)
	{
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x002CA984 File Offset: 0x002C8B84
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
				List<ya> list = ak.a(typeof(sl));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						sl sl = ya as sl;
						if (sl != null && sl.a() != null && sl.a().ao() == this)
						{
							sl.o();
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

	// Token: 0x060069EE RID: 27118 RVA: 0x002CAAD4 File Offset: 0x002C8CD4
	private void a(int A_0)
	{
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
		}
	}

	// Token: 0x04002B93 RID: 11155
	private const double a = 5.0;

	// Token: 0x04002B94 RID: 11156
	private double b = 0.1;

	// Token: 0x04002B95 RID: 11157
	private string c;
}
