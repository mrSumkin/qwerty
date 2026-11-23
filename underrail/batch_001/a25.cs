using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F62 RID: 8034
[ayj("rie")]
public sealed class a25 : c0r
{
	// Token: 0x0600BBAA RID: 48042 RVA: 0x0041519C File Offset: 0x0041339C
	public override string y8()
	{
		return "Зарядить предмет";
	}

	// Token: 0x0600BBAB RID: 48043 RVA: 0x004151A4 File Offset: 0x004133A4
	public override string c1()
	{
		return "Заряжает";
	}

	// Token: 0x0600BBAC RID: 48044 RVA: 0x004151AC File Offset: 0x004133AC
	public override string os()
	{
		return "RechargeItem";
	}

	// Token: 0x0600BBAD RID: 48045 RVA: 0x004151B4 File Offset: 0x004133B4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BBAE RID: 48046 RVA: 0x004151B8 File Offset: 0x004133B8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Power);
	}

	// Token: 0x0600BBAF RID: 48047 RVA: 0x004151C4 File Offset: 0x004133C4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BBB0 RID: 48048 RVA: 0x004151D8 File Offset: 0x004133D8
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BBB1 RID: 48049 RVA: 0x004151DC File Offset: 0x004133DC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.PoweredItem;
	}

	// Token: 0x0600BBB2 RID: 48050 RVA: 0x004151E0 File Offset: 0x004133E0
	public override string bm(cnm A_0)
	{
		return "Energy.RechargeItem";
	}

	// Token: 0x0600BBB3 RID: 48051 RVA: 0x004151E8 File Offset: 0x004133E8
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600BBB4 RID: 48052 RVA: 0x004151F4 File Offset: 0x004133F4
	public override string bp(cnm A_0)
	{
		int num = a25.a(A_0);
		return qv.a("Items\\Consumables/RestoreItemEnergy", new object[]
		{
			num
		});
	}

	// Token: 0x0600BBB5 RID: 48053 RVA: 0x00415224 File Offset: 0x00413424
	public new static int a(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		if (coh != null)
		{
			return coh.Definition.a7().GetPrimitivePropertyValue<int>(vo.g, new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x0600BBB6 RID: 48054 RVA: 0x00415264 File Offset: 0x00413464
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0600BBB7 RID: 48055 RVA: 0x0041526C File Offset: 0x0041346C
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x040043E9 RID: 17385
	internal new const int a = 3000;
}
