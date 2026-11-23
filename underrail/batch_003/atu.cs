using System;

// Token: 0x02001E8D RID: 7821
[ayj("LeperPoisonKnifeThrow")]
public sealed class atu : a0y
{
	// Token: 0x0600AF0F RID: 44815 RVA: 0x003FD2CC File Offset: 0x003FB4CC
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF10 RID: 44816 RVA: 0x003FD2D4 File Offset: 0x003FB4D4
	public override string os()
	{
		return "LeperPoisonKnifeThrow";
	}

	// Token: 0x0600AF11 RID: 44817 RVA: 0x003FD2E0 File Offset: 0x003FB4E0
	public override string bp(cnm A_0)
	{
		int num = ezx.q;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/LeperPoison", new object[]
		{
			num,
			l4.a(ezx.o, false),
			(int)(ezx.r * 100.0),
			ezx.s
		});
	}
}
