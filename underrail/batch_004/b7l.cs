using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EA4 RID: 7844
[ayj("SoundGunResonatingWave")]
public sealed class b7l : bon
{
	// Token: 0x0600B02F RID: 45103 RVA: 0x003FF9C0 File Offset: 0x003FDBC0
	public override string y8()
	{
		return "Резонирующая волна";
	}

	// Token: 0x0600B030 RID: 45104 RVA: 0x003FF9C8 File Offset: 0x003FDBC8
	public override string os()
	{
		return "SoundGunResonatingWave";
	}

	// Token: 0x0600B031 RID: 45105 RVA: 0x003FF9D0 File Offset: 0x003FDBD0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B032 RID: 45106 RVA: 0x003FF9D4 File Offset: 0x003FDBD4
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B033 RID: 45107 RVA: 0x003FF9D8 File Offset: 0x003FDBD8
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B034 RID: 45108 RVA: 0x003FF9DC File Offset: 0x003FDBDC
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B035 RID: 45109 RVA: 0x003FF9E0 File Offset: 0x003FDBE0
	public override bool xc()
	{
		return true;
	}

	// Token: 0x0600B037 RID: 45111 RVA: 0x003FF9EC File Offset: 0x003FDBEC
	public override string bm(cnm A_0)
	{
		return "SoundGun.ResonatingWave";
	}

	// Token: 0x0600B038 RID: 45112 RVA: 0x003FF9F4 File Offset: 0x003FDBF4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B039 RID: 45113 RVA: 0x003FF9F8 File Offset: 0x003FDBF8
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/SoundGunResonatingWave");
	}

	// Token: 0x0600B03A RID: 45114 RVA: 0x003FFA04 File Offset: 0x003FDC04
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B03B RID: 45115 RVA: 0x003FFA10 File Offset: 0x003FDC10
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B03C RID: 45116 RVA: 0x003FFA44 File Offset: 0x003FDC44
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.a
		};
	}

	// Token: 0x0600B03D RID: 45117 RVA: 0x003FFA58 File Offset: 0x003FDC58
	protected override int br(cnm A_0)
	{
		return 200;
	}

	// Token: 0x040040D3 RID: 16595
	public new static readonly double a = 2.0;

	// Token: 0x040040D4 RID: 16596
	public static readonly double b = 0.5;
}
