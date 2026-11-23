using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E73 RID: 7795
[ayj("psiBeetleBrainPsi")]
public sealed class anb : ehl
{
	// Token: 0x0600AD8D RID: 44429 RVA: 0x003FB58C File Offset: 0x003F978C
	public override string y8()
	{
		return "Invoke Random Psi";
	}

	// Token: 0x0600AD8E RID: 44430 RVA: 0x003FB594 File Offset: 0x003F9794
	public override string os()
	{
		return "psiBeetleBrainPsi";
	}

	// Token: 0x0600AD8F RID: 44431 RVA: 0x003FB59C File Offset: 0x003F979C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD90 RID: 44432 RVA: 0x003FB5A0 File Offset: 0x003F97A0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.f,
			c = c0e.g
		};
	}

	// Token: 0x0600AD91 RID: 44433 RVA: 0x003FB5C0 File Offset: 0x003F97C0
	public override string c1()
	{
		return "Подготавливает";
	}

	// Token: 0x0600AD92 RID: 44434 RVA: 0x003FB5C8 File Offset: 0x003F97C8
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AD93 RID: 44435 RVA: 0x003FB5CC File Offset: 0x003F97CC
	public anb()
	{
		this.c = new List<string>();
		this.c.Add("psiBeetleBrainPsi");
	}

	// Token: 0x0600AD94 RID: 44436 RVA: 0x003FB5F0 File Offset: 0x003F97F0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD95 RID: 44437 RVA: 0x003FB5F4 File Offset: 0x003F97F4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Creature;
	}

	// Token: 0x0600AD96 RID: 44438 RVA: 0x003FB5F8 File Offset: 0x003F97F8
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/PsiBeetleBrainPsi", new object[]
		{
			anb.a(A_0)
		});
	}

	// Token: 0x0600AD97 RID: 44439 RVA: 0x003FB618 File Offset: 0x003F9818
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AD98 RID: 44440 RVA: 0x003FB624 File Offset: 0x003F9824
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_0 != null && A_0.b8() != null && A_0.b8() is e3q)
		{
			list.Add(new cfd("psiBeetleBrainPsi", anb.b, false, false));
		}
		else
		{
			list.Add(new cfd("psiBeetleBrainPsi", d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600AD99 RID: 44441 RVA: 0x003FB68C File Offset: 0x003F988C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600AD9A RID: 44442 RVA: 0x003FB694 File Offset: 0x003F9894
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8() is e3q)
		{
			return 25;
		}
		return 0;
	}

	// Token: 0x0600AD9B RID: 44443 RVA: 0x003FB6BC File Offset: 0x003F98BC
	protected override float f0(cnm A_0)
	{
		return 7f;
	}

	// Token: 0x0600AD9C RID: 44444 RVA: 0x003FB6C4 File Offset: 0x003F98C4
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600AD9D RID: 44445 RVA: 0x003FB6C8 File Offset: 0x003F98C8
	protected override double q3(cnm A_0)
	{
		return (double)anb.a(A_0);
	}

	// Token: 0x0600AD9E RID: 44446 RVA: 0x003FB6D4 File Offset: 0x003F98D4
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0400406F RID: 16495
	private new const string a = "psiBeetleBrainPsi";

	// Token: 0x04004070 RID: 16496
	public static readonly int b = 15000;

	// Token: 0x04004071 RID: 16497
	private List<string> c;
}
