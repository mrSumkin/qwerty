using System;

// Token: 0x02001E8F RID: 7823
[ayj("CaveEarPoisonKnifeThrow")]
public sealed class aox : a0y
{
	// Token: 0x0600AF18 RID: 44824 RVA: 0x003FD458 File Offset: 0x003FB658
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF19 RID: 44825 RVA: 0x003FD460 File Offset: 0x003FB660
	public override string os()
	{
		return "CaveEarPoisonKnifeThrow";
	}

	// Token: 0x0600AF1A RID: 44826 RVA: 0x003FD46C File Offset: 0x003FB66C
	public override string bp(cnm A_0)
	{
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/CaveEarPoison", new object[]
		{
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(ezx.c, false)
		});
	}
}
