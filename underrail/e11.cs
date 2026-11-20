using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020012C4 RID: 4804
[eiz("ACX6")]
[Serializable]
public sealed class e11 : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x060069F8 RID: 27128 RVA: 0x002CB1B4 File Offset: 0x002C93B4
	private e11(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("ACX6:L");
		if (ell.a() >= 141)
		{
			this.c = A_0.GetString("ACX6:O");
		}
		if (ell.a() >= 465)
		{
			this.d = A_0.GetBoolean("ACX6:P");
		}
	}

	// Token: 0x060069F9 RID: 27129 RVA: 0x002CB22C File Offset: 0x002C942C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACX6:L", this.b);
		info.AddValue("ACX6:O", this.c);
		info.AddValue("ACX6:P", this.d);
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x002CB274 File Offset: 0x002C9474
	public bool b()
	{
		return this.d;
	}

	// Token: 0x060069FB RID: 27131 RVA: 0x002CB27C File Offset: 0x002C947C
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x002CB288 File Offset: 0x002C9488
	public e11(c5x A_0, string A_1) : base(A_0)
	{
		this.c = A_1;
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x002CB2A8 File Offset: 0x002C94A8
	public void b(double A_0)
	{
		this.b += A_0;
		this.a();
	}

	// Token: 0x060069FE RID: 27134 RVA: 0x002CB2C0 File Offset: 0x002C94C0
	public bool a(double A_0)
	{
		if (this.d)
		{
			return false;
		}
		this.b -= A_0;
		return this.a();
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x002CB2E8 File Offset: 0x002C94E8
	public void d()
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
					}
				}
			}
		}
	}

	// Token: 0x06006A00 RID: 27136 RVA: 0x002CB56C File Offset: 0x002C976C
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
		}
	}

	// Token: 0x06006A01 RID: 27137 RVA: 0x002CB74C File Offset: 0x002C994C
	public void c9(TimeSpan A_0)
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

	// Token: 0x06006A02 RID: 27138 RVA: 0x002CB78C File Offset: 0x002C998C
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x002CB790 File Offset: 0x002C9990
	public void r7(eds A_0)
	{
	}

	// Token: 0x06006A04 RID: 27140 RVA: 0x002CB794 File Offset: 0x002C9994
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
				List<ya> list = ak.a(typeof(ed0));
				if (list != null && list.Count > 0)
				{
					foreach (ya ya in list)
					{
						ed0 ed = ya as ed0;
						if (ed != null && ed.a() != null && ed.a().ao() == this)
						{
							ed.o();
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

	// Token: 0x06006A05 RID: 27141 RVA: 0x002CB8E4 File Offset: 0x002C9AE4
	private void a(int A_0)
	{
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, A_0);
		}
	}

	// Token: 0x04002B99 RID: 11161
	private const double a = 5.0;

	// Token: 0x04002B9A RID: 11162
	private double b = 0.1;

	// Token: 0x04002B9B RID: 11163
	private string c;

	// Token: 0x04002B9C RID: 11164
	private bool d;
}
