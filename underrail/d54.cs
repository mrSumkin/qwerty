using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200182E RID: 6190
[ayj("pistolBurst")]
public sealed class d54 : bon
{
	// Token: 0x060083E1 RID: 33761 RVA: 0x00370258 File Offset: 0x0036E458
	public override string y8()
	{
		return "Пистолетная очередь";
	}

	// Token: 0x060083E2 RID: 33762 RVA: 0x00370260 File Offset: 0x0036E460
	public override string os()
	{
		return "pistolBurst";
	}

	// Token: 0x060083E3 RID: 33763 RVA: 0x00370268 File Offset: 0x0036E468
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x060083E4 RID: 33764 RVA: 0x0037026C File Offset: 0x0036E46C
	public override bool cs()
	{
		return false;
	}

	// Token: 0x060083E5 RID: 33765 RVA: 0x00370270 File Offset: 0x0036E470
	public override int ct()
	{
		return 2;
	}

	// Token: 0x060083E6 RID: 33766 RVA: 0x00370274 File Offset: 0x0036E474
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x060083E7 RID: 33767 RVA: 0x0037027C File Offset: 0x0036E47C
	public override bool j7()
	{
		return false;
	}

	// Token: 0x060083E8 RID: 33768 RVA: 0x00370280 File Offset: 0x0036E480
	public override bool l8()
	{
		return false;
	}

	// Token: 0x060083E9 RID: 33769 RVA: 0x00370284 File Offset: 0x0036E484
	public override bool i2()
	{
		return true;
	}

	// Token: 0x060083EA RID: 33770 RVA: 0x00370288 File Offset: 0x0036E488
	public d54()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
	}

	// Token: 0x060083EB RID: 33771 RVA: 0x003702AC File Offset: 0x0036E4AC
	public override string bm(cnm A_0)
	{
		return "Attacks.41";
	}

	// Token: 0x060083EC RID: 33772 RVA: 0x003702B4 File Offset: 0x0036E4B4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x060083ED RID: 33773 RVA: 0x003702B8 File Offset: 0x0036E4B8
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/PistolBurst", new object[]
		{
			d54.a(A_0)
		});
	}

	// Token: 0x060083EE RID: 33774 RVA: 0x003702D8 File Offset: 0x0036E4D8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060083EF RID: 33775 RVA: 0x003702E4 File Offset: 0x0036E4E4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x060083F0 RID: 33776 RVA: 0x00370318 File Offset: 0x0036E518
	public static double a(double A_0, bke A_1)
	{
		double num = d05.b(0.15, A_0 / (double)Math.Max(1f, A_1.ad()), 0.75);
		return d05.b(0.05, num - A_1.s(), 0.95);
	}

	// Token: 0x060083F1 RID: 33777 RVA: 0x00370374 File Offset: 0x0036E574
	public override double ajx(cnm A_0, double A_1, efk A_2, double A_3)
	{
		if (A_0 != null)
		{
			cd1 cd = A_0.b9() as cd1;
			if (cd != null && cd.TypedDefinition != null)
			{
				double num = d54.a(A_3, cd.TypedDefinition);
				return A_1 * (1.0 - num);
			}
		}
		return A_1;
	}

	// Token: 0x060083F2 RID: 33778 RVA: 0x003703C4 File Offset: 0x0036E5C4
	public new static int a(cnm A_0)
	{
		int num = d54.b;
		if (A_0 != null && A_0.b8() != null)
		{
			cd1 cd = A_0.b9() as cd1;
			if (cd == null)
			{
				cd = A_0.b8().Offense.u();
			}
			if (cd.TypedDefinition.d() > 0)
			{
				num += cd.TypedDefinition.d();
			}
		}
		return num;
	}

	// Token: 0x060083F3 RID: 33779 RVA: 0x0037042C File Offset: 0x0036E62C
	protected override int hi(cnm A_0)
	{
		double a_ = (double)base.hi(A_0) * d54.a;
		return (int)d05.b(30.0, a_, 50.0);
	}

	// Token: 0x060083F4 RID: 33780 RVA: 0x00370464 File Offset: 0x0036E664
	protected override int ma(cnm A_0)
	{
		return d54.a(A_0) * this.mb(A_0);
	}

	// Token: 0x060083F5 RID: 33781 RVA: 0x00370474 File Offset: 0x0036E674
	protected override int mb(cnm A_0)
	{
		return 125;
	}

	// Token: 0x040032A3 RID: 12963
	public new static readonly double a = 2.0;

	// Token: 0x040032A4 RID: 12964
	public static readonly int b = 3;

	// Token: 0x040032A5 RID: 12965
	private List<string> c;
}
