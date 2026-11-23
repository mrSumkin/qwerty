using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E6C RID: 7788
[ayj("DisarmGasGrenade")]
public sealed class ax9 : m0
{
	// Token: 0x0600AD0D RID: 44301 RVA: 0x003FAD44 File Offset: 0x003F8F44
	public override string y8()
	{
		return "Обезвредить газовую гранату";
	}

	// Token: 0x0600AD0E RID: 44302 RVA: 0x003FAD4C File Offset: 0x003F8F4C
	public override string os()
	{
		return "DisarmGasGrenade";
	}

	// Token: 0x0600AD0F RID: 44303 RVA: 0x003FAD54 File Offset: 0x003F8F54
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD10 RID: 44304 RVA: 0x003FAD58 File Offset: 0x003F8F58
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600AD11 RID: 44305 RVA: 0x003FAD5C File Offset: 0x003F8F5C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AD12 RID: 44306 RVA: 0x003FAD60 File Offset: 0x003F8F60
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.DisarmTrap);
	}

	// Token: 0x0600AD13 RID: 44307 RVA: 0x003FAD6C File Offset: 0x003F8F6C
	public override string c1()
	{
		return "Обезвреживает";
	}

	// Token: 0x0600AD14 RID: 44308 RVA: 0x003FAD74 File Offset: 0x003F8F74
	public ax9()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AD15 RID: 44309 RVA: 0x003FAD88 File Offset: 0x003F8F88
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600AD16 RID: 44310 RVA: 0x003FAD8C File Offset: 0x003F8F8C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD17 RID: 44311 RVA: 0x003FAD90 File Offset: 0x003F8F90
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DeployedGasGrenade;
	}

	// Token: 0x0600AD18 RID: 44312 RVA: 0x003FAD94 File Offset: 0x003F8F94
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AD19 RID: 44313 RVA: 0x003FAD9C File Offset: 0x003F8F9C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AD1A RID: 44314 RVA: 0x003FADA4 File Offset: 0x003F8FA4
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AD1B RID: 44315 RVA: 0x003FADAC File Offset: 0x003F8FAC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && !A_0.b8().IsInCombat;
	}

	// Token: 0x0600AD1C RID: 44316 RVA: 0x003FADE0 File Offset: 0x003F8FE0
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AD1D RID: 44317 RVA: 0x003FADE4 File Offset: 0x003F8FE4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AD1E RID: 44318 RVA: 0x003FADF0 File Offset: 0x003F8FF0
	protected override int br(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return 5000;
		}
		if (A_0.b8() is e3q)
		{
			return Math.Max(1000, 10000 - A_0.b8().Skills.Get<c0b>().g() * 50);
		}
		return 2500;
	}

	// Token: 0x04004066 RID: 16486
	private new List<string> a;
}
