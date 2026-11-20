using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EA6 RID: 7846
[ayj("SoundGunAmplifiedWave")]
public sealed class er6 : bon
{
	// Token: 0x0600B04F RID: 45135 RVA: 0x003FFB64 File Offset: 0x003FDD64
	public override string y8()
	{
		return "Усиленная волна";
	}

	// Token: 0x0600B050 RID: 45136 RVA: 0x003FFB6C File Offset: 0x003FDD6C
	public override string os()
	{
		return "SoundGunAmplifiedWave";
	}

	// Token: 0x0600B051 RID: 45137 RVA: 0x003FFB74 File Offset: 0x003FDD74
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B052 RID: 45138 RVA: 0x003FFB78 File Offset: 0x003FDD78
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B053 RID: 45139 RVA: 0x003FFB7C File Offset: 0x003FDD7C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B054 RID: 45140 RVA: 0x003FFB80 File Offset: 0x003FDD80
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B055 RID: 45141 RVA: 0x003FFB84 File Offset: 0x003FDD84
	public override bool xc()
	{
		return true;
	}

	// Token: 0x0600B057 RID: 45143 RVA: 0x003FFB90 File Offset: 0x003FDD90
	public override string bm(cnm A_0)
	{
		return "SoundGun.AmplifiedWave";
	}

	// Token: 0x0600B058 RID: 45144 RVA: 0x003FFB98 File Offset: 0x003FDD98
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B059 RID: 45145 RVA: 0x003FFB9C File Offset: 0x003FDD9C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/SoundGunAmplifiedWave", new object[]
		{
			(int)(er6.a * 100.0)
		});
	}

	// Token: 0x0600B05A RID: 45146 RVA: 0x003FFBC8 File Offset: 0x003FDDC8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B05B RID: 45147 RVA: 0x003FFBD4 File Offset: 0x003FDDD4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B05C RID: 45148 RVA: 0x003FFC08 File Offset: 0x003FDE08
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.a
		};
	}

	// Token: 0x0600B05D RID: 45149 RVA: 0x003FFC1C File Offset: 0x003FDE1C
	protected override int br(cnm A_0)
	{
		return 200;
	}

	// Token: 0x040040D7 RID: 16599
	public new static readonly double a = 0.3;

	// Token: 0x040040D8 RID: 16600
	public static readonly double b = 0.5;
}
