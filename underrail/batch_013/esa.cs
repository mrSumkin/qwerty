using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E6E RID: 7790
[ayj("StrangeMedallion")]
public sealed class esa : ehl
{
	// Token: 0x0600AD34 RID: 44340 RVA: 0x003FB0BC File Offset: 0x003F92BC
	public override string y8()
	{
		return "Странный медальон";
	}

	// Token: 0x0600AD35 RID: 44341 RVA: 0x003FB0C4 File Offset: 0x003F92C4
	public override string os()
	{
		return "StrangeMedallion";
	}

	// Token: 0x0600AD36 RID: 44342 RVA: 0x003FB0CC File Offset: 0x003F92CC
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD37 RID: 44343 RVA: 0x003FB0D0 File Offset: 0x003F92D0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.f,
			c = c0e.g
		};
	}

	// Token: 0x0600AD38 RID: 44344 RVA: 0x003FB0F0 File Offset: 0x003F92F0
	public override string c1()
	{
		return "Подготавливает";
	}

	// Token: 0x0600AD39 RID: 44345 RVA: 0x003FB0F8 File Offset: 0x003F92F8
	public esa()
	{
		this.c = new List<string>();
		this.c.Add("strangeMedallion");
	}

	// Token: 0x0600AD3A RID: 44346 RVA: 0x003FB11C File Offset: 0x003F931C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD3B RID: 44347 RVA: 0x003FB120 File Offset: 0x003F9320
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AD3C RID: 44348 RVA: 0x003FB124 File Offset: 0x003F9324
	public override string bp(cnm A_0)
	{
		return dgk.Get<c4n>().bo(A_0) + string.Format(" Цена {0} энергии.", esa.a(A_0));
	}

	// Token: 0x0600AD3D RID: 44349 RVA: 0x003FB14C File Offset: 0x003F934C
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AD3E RID: 44350 RVA: 0x003FB158 File Offset: 0x003F9358
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_0 != null && A_0.b8() != null && A_0.b8() is e3q)
		{
			list.Add(new cfd("strangeMedallion", esa.b, false, false));
		}
		else
		{
			list.Add(new cfd("strangeMedallion", d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600AD3F RID: 44351 RVA: 0x003FB1C0 File Offset: 0x003F93C0
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600AD40 RID: 44352 RVA: 0x003FB1C8 File Offset: 0x003F93C8
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8() is e3q)
		{
			return 25;
		}
		return 0;
	}

	// Token: 0x0600AD41 RID: 44353 RVA: 0x003FB1F0 File Offset: 0x003F93F0
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600AD42 RID: 44354 RVA: 0x003FB1F8 File Offset: 0x003F93F8
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600AD43 RID: 44355 RVA: 0x003FB1FC File Offset: 0x003F93FC
	protected override double q3(cnm A_0)
	{
		return (double)esa.a(A_0);
	}

	// Token: 0x0600AD44 RID: 44356 RVA: 0x003FB208 File Offset: 0x003F9408
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x04004069 RID: 16489
	private new const string a = "strangeMedallion";

	// Token: 0x0400406A RID: 16490
	public static readonly int b = 30000;

	// Token: 0x0400406B RID: 16491
	private List<string> c;
}
