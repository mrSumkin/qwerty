using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E57 RID: 7767
[ayj("DelayedEntityUse")]
public sealed class cjb : m0
{
	// Token: 0x0600AC27 RID: 44071 RVA: 0x003F91D4 File Offset: 0x003F73D4
	public override string y8()
	{
		return "Использование";
	}

	// Token: 0x0600AC28 RID: 44072 RVA: 0x003F91DC File Offset: 0x003F73DC
	public override string os()
	{
		return "DelayedEntityUse";
	}

	// Token: 0x0600AC29 RID: 44073 RVA: 0x003F91E4 File Offset: 0x003F73E4
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AC2A RID: 44074 RVA: 0x003F91E8 File Offset: 0x003F73E8
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600AC2B RID: 44075 RVA: 0x003F91EC File Offset: 0x003F73EC
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600AC2C RID: 44076 RVA: 0x003F9200 File Offset: 0x003F7400
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AC2D RID: 44077 RVA: 0x003F9204 File Offset: 0x003F7404
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AC2E RID: 44078 RVA: 0x003F920C File Offset: 0x003F740C
	public cjb()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AC2F RID: 44079 RVA: 0x003F9224 File Offset: 0x003F7424
	public override string p6(cnm A_0)
	{
		if (A_0 != null)
		{
			dke dke = A_0.ca() as dke;
			if (dke != null)
			{
				return dke.b();
			}
		}
		return "Using";
	}

	// Token: 0x0600AC30 RID: 44080 RVA: 0x003F9258 File Offset: 0x003F7458
	public override bool c3(cnm A_0)
	{
		return true;
	}

	// Token: 0x0600AC31 RID: 44081 RVA: 0x003F925C File Offset: 0x003F745C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AC32 RID: 44082 RVA: 0x003F9260 File Offset: 0x003F7460
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Any;
	}

	// Token: 0x0600AC33 RID: 44083 RVA: 0x003F9264 File Offset: 0x003F7464
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AC34 RID: 44084 RVA: 0x003F926C File Offset: 0x003F746C
	public override string bp(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AC35 RID: 44085 RVA: 0x003F9274 File Offset: 0x003F7474
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AC36 RID: 44086 RVA: 0x003F927C File Offset: 0x003F747C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AC37 RID: 44087 RVA: 0x003F9280 File Offset: 0x003F7480
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AC38 RID: 44088 RVA: 0x003F9288 File Offset: 0x003F7488
	protected override int br(cnm A_0)
	{
		if (A_0 != null)
		{
			dke dke = A_0.ca() as dke;
			if (dke != null)
			{
				return dke.a();
			}
		}
		return 1000;
	}

	// Token: 0x0400401A RID: 16410
	private new List<string> a;
}
