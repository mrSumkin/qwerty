using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001F7F RID: 8063
[ayj("rcurwep")]
public sealed class dg4 : a6u
{
	// Token: 0x0600BCF0 RID: 48368 RVA: 0x00417110 File Offset: 0x00415310
	public override string y8()
	{
		return "Перезарядить текущее оружие";
	}

	// Token: 0x0600BCF1 RID: 48369 RVA: 0x00417118 File Offset: 0x00415318
	public override string os()
	{
		return "ReloadCurrentWeapon";
	}

	// Token: 0x0600BCF2 RID: 48370 RVA: 0x00417120 File Offset: 0x00415320
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BCF3 RID: 48371 RVA: 0x00417124 File Offset: 0x00415324
	public override string c1()
	{
		return "Перезаряжает";
	}

	// Token: 0x0600BCF4 RID: 48372 RVA: 0x0041712C File Offset: 0x0041532C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BCF5 RID: 48373 RVA: 0x00417140 File Offset: 0x00415340
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BCF7 RID: 48375 RVA: 0x0041714C File Offset: 0x0041534C
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BCF8 RID: 48376 RVA: 0x00417150 File Offset: 0x00415350
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BCF9 RID: 48377 RVA: 0x00417154 File Offset: 0x00415354
	public override string bm(cnm A_0)
	{
		return "Ammo.ReloadCurrent";
	}

	// Token: 0x0600BCFA RID: 48378 RVA: 0x0041715C File Offset: 0x0041535C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BCFB RID: 48379 RVA: 0x00417164 File Offset: 0x00415364
	public override string bo(cnm A_0)
	{
		dng dng = A_0.b9() as dng;
		if (dng != null && dng.TypedDefinition.b() != AmmoType.None)
		{
			dh0 dh = eub.h(dng.TypedDefinition.b());
			if (dh != null)
			{
				string text = qv.b("Items\\Ammo/ReloadCurrentWeapon");
				if (text != null)
				{
					return string.Format(text, dh.a);
				}
			}
		}
		return string.Empty;
	}

	// Token: 0x0600BCFC RID: 48380 RVA: 0x004171D0 File Offset: 0x004153D0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BCFD RID: 48381 RVA: 0x004171DC File Offset: 0x004153DC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600BCFE RID: 48382 RVA: 0x004171E8 File Offset: 0x004153E8
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0.b8() != null)
		{
			if (A_0.b8().Offense.u().TypedDefinition.ao)
			{
				return false;
			}
			AmmoType ammoType = A_0.b8().Offense.u().TypedDefinition.ak();
			if (ammoType != AmmoType.None)
			{
				dng dng = A_0.b9() as dng;
				return dng != null && eub.g(dng.TypedDefinition.b()) == ammoType;
			}
		}
		return false;
	}

	// Token: 0x0600BCFF RID: 48383 RVA: 0x0041727C File Offset: 0x0041547C
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600BD00 RID: 48384 RVA: 0x00417284 File Offset: 0x00415484
	protected override int br(cnm A_0)
	{
		A_0.b9();
		if (A_0.b8() != null && A_0.b8().Offense.u().TypedDefinition != null)
		{
			return as3.v[A_0.b8().Offense.u().TypedDefinition.e()];
		}
		return 0;
	}
}
