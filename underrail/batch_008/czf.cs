using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F7B RID: 8059
[ayj("uwep")]
public sealed class czf : a6u
{
	// Token: 0x0600BCAE RID: 48302 RVA: 0x00416C54 File Offset: 0x00414E54
	public override string y8()
	{
		return "Разрядить оружие";
	}

	// Token: 0x0600BCAF RID: 48303 RVA: 0x00416C5C File Offset: 0x00414E5C
	public override string os()
	{
		return "UnloadWeapon";
	}

	// Token: 0x0600BCB0 RID: 48304 RVA: 0x00416C64 File Offset: 0x00414E64
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BCB1 RID: 48305 RVA: 0x00416C68 File Offset: 0x00414E68
	public override string c1()
	{
		return "Разряжает";
	}

	// Token: 0x0600BCB2 RID: 48306 RVA: 0x00416C70 File Offset: 0x00414E70
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BCB3 RID: 48307 RVA: 0x00416C84 File Offset: 0x00414E84
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BCB5 RID: 48309 RVA: 0x00416C90 File Offset: 0x00414E90
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BCB6 RID: 48310 RVA: 0x00416C94 File Offset: 0x00414E94
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BCB7 RID: 48311 RVA: 0x00416C98 File Offset: 0x00414E98
	public override string bm(cnm A_0)
	{
		return "Ammo.Unload";
	}

	// Token: 0x0600BCB8 RID: 48312 RVA: 0x00416CA0 File Offset: 0x00414EA0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BCB9 RID: 48313 RVA: 0x00416CA4 File Offset: 0x00414EA4
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Ammo/UnloadWeapon");
	}

	// Token: 0x0600BCBA RID: 48314 RVA: 0x00416CB0 File Offset: 0x00414EB0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BCBB RID: 48315 RVA: 0x00416CBC File Offset: 0x00414EBC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600BCBC RID: 48316 RVA: 0x00416CC4 File Offset: 0x00414EC4
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		cd1 cd = A_0.b9() as cd1;
		return cd != null && (!cd.TypedDefinition.ao && (eub.c(cd) || eub.d(cd.TypedDefinition.ak()))) && cd.LoadedAmmo.Count > 0;
	}

	// Token: 0x0600BCBD RID: 48317 RVA: 0x00416D34 File Offset: 0x00414F34
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600BCBE RID: 48318 RVA: 0x00416D3C File Offset: 0x00414F3C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600BCBF RID: 48319 RVA: 0x00416D44 File Offset: 0x00414F44
	protected override int hi(cnm A_0)
	{
		return 5;
	}
}
