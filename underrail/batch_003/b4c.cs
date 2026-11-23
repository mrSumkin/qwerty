using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001F7D RID: 8061
[ayj("ldsing")]
public sealed class b4c : a6u
{
	// Token: 0x0600BCCF RID: 48335 RVA: 0x00416ED0 File Offset: 0x004150D0
	public override string y8()
	{
		return "Зарядить один патрон";
	}

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x00416ED8 File Offset: 0x004150D8
	public override string os()
	{
		return "LoadSingleBullet";
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x00416EE0 File Offset: 0x004150E0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BCD2 RID: 48338 RVA: 0x00416EE4 File Offset: 0x004150E4
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x00416EF8 File Offset: 0x004150F8
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BCD4 RID: 48340 RVA: 0x00416EFC File Offset: 0x004150FC
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Reload);
	}

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x00416F10 File Offset: 0x00415110
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BCD7 RID: 48343 RVA: 0x00416F14 File Offset: 0x00415114
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BCD8 RID: 48344 RVA: 0x00416F18 File Offset: 0x00415118
	public override string bm(cnm A_0)
	{
		return "Ammo.LoadOne";
	}

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x00416F20 File Offset: 0x00415120
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.BulletBasedWeapon;
	}

	// Token: 0x0600BCDA RID: 48346 RVA: 0x00416F24 File Offset: 0x00415124
	public override string bo(cnm A_0)
	{
		dng dng = A_0.b9() as dng;
		if (dng != null && dng.TypedDefinition.b() != AmmoType.None)
		{
			dh0 dh = eub.h(dng.TypedDefinition.b());
			if (dh != null)
			{
				string text = qv.b("Items\\Ammo/LoadOne");
				if (text != null)
				{
					return string.Format(text, dh.a);
				}
			}
		}
		return string.Empty;
	}

	// Token: 0x0600BCDB RID: 48347 RVA: 0x00416F90 File Offset: 0x00415190
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BCDC RID: 48348 RVA: 0x00416F9C File Offset: 0x0041519C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600BCDD RID: 48349 RVA: 0x00416FA4 File Offset: 0x004151A4
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0.b8() != null && !A_0.b8().IsInCombat && !bzl.a();
	}

	// Token: 0x0600BCDE RID: 48350 RVA: 0x00416FDC File Offset: 0x004151DC
	public override IList<string> bi()
	{
		return d7f.p;
	}
}
