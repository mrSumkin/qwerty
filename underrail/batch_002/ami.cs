using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F6D RID: 8045
public abstract class ami : ehl
{
	// Token: 0x0600BC23 RID: 48163 RVA: 0x00415B98 File Offset: 0x00413D98
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x00415B9C File Offset: 0x00413D9C
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BC25 RID: 48165 RVA: 0x00415BA4 File Offset: 0x00413DA4
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BC26 RID: 48166 RVA: 0x00415BA8 File Offset: 0x00413DA8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600BC27 RID: 48167 RVA: 0x00415BB4 File Offset: 0x00413DB4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600BC28 RID: 48168 RVA: 0x00415BB8 File Offset: 0x00413DB8
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BC29 RID: 48169 RVA: 0x00415BBC File Offset: 0x00413DBC
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BC2A RID: 48170 RVA: 0x00415BC4 File Offset: 0x00413DC4
	protected override int br(cnm A_0)
	{
		if (A_0.b8().Offense.u().TypedDefinition.a5() == "wheeledBot1Gun")
		{
			return 0;
		}
		return as3.@as;
	}

	// Token: 0x0600BC2B RID: 48171 RVA: 0x00415C04 File Offset: 0x00413E04
	protected override float f0(cnm A_0)
	{
		return (float)as3.at;
	}

	// Token: 0x0600BC2C RID: 48172 RVA: 0x00415C10 File Offset: 0x00413E10
	protected override int hi(cnm A_0)
	{
		int num = 15;
		c6b microfeat = A_0.b8().GetMicrofeat<c6b>();
		if (microfeat != null)
		{
			num = Math.Max(0, num + microfeat.a());
		}
		return num;
	}

	// Token: 0x0600BC2D RID: 48173 RVA: 0x00415C44 File Offset: 0x00413E44
	protected new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.c(A_0.b8());
		}
		return as3.au * d0u.b;
	}
}
