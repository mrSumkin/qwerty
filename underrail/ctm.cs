using System;

// Token: 0x02001E91 RID: 7825
[ayj("BlindingPoisonKnifeThrow")]
public sealed class ctm : a0y
{
	// Token: 0x0600AF20 RID: 44832 RVA: 0x003FD52C File Offset: 0x003FB72C
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF21 RID: 44833 RVA: 0x003FD534 File Offset: 0x003FB734
	public override string os()
	{
		return "BlindingPoisonKnifeThrow";
	}

	// Token: 0x0600AF22 RID: 44834 RVA: 0x003FD540 File Offset: 0x003FB740
	public override string bp(cnm A_0)
	{
		int num = ezx.l;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/BlindingPoison", new object[]
		{
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}
}
