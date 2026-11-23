using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001831 RID: 6193
[ayj("PsiReconstructivePillConsumation")]
public sealed class bnf : awn
{
	// Token: 0x060083FF RID: 33791 RVA: 0x00370A9C File Offset: 0x0036EC9C
	public override string y8()
	{
		return "Psycho-neural Reconstructive Agent";
	}

	// Token: 0x06008400 RID: 33792 RVA: 0x00370AA4 File Offset: 0x0036ECA4
	public override string os()
	{
		return "PsiReconstructivePillConsumation";
	}

	// Token: 0x06008401 RID: 33793 RVA: 0x00370AAC File Offset: 0x0036ECAC
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x06008403 RID: 33795 RVA: 0x00370AB8 File Offset: 0x0036ECB8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x06008404 RID: 33796 RVA: 0x00370ABC File Offset: 0x0036ECBC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x06008405 RID: 33797 RVA: 0x00370AC0 File Offset: 0x0036ECC0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/PsiReconstructivePill", new object[]
		{
			ck.GetFeat<ck5>().Name
		});
	}

	// Token: 0x06008406 RID: 33798 RVA: 0x00370AE4 File Offset: 0x0036ECE4
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ck5>();
	}

	// Token: 0x040032A7 RID: 12967
	public new static readonly int a = 8;
}
