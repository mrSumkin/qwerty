using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E67 RID: 7783
[ayj("ScrambleCortex")]
public sealed class e3e : m0, bix
{
	// Token: 0x0600ACA5 RID: 44197 RVA: 0x003FA2EC File Offset: 0x003F84EC
	public override string y8()
	{
		return "Скремблирование КорТех";
	}

	// Token: 0x0600ACA6 RID: 44198 RVA: 0x003FA2F4 File Offset: 0x003F84F4
	public override string os()
	{
		return "ScrambleCortex";
	}

	// Token: 0x0600ACA7 RID: 44199 RVA: 0x003FA2FC File Offset: 0x003F84FC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600ACA8 RID: 44200 RVA: 0x003FA300 File Offset: 0x003F8500
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600ACA9 RID: 44201 RVA: 0x003FA304 File Offset: 0x003F8504
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d,
			b = new int?(80),
			c = c0e.j,
			d = new int?(80)
		};
	}

	// Token: 0x0600ACAA RID: 44202 RVA: 0x003FA33C File Offset: 0x003F853C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600ACAB RID: 44203 RVA: 0x003FA348 File Offset: 0x003F8548
	public e3e()
	{
		this.g = new List<string>();
		this.g.Add("ScrambleCortex");
	}

	// Token: 0x0600ACAC RID: 44204 RVA: 0x003FA36C File Offset: 0x003F856C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ACAD RID: 44205 RVA: 0x003FA370 File Offset: 0x003F8570
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Robot;
	}

	// Token: 0x0600ACAE RID: 44206 RVA: 0x003FA374 File Offset: 0x003F8574
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600ACAF RID: 44207 RVA: 0x003FA37C File Offset: 0x003F857C
	public override string bp(cnm A_0)
	{
		int num = e3e.a(A_0);
		return qv.a("Items\\Utilities/ScrambleCortex", new object[]
		{
			num,
			l4.a(e3e.c, false),
			e3e.f
		});
	}

	// Token: 0x0600ACB0 RID: 44208 RVA: 0x003FA3C4 File Offset: 0x003F85C4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("ScrambleCortex", e3e.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600ACB1 RID: 44209 RVA: 0x003FA3E8 File Offset: 0x003F85E8
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				return coh.Battery >= (double)e3e.f;
			}
		}
		return false;
	}

	// Token: 0x0600ACB2 RID: 44210 RVA: 0x003FA430 File Offset: 0x003F8630
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600ACB3 RID: 44211 RVA: 0x003FA43C File Offset: 0x003F863C
	public new static int a(cnm A_0)
	{
		int result = 0;
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				result = coh.Definition.a7().GetPrimitivePropertyValue<int>("CortexScrambleHackingBonus", new int?(0)).Value;
			}
		}
		return result;
	}

	// Token: 0x0600ACB4 RID: 44212 RVA: 0x003FA494 File Offset: 0x003F8694
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double num = e3e.a(A_0, A_1, 1);
			return new bg3
			{
				a = num
			};
		}
		return null;
	}

	// Token: 0x0600ACB5 RID: 44213 RVA: 0x003FA4CC File Offset: 0x003F86CC
	public static double a(cnm A_0, efk A_1, int A_2)
	{
		double result = 0.25;
		if (A_0 != null && A_0.b8() != null && A_1 != null)
		{
			double a_ = (double)(A_0.b8().Skills.Get<adx>().g() + e3e.a(A_0));
			double a_2 = (double)Convert.ToInt32(qw.a(A_1.Level) * (0.6 + (double)A_2 * 0.25));
			double num = qw.a(a_, a_2);
			result = d05.b(0.25, 1.0 - num, 0.95);
		}
		return result;
	}

	// Token: 0x0600ACB6 RID: 44214 RVA: 0x003FA56C File Offset: 0x003F876C
	protected override float f0(cnm A_0)
	{
		return (float)e3e.d;
	}

	// Token: 0x0600ACB7 RID: 44215 RVA: 0x003FA574 File Offset: 0x003F8774
	protected override int hi(cnm A_0)
	{
		return e3e.e;
	}

	// Token: 0x0600ACB8 RID: 44216 RVA: 0x003FA57C File Offset: 0x003F877C
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0400404A RID: 16458
	private new const string a = "ScrambleCortex";

	// Token: 0x0400404B RID: 16459
	public static readonly int b = 5;

	// Token: 0x0400404C RID: 16460
	public static readonly int c = 3;

	// Token: 0x0400404D RID: 16461
	public static readonly int d = 6;

	// Token: 0x0400404E RID: 16462
	public new static readonly int e = 20;

	// Token: 0x0400404F RID: 16463
	public static readonly int f = 20;

	// Token: 0x04004050 RID: 16464
	private new List<string> g;
}
