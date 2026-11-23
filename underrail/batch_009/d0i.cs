using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E7A RID: 7802
[ayj("rechargeShieldEmitterFull")]
public sealed class d0i : m0
{
	// Token: 0x0600AE06 RID: 44550 RVA: 0x003FBBF8 File Offset: 0x003F9DF8
	public override string y8()
	{
		return "Полностью перезарядить излучатель щита";
	}

	// Token: 0x0600AE07 RID: 44551 RVA: 0x003FBC00 File Offset: 0x003F9E00
	public override string os()
	{
		return "rechargeShieldEmitterFull";
	}

	// Token: 0x0600AE08 RID: 44552 RVA: 0x003FBC08 File Offset: 0x003F9E08
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE09 RID: 44553 RVA: 0x003FBC0C File Offset: 0x003F9E0C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Lockpick);
	}

	// Token: 0x0600AE0A RID: 44554 RVA: 0x003FBC18 File Offset: 0x003F9E18
	public override string c1()
	{
		return "Вступает";
	}

	// Token: 0x0600AE0B RID: 44555 RVA: 0x003FBC20 File Offset: 0x003F9E20
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AE0C RID: 44556 RVA: 0x003FBC24 File Offset: 0x003F9E24
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE0E RID: 44558 RVA: 0x003FBC30 File Offset: 0x003F9E30
	public override string bm(cnm A_0)
	{
		return "Abilities.21";
	}

	// Token: 0x0600AE0F RID: 44559 RVA: 0x003FBC38 File Offset: 0x003F9E38
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600AE10 RID: 44560 RVA: 0x003FBC3C File Offset: 0x003F9E3C
	public override string bo(cnm A_0)
	{
		return "Полностью перезаряжает энергетический щит, используя батарейки из инвентаря персонажа.";
	}

	// Token: 0x0600AE11 RID: 44561 RVA: 0x003FBC44 File Offset: 0x003F9E44
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AE12 RID: 44562 RVA: 0x003FBC50 File Offset: 0x003F9E50
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AE13 RID: 44563 RVA: 0x003FBC58 File Offset: 0x003F9E58
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AE14 RID: 44564 RVA: 0x003FBC60 File Offset: 0x003F9E60
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AE15 RID: 44565 RVA: 0x003FBC64 File Offset: 0x003F9E64
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0.b8() != null && !A_0.b8().IsInCombat)
		{
			cgd cgd = A_0.b9() as cgd;
			if (cgd != null && A_0.b8().Gear.h().Item == cgd)
			{
				return cgd.Battery != (double)cgd.MaxBattery;
			}
		}
		return false;
	}
}
