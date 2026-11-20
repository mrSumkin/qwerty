using System;

// Token: 0x02001E92 RID: 7826
[ayj("SpiritPoisonKnifeThrow")]
public sealed class a93 : a0y
{
	// Token: 0x0600AF24 RID: 44836 RVA: 0x003FD5E8 File Offset: 0x003FB7E8
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF25 RID: 44837 RVA: 0x003FD5F0 File Offset: 0x003FB7F0
	public override string os()
	{
		return "SpiritPoisonKnifeThrow";
	}

	// Token: 0x0600AF26 RID: 44838 RVA: 0x003FD5FC File Offset: 0x003FB7FC
	public override string bp(cnm A_0)
	{
		int num = ezx.i;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/SpiritPoison", new object[]
		{
			num,
			l4.a(ezx.h, false),
			(int)(ezx.j * 100.0)
		});
	}
}
