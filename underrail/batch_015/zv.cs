using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EF8 RID: 7928
[ayj("RahmsLaserEye")]
public sealed class zv : c0z
{
	// Token: 0x0600B54C RID: 46412 RVA: 0x004096DC File Offset: 0x004078DC
	public override string y8()
	{
		return "Третий глаз";
	}

	// Token: 0x0600B54D RID: 46413 RVA: 0x004096E4 File Offset: 0x004078E4
	public override string os()
	{
		return "RahmsLaserEye";
	}

	// Token: 0x0600B54E RID: 46414 RVA: 0x004096EC File Offset: 0x004078EC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B54F RID: 46415 RVA: 0x004096F0 File Offset: 0x004078F0
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B550 RID: 46416 RVA: 0x004096F4 File Offset: 0x004078F4
	public zv()
	{
		this.e = new List<string>();
		this.e.Add("SA.RahmsLaserEye");
	}

	// Token: 0x0600B551 RID: 46417 RVA: 0x0040971C File Offset: 0x0040791C
	public override a3b bl(cnm A_0, efk A_1)
	{
		a3b a3b = new a3b();
		if (A_0 != null && A_0.b8() != null && A_0.b8().Offense.au() == WeaponKey.Secondary)
		{
			a3b.c = c0e.s;
		}
		else
		{
			a3b.c = c0e.r;
		}
		return a3b;
	}

	// Token: 0x0600B552 RID: 46418 RVA: 0x00409774 File Offset: 0x00407974
	public override string bm(cnm A_0)
	{
		return "SpecialAttacks.0";
	}

	// Token: 0x0600B553 RID: 46419 RVA: 0x0040977C File Offset: 0x0040797C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B554 RID: 46420 RVA: 0x00409780 File Offset: 0x00407980
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B555 RID: 46421 RVA: 0x00409788 File Offset: 0x00407988
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.RahmsLaserEye", zv.b, false, false)
		};
	}

	// Token: 0x0600B556 RID: 46422 RVA: 0x004097A8 File Offset: 0x004079A8
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B557 RID: 46423 RVA: 0x004097B0 File Offset: 0x004079B0
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B558 RID: 46424 RVA: 0x004097B8 File Offset: 0x004079B8
	protected override float f0(cnm A_0)
	{
		return (float)zv.d;
	}

	// Token: 0x0600B559 RID: 46425 RVA: 0x004097C0 File Offset: 0x004079C0
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0400420F RID: 16911
	private new const string a = "SA.RahmsLaserEye";

	// Token: 0x04004210 RID: 16912
	public static readonly int b = d0u.b * 3;

	// Token: 0x04004211 RID: 16913
	public static readonly a1q c = new a1q(DamageType.Energy, 200, 300);

	// Token: 0x04004212 RID: 16914
	public static readonly int d = 10;

	// Token: 0x04004213 RID: 16915
	private new List<string> e;
}
