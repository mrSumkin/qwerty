using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EDA RID: 7898
[ayj("GiantWeaverWebShoot")]
public sealed class adk : c0z
{
	// Token: 0x0600B354 RID: 45908 RVA: 0x004066D8 File Offset: 0x004048D8
	public override string y8()
	{
		return "Выстрел сеткой";
	}

	// Token: 0x0600B355 RID: 45909 RVA: 0x004066E0 File Offset: 0x004048E0
	public override string os()
	{
		return "GiantWeaverWebShoot";
	}

	// Token: 0x0600B356 RID: 45910 RVA: 0x004066E8 File Offset: 0x004048E8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B357 RID: 45911 RVA: 0x004066EC File Offset: 0x004048EC
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B358 RID: 45912 RVA: 0x004066F4 File Offset: 0x004048F4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.r,
			b = new int?(int.MaxValue),
			c = c0e.r.ToString(),
			f = c0e.q.ToString(),
			g = new int?(100),
			h = c0e.s.ToString(),
			i = new int?(100)
		};
	}

	// Token: 0x0600B359 RID: 45913 RVA: 0x0040676C File Offset: 0x0040496C
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B35A RID: 45914 RVA: 0x00406774 File Offset: 0x00404974
	public override string c1()
	{
		return "Выстрел сеткой";
	}

	// Token: 0x0600B35B RID: 45915 RVA: 0x0040677C File Offset: 0x0040497C
	public adk()
	{
		this.d = new List<string>();
		this.d.Add(adk.a);
	}

	// Token: 0x0600B35C RID: 45916 RVA: 0x004067A0 File Offset: 0x004049A0
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B35D RID: 45917 RVA: 0x004067A8 File Offset: 0x004049A8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B35E RID: 45918 RVA: 0x004067AC File Offset: 0x004049AC
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B35F RID: 45919 RVA: 0x004067B4 File Offset: 0x004049B4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(adk.a, adk.b, false, false)
		};
	}

	// Token: 0x0600B360 RID: 45920 RVA: 0x004067D4 File Offset: 0x004049D4
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B361 RID: 45921 RVA: 0x004067DC File Offset: 0x004049DC
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B362 RID: 45922 RVA: 0x004067E4 File Offset: 0x004049E4
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B363 RID: 45923 RVA: 0x004067E8 File Offset: 0x004049E8
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x04004195 RID: 16789
	private new static readonly string a = "GiantWeaverWebShoot";

	// Token: 0x04004196 RID: 16790
	private static readonly int b = 3 * d0u.b;

	// Token: 0x04004197 RID: 16791
	public static readonly int c = 2;

	// Token: 0x04004198 RID: 16792
	private List<string> d;
}
