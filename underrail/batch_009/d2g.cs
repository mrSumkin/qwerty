using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E9B RID: 7835
[ayj("Sweep")]
public sealed class d2g : bon
{
	// Token: 0x0600AF86 RID: 44934 RVA: 0x003FE024 File Offset: 0x003FC224
	public override string y8()
	{
		return "Подсечение";
	}

	// Token: 0x0600AF87 RID: 44935 RVA: 0x003FE02C File Offset: 0x003FC22C
	public override string os()
	{
		return "Sweep";
	}

	// Token: 0x0600AF88 RID: 44936 RVA: 0x003FE034 File Offset: 0x003FC234
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF89 RID: 44937 RVA: 0x003FE038 File Offset: 0x003FC238
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AF8A RID: 44938 RVA: 0x003FE03C File Offset: 0x003FC23C
	public override int ct()
	{
		return 5;
	}

	// Token: 0x0600AF8B RID: 44939 RVA: 0x003FE040 File Offset: 0x003FC240
	public d2g()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add(d2g.a);
	}

	// Token: 0x0600AF8C RID: 44940 RVA: 0x003FE074 File Offset: 0x003FC274
	public override string bm(cnm A_0)
	{
		return "xpbl_Attacks.41";
	}

	// Token: 0x0600AF8D RID: 44941 RVA: 0x003FE07C File Offset: 0x003FC27C
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			if (euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear && A_0.b8().Feats.Contains<dol>())
			{
				return true;
			}
			if (Enumerable.Any<aia>(A_0.b8().Offense.u().TypedDefinition.@as(), new Func<aia, bool>(this.b)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AF8E RID: 44942 RVA: 0x003FE16C File Offset: 0x003FC36C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600AF8F RID: 44943 RVA: 0x003FE174 File Offset: 0x003FC374
	private string a(cnm A_0, bool A_1)
	{
		cd1 cd = null;
		if (A_0 != null)
		{
			cd = (A_0.b9() as cd1);
			if (cd == null)
			{
				cd = A_0.b8().Offense.u();
			}
		}
		string format;
		if (cd != null && Enumerable.Any<aia>(cd.TypedDefinition.@as(), new Func<aia, bool>(this.a)))
		{
			format = qv.b("SpecialAttacks/Sweep_generic");
		}
		else
		{
			format = qv.b("SpecialAttacks/Sweep");
		}
		return string.Format(format, (int)(d2g.a(A_0) * 100.0), l4.b(d2g.a((A_0 != null) ? A_0.b8() : null), false));
	}

	// Token: 0x0600AF90 RID: 44944 RVA: 0x003FE228 File Offset: 0x003FC428
	public override string bo(cnm A_0)
	{
		return this.a(A_0, false);
	}

	// Token: 0x0600AF91 RID: 44945 RVA: 0x003FE234 File Offset: 0x003FC434
	public override string bp(cnm A_0)
	{
		return this.a(A_0, true);
	}

	// Token: 0x0600AF92 RID: 44946 RVA: 0x003FE240 File Offset: 0x003FC440
	public new static double a(cnm A_0)
	{
		double num = d2g.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<b1r>(true) * b1r.a;
		}
		return num;
	}

	// Token: 0x0600AF93 RID: 44947 RVA: 0x003FE27C File Offset: 0x003FC47C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int num = d2g.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (int)((double)A_0.b8().GetSpecializationValue<c3t>(true) * c3t.a);
		}
		list.Add(new cfd(d2g.a, num * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600AF94 RID: 44948 RVA: 0x003FE2F8 File Offset: 0x003FC4F8
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600AF95 RID: 44949 RVA: 0x003FE304 File Offset: 0x003FC504
	public static double a(efk A_0)
	{
		double num = (double)d2g.b;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<bbi>(true) * bbi.a;
		}
		return num;
	}

	// Token: 0x0600AF96 RID: 44950 RVA: 0x003FE330 File Offset: 0x003FC530
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AF97 RID: 44951 RVA: 0x003FE338 File Offset: 0x003FC538
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AF99 RID: 44953 RVA: 0x003FE368 File Offset: 0x003FC568
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x0600AF9A RID: 44954 RVA: 0x003FE374 File Offset: 0x003FC574
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x040040AD RID: 16557
	public new static readonly string a = "SAt.Sweep";

	// Token: 0x040040AE RID: 16558
	public static readonly int b = 2;

	// Token: 0x040040AF RID: 16559
	public static readonly int c = 3;

	// Token: 0x040040B0 RID: 16560
	public static readonly double d = 0.7;

	// Token: 0x040040B1 RID: 16561
	private new List<string> e;
}
