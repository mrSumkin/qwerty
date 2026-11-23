using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E72 RID: 7794
[ayj("LightFire")]
public sealed class exi : m0
{
	// Token: 0x0600AD7D RID: 44413 RVA: 0x003FB514 File Offset: 0x003F9714
	public override string y8()
	{
		return "Light a Fire";
	}

	// Token: 0x0600AD7E RID: 44414 RVA: 0x003FB51C File Offset: 0x003F971C
	public override string os()
	{
		return "LightFire";
	}

	// Token: 0x0600AD7F RID: 44415 RVA: 0x003FB524 File Offset: 0x003F9724
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD80 RID: 44416 RVA: 0x003FB528 File Offset: 0x003F9728
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600AD81 RID: 44417 RVA: 0x003FB53C File Offset: 0x003F973C
	public override string c1()
	{
		return "Lighting";
	}

	// Token: 0x0600AD83 RID: 44419 RVA: 0x003FB54C File Offset: 0x003F974C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD84 RID: 44420 RVA: 0x003FB550 File Offset: 0x003F9750
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Fireplace;
	}

	// Token: 0x0600AD85 RID: 44421 RVA: 0x003FB554 File Offset: 0x003F9754
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AD86 RID: 44422 RVA: 0x003FB560 File Offset: 0x003F9760
	public override string bp(cnm A_0)
	{
		return "для курения и розжига.";
	}

	// Token: 0x0600AD87 RID: 44423 RVA: 0x003FB568 File Offset: 0x003F9768
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AD88 RID: 44424 RVA: 0x003FB570 File Offset: 0x003F9770
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AD89 RID: 44425 RVA: 0x003FB578 File Offset: 0x003F9778
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600AD8A RID: 44426 RVA: 0x003FB57C File Offset: 0x003F977C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AD8B RID: 44427 RVA: 0x003FB584 File Offset: 0x003F9784
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AD8C RID: 44428 RVA: 0x003FB588 File Offset: 0x003F9788
	protected override int hi(cnm A_0)
	{
		return 25;
	}
}
