using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F84 RID: 8068
[ayj("BandageConsumation")]
public sealed class ec3 : awn
{
	// Token: 0x0600BD35 RID: 48437 RVA: 0x00417644 File Offset: 0x00415844
	public override string y8()
	{
		return "Перебинтовывает...";
	}

	// Token: 0x0600BD36 RID: 48438 RVA: 0x0041764C File Offset: 0x0041584C
	public override string os()
	{
		return "BandageConsumation";
	}

	// Token: 0x0600BD37 RID: 48439 RVA: 0x00417654 File Offset: 0x00415854
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD38 RID: 48440 RVA: 0x00417658 File Offset: 0x00415858
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BD39 RID: 48441 RVA: 0x0041765C File Offset: 0x0041585C
	public ec3()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600BD3A RID: 48442 RVA: 0x00417670 File Offset: 0x00415870
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD3B RID: 48443 RVA: 0x00417674 File Offset: 0x00415874
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.BandagableLivingCreature;
	}

	// Token: 0x0600BD3C RID: 48444 RVA: 0x0041767C File Offset: 0x0041587C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Bandage", new object[]
		{
			this.c(A_0),
			ec3.a() / 1000,
			(int)(ec3.b(null) * 100.0)
		});
	}

	// Token: 0x0600BD3D RID: 48445 RVA: 0x004176D4 File Offset: 0x004158D4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BD3E RID: 48446 RVA: 0x004176DC File Offset: 0x004158DC
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600BD3F RID: 48447 RVA: 0x004176E4 File Offset: 0x004158E4
	public int c(cnm A_0)
	{
		return ec3.a(A_0) * (base.s(A_0) / base.h(A_0));
	}

	// Token: 0x0600BD40 RID: 48448 RVA: 0x004176FC File Offset: 0x004158FC
	public static int a()
	{
		return 7000;
	}

	// Token: 0x0600BD41 RID: 48449 RVA: 0x00417704 File Offset: 0x00415904
	public static double b(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<yn>())
		{
			return 0.0;
		}
		return 0.4;
	}

	// Token: 0x0600BD42 RID: 48450 RVA: 0x00417744 File Offset: 0x00415944
	public new static int a(cnm A_0)
	{
		int num = 20;
		if (A_0 != null && A_0.b8() is e3q)
		{
			num = (int)((float)num * euf.b().HealingModifier);
		}
		return num;
	}

	// Token: 0x0600BD43 RID: 48451 RVA: 0x0041777C File Offset: 0x0041597C
	protected override int ma(cnm A_0)
	{
		return ec3.a();
	}

	// Token: 0x0600BD44 RID: 48452 RVA: 0x00417784 File Offset: 0x00415984
	protected override int mb(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x04004419 RID: 17433
	private new List<string> a;
}
