using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001F7C RID: 8060
[ayj("ldsingcur")]
public sealed class hk : a6u
{
	// Token: 0x0600BCC0 RID: 48320 RVA: 0x00416D48 File Offset: 0x00414F48
	public override string y8()
	{
		return "Зарядить один патрон (текущее оружие)";
	}

	// Token: 0x0600BCC1 RID: 48321 RVA: 0x00416D50 File Offset: 0x00414F50
	public override string os()
	{
		return "LoadSingleBulletCurrent";
	}

	// Token: 0x0600BCC2 RID: 48322 RVA: 0x00416D58 File Offset: 0x00414F58
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BCC3 RID: 48323 RVA: 0x00416D5C File Offset: 0x00414F5C
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600BCC4 RID: 48324 RVA: 0x00416D70 File Offset: 0x00414F70
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BCC6 RID: 48326 RVA: 0x00416D7C File Offset: 0x00414F7C
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x00416D80 File Offset: 0x00414F80
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BCC8 RID: 48328 RVA: 0x00416D84 File Offset: 0x00414F84
	public override string bm(cnm A_0)
	{
		return "Ammo.LoadOneCurrent";
	}

	// Token: 0x0600BCC9 RID: 48329 RVA: 0x00416D8C File Offset: 0x00414F8C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BCCA RID: 48330 RVA: 0x00416D94 File Offset: 0x00414F94
	public override string bo(cnm A_0)
	{
		dng dng = A_0.b9() as dng;
		if (dng != null && dng.TypedDefinition.b() != AmmoType.None)
		{
			dh0 dh = eub.h(dng.TypedDefinition.b());
			if (dh != null)
			{
				string text = qv.b("Items\\Ammo/LoadOneCurrent");
				if (text != null)
				{
					return string.Format(text, dh.a);
				}
			}
		}
		return string.Empty;
	}

	// Token: 0x0600BCCB RID: 48331 RVA: 0x00416E00 File Offset: 0x00415000
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BCCC RID: 48332 RVA: 0x00416E0C File Offset: 0x0041500C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600BCCD RID: 48333 RVA: 0x00416E18 File Offset: 0x00415018
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0.b8() != null)
		{
			if (A_0.b8().IsInCombat || bzl.a())
			{
				return false;
			}
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

	// Token: 0x0600BCCE RID: 48334 RVA: 0x00416EC8 File Offset: 0x004150C8
	public override IList<string> bi()
	{
		return d7f.p;
	}
}
