using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001F7E RID: 8062
[ayj("rwep")]
public sealed class a4o : a6u
{
	// Token: 0x0600BCDF RID: 48351 RVA: 0x00416FE4 File Offset: 0x004151E4
	public override string y8()
	{
		return "Перезарядить оружие";
	}

	// Token: 0x0600BCE0 RID: 48352 RVA: 0x00416FEC File Offset: 0x004151EC
	public override string os()
	{
		return "ReloadWeapon";
	}

	// Token: 0x0600BCE1 RID: 48353 RVA: 0x00416FF4 File Offset: 0x004151F4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BCE2 RID: 48354 RVA: 0x00416FF8 File Offset: 0x004151F8
	public override string c1()
	{
		return "Перезаряжает";
	}

	// Token: 0x0600BCE3 RID: 48355 RVA: 0x00417000 File Offset: 0x00415200
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BCE4 RID: 48356 RVA: 0x00417014 File Offset: 0x00415214
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x00417018 File Offset: 0x00415218
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Reload);
	}

	// Token: 0x0600BCE7 RID: 48359 RVA: 0x0041702C File Offset: 0x0041522C
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BCE8 RID: 48360 RVA: 0x00417030 File Offset: 0x00415230
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BCE9 RID: 48361 RVA: 0x00417034 File Offset: 0x00415234
	public override string bm(cnm A_0)
	{
		return "Ammo.Reload";
	}

	// Token: 0x0600BCEA RID: 48362 RVA: 0x0041703C File Offset: 0x0041523C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.BulletBasedWeapon;
	}

	// Token: 0x0600BCEB RID: 48363 RVA: 0x00417044 File Offset: 0x00415244
	public override string bo(cnm A_0)
	{
		dng dng = A_0.b9() as dng;
		if (dng != null && dng.TypedDefinition.b() != AmmoType.None)
		{
			dh0 dh = eub.h(dng.TypedDefinition.b());
			if (dh != null)
			{
				string text = qv.b("Items\\Ammo/ReloadWeapon");
				if (text != null)
				{
					return string.Format(text, dh.a);
				}
			}
		}
		return string.Empty;
	}

	// Token: 0x0600BCEC RID: 48364 RVA: 0x004170B0 File Offset: 0x004152B0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BCED RID: 48365 RVA: 0x004170BC File Offset: 0x004152BC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600BCEE RID: 48366 RVA: 0x004170C4 File Offset: 0x004152C4
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600BCEF RID: 48367 RVA: 0x004170CC File Offset: 0x004152CC
	protected override int br(cnm A_0)
	{
		cd1 cd = A_0.ca() as cd1;
		if (cd != null && cd.TypedDefinition != null)
		{
			return as3.v[cd.TypedDefinition.e()];
		}
		return 0;
	}
}
