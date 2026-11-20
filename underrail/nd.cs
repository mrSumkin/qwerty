using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E96 RID: 7830
[ayj("Branding")]
public sealed class nd : bon, bxf
{
	// Token: 0x0600AF3F RID: 44863 RVA: 0x003FD8EC File Offset: 0x003FBAEC
	public override string y8()
	{
		return "Клеймение";
	}

	// Token: 0x0600AF40 RID: 44864 RVA: 0x003FD8F4 File Offset: 0x003FBAF4
	public override string os()
	{
		return "Branding";
	}

	// Token: 0x0600AF41 RID: 44865 RVA: 0x003FD8FC File Offset: 0x003FBAFC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF42 RID: 44866 RVA: 0x003FD900 File Offset: 0x003FBB00
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AF43 RID: 44867 RVA: 0x003FD904 File Offset: 0x003FBB04
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600AF44 RID: 44868 RVA: 0x003FD908 File Offset: 0x003FBB08
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600AF45 RID: 44869 RVA: 0x003FD90C File Offset: 0x003FBB0C
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600AF47 RID: 44871 RVA: 0x003FD918 File Offset: 0x003FBB18
	public override string bm(cnm A_0)
	{
		return "Attacks.35";
	}

	// Token: 0x0600AF48 RID: 44872 RVA: 0x003FD920 File Offset: 0x003FBB20
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AF49 RID: 44873 RVA: 0x003FD928 File Offset: 0x003FBB28
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Branding", new object[]
		{
			nd.b.a(true),
			nd.c.ToString("P0"),
			l4.a(nd.d, false)
		});
	}

	// Token: 0x0600AF4A RID: 44874 RVA: 0x003FD97C File Offset: 0x003FBB7C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AF4B RID: 44875 RVA: 0x003FD988 File Offset: 0x003FBB88
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600AF4C RID: 44876 RVA: 0x003FD9BC File Offset: 0x003FBBBC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AF4D RID: 44877 RVA: 0x003FD9C4 File Offset: 0x003FBBC4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AF4E RID: 44878 RVA: 0x003FD9CC File Offset: 0x003FBBCC
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0600AF4F RID: 44879 RVA: 0x003FD9D0 File Offset: 0x003FBBD0
	public bg3 i3(efk A_0, efk A_1, cmn A_2, double A_3)
	{
		if (A_0 == null || A_1 == null)
		{
			return null;
		}
		A_2.j *= nd.a;
		return euf.a(A_0, A_1, A_2, A_3, null);
	}

	// Token: 0x0400409F RID: 16543
	public new static readonly double a = 2.0;

	// Token: 0x040040A0 RID: 16544
	public static readonly a1q b = new a1q(DamageType.Heat, 30, 40);

	// Token: 0x040040A1 RID: 16545
	public static readonly float c = 0.2f;

	// Token: 0x040040A2 RID: 16546
	public static readonly int d = 10;
}
