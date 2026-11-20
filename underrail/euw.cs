using System;

// Token: 0x02001E90 RID: 7824
[ayj("BlackDragonPoisonKnifeThrow")]
public sealed class euw : a0y
{
	// Token: 0x0600AF1C RID: 44828 RVA: 0x003FD4D8 File Offset: 0x003FB6D8
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AF1D RID: 44829 RVA: 0x003FD4E0 File Offset: 0x003FB6E0
	public override string os()
	{
		return "BlackDragonPoisonKnifeThrow";
	}

	// Token: 0x0600AF1E RID: 44830 RVA: 0x003FD4E8 File Offset: 0x003FB6E8
	public override string bp(cnm A_0)
	{
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/BlackDragonPoison", new object[]
		{
			l4.a(ezx.g, false)
		});
	}
}
