using System;

// Token: 0x02001E8E RID: 7822
[ayj("BurrowerPoisonKnifeThrow")]
public sealed class el9 : a0y
{
	// Token: 0x0600AF13 RID: 44819 RVA: 0x003FD394 File Offset: 0x003FB594
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF14 RID: 44820 RVA: 0x003FD39C File Offset: 0x003FB59C
	public override string os()
	{
		return "BurrowerPoisonKnifeThrow";
	}

	// Token: 0x0600AF15 RID: 44821 RVA: 0x003FD3A8 File Offset: 0x003FB5A8
	public override string bp(cnm A_0)
	{
		int num = el9.b;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/BurrowerPoison", new object[]
		{
			num,
			l4.a(el9.a, false),
			el9.c
		});
	}

	// Token: 0x04004098 RID: 16536
	public new static readonly int a = 5;

	// Token: 0x04004099 RID: 16537
	public static readonly int b = 7;

	// Token: 0x0400409A RID: 16538
	public static readonly int c = 5;
}
