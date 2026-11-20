using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E89 RID: 7817
[ayj("RegularAcidVialThrow")]
public sealed class boc : brm
{
	// Token: 0x0600AEDE RID: 44766 RVA: 0x003FCCCC File Offset: 0x003FAECC
	public override string y8()
	{
		return "Бросок колбы с кислотой";
	}

	// Token: 0x0600AEDF RID: 44767 RVA: 0x003FCCD4 File Offset: 0x003FAED4
	public override string os()
	{
		return "RegularAcidVialThrow";
	}

	// Token: 0x0600AEE0 RID: 44768 RVA: 0x003FCCDC File Offset: 0x003FAEDC
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/RegularThrowAcidVial", new object[]
		{
			boc.a(A_0).a(true)
		});
	}

	// Token: 0x0600AEE1 RID: 44769 RVA: 0x003FCD0C File Offset: 0x003FAF0C
	public new static a1q a(cnm A_0)
	{
		return new a1q(DamageType.Acid, boc.a, boc.b);
	}

	// Token: 0x0400408A RID: 16522
	private new static readonly int a = 30;

	// Token: 0x0400408B RID: 16523
	private static readonly int b = 60;
}
