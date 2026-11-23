using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E70 RID: 7792
[ayj("DisarmTrap")]
public sealed class bb3 : m0
{
	// Token: 0x0600AD58 RID: 44376 RVA: 0x003FB2F0 File Offset: 0x003F94F0
	public override string y8()
	{
		return "Обезвредить ловушку";
	}

	// Token: 0x0600AD59 RID: 44377 RVA: 0x003FB2F8 File Offset: 0x003F94F8
	public override string os()
	{
		return "DisarmTrap";
	}

	// Token: 0x0600AD5A RID: 44378 RVA: 0x003FB300 File Offset: 0x003F9500
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD5B RID: 44379 RVA: 0x003FB304 File Offset: 0x003F9504
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600AD5C RID: 44380 RVA: 0x003FB308 File Offset: 0x003F9508
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AD5D RID: 44381 RVA: 0x003FB30C File Offset: 0x003F950C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.DisarmTrap);
	}

	// Token: 0x0600AD5E RID: 44382 RVA: 0x003FB318 File Offset: 0x003F9518
	public override string c1()
	{
		return "Обезвреживает";
	}

	// Token: 0x0600AD5F RID: 44383 RVA: 0x003FB320 File Offset: 0x003F9520
	public bb3()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AD60 RID: 44384 RVA: 0x003FB334 File Offset: 0x003F9534
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600AD61 RID: 44385 RVA: 0x003FB338 File Offset: 0x003F9538
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD62 RID: 44386 RVA: 0x003FB33C File Offset: 0x003F953C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Trap;
	}

	// Token: 0x0600AD63 RID: 44387 RVA: 0x003FB340 File Offset: 0x003F9540
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AD64 RID: 44388 RVA: 0x003FB348 File Offset: 0x003F9548
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AD65 RID: 44389 RVA: 0x003FB350 File Offset: 0x003F9550
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AD66 RID: 44390 RVA: 0x003FB358 File Offset: 0x003F9558
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && !A_0.b8().IsInCombat;
	}

	// Token: 0x0600AD67 RID: 44391 RVA: 0x003FB38C File Offset: 0x003F958C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AD68 RID: 44392 RVA: 0x003FB390 File Offset: 0x003F9590
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AD69 RID: 44393 RVA: 0x003FB398 File Offset: 0x003F9598
	protected override int br(cnm A_0)
	{
		return 10000;
	}

	// Token: 0x0600AD6A RID: 44394 RVA: 0x003FB3A0 File Offset: 0x003F95A0
	protected override float te(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<c62>())
		{
			return (float)(1.0 - (c62.a + (double)A_0.b8().GetSpecializationValue<v6>(true) * v6.a));
		}
		return 1f;
	}

	// Token: 0x0400406D RID: 16493
	private new List<string> a;
}
