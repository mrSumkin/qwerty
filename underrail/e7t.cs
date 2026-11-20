using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F05 RID: 7941
[ayj("Lock")]
public sealed class e7t : c0z
{
	// Token: 0x0600B61F RID: 46623 RVA: 0x0040AA70 File Offset: 0x00408C70
	public override string y8()
	{
		return "Запереть";
	}

	// Token: 0x0600B620 RID: 46624 RVA: 0x0040AA78 File Offset: 0x00408C78
	public override string os()
	{
		return "Lock";
	}

	// Token: 0x0600B621 RID: 46625 RVA: 0x0040AA80 File Offset: 0x00408C80
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B622 RID: 46626 RVA: 0x0040AA84 File Offset: 0x00408C84
	public override int bh()
	{
		return -2147483645;
	}

	// Token: 0x0600B623 RID: 46627 RVA: 0x0040AA8C File Offset: 0x00408C8C
	public override bool ar4()
	{
		return false;
	}

	// Token: 0x0600B624 RID: 46628 RVA: 0x0040AA90 File Offset: 0x00408C90
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Lock);
	}

	// Token: 0x0600B625 RID: 46629 RVA: 0x0040AA9C File Offset: 0x00408C9C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600B627 RID: 46631 RVA: 0x0040AAB8 File Offset: 0x00408CB8
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B628 RID: 46632 RVA: 0x0040AABC File Offset: 0x00408CBC
	public override string bm(cnm A_0)
	{
		return "Abilities.10";
	}

	// Token: 0x0600B629 RID: 46633 RVA: 0x0040AAC4 File Offset: 0x00408CC4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LockableObject;
	}

	// Token: 0x0600B62A RID: 46634 RVA: 0x0040AAC8 File Offset: 0x00408CC8
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/Lock");
	}

	// Token: 0x0600B62B RID: 46635 RVA: 0x0040AAD4 File Offset: 0x00408CD4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B62C RID: 46636 RVA: 0x0040AADC File Offset: 0x00408CDC
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600B62D RID: 46637 RVA: 0x0040AAE4 File Offset: 0x00408CE4
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B62E RID: 46638 RVA: 0x0040AAE8 File Offset: 0x00408CE8
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B62F RID: 46639 RVA: 0x0040AAEC File Offset: 0x00408CEC
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B630 RID: 46640 RVA: 0x0040AAF4 File Offset: 0x00408CF4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0400423D RID: 16957
	private new const string a = "Lock";
}
