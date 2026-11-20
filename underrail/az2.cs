using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F61 RID: 8033
[ayj("rcw")]
public sealed class az2 : c0r
{
	// Token: 0x0600BB9A RID: 48026 RVA: 0x00415038 File Offset: 0x00413238
	public override string y8()
	{
		return "Зарядить текущее оружие";
	}

	// Token: 0x0600BB9B RID: 48027 RVA: 0x00415040 File Offset: 0x00413240
	public override string c1()
	{
		return "Заряжает";
	}

	// Token: 0x0600BB9C RID: 48028 RVA: 0x00415048 File Offset: 0x00413248
	public override string os()
	{
		return "RechargeCurrentWeapon";
	}

	// Token: 0x0600BB9D RID: 48029 RVA: 0x00415050 File Offset: 0x00413250
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BB9E RID: 48030 RVA: 0x00415054 File Offset: 0x00413254
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Power);
	}

	// Token: 0x0600BB9F RID: 48031 RVA: 0x00415060 File Offset: 0x00413260
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BBA0 RID: 48032 RVA: 0x00415074 File Offset: 0x00413274
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BBA1 RID: 48033 RVA: 0x00415078 File Offset: 0x00413278
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BBA2 RID: 48034 RVA: 0x0041507C File Offset: 0x0041327C
	public override string bm(cnm A_0)
	{
		return "Energy.RechargeWeapon";
	}

	// Token: 0x0600BBA3 RID: 48035 RVA: 0x00415084 File Offset: 0x00413284
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600BBA4 RID: 48036 RVA: 0x00415090 File Offset: 0x00413290
	public override string bp(cnm A_0)
	{
		int num = az2.a(A_0);
		return qv.a("Items\\Consumables/RestoreWeaponEnergy", new object[]
		{
			num
		});
	}

	// Token: 0x0600BBA5 RID: 48037 RVA: 0x004150C0 File Offset: 0x004132C0
	public new static int a(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		if (coh != null)
		{
			return coh.Definition.a7().GetPrimitivePropertyValue<int>(vo.g, new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x0600BBA6 RID: 48038 RVA: 0x00415100 File Offset: 0x00413300
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0.b8() != null && A_0.b8().Offense.u() != null) && eub.b(A_0.b8().Offense.u()) && A_0.b8().Offense.u().Battery < (double)A_0.b8().Offense.u().MaxBattery;
	}

	// Token: 0x0600BBA7 RID: 48039 RVA: 0x00415188 File Offset: 0x00413388
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x0600BBA8 RID: 48040 RVA: 0x00415190 File Offset: 0x00413390
	protected override int hi(cnm A_0)
	{
		return 10;
	}
}
