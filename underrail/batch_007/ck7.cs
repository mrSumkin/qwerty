using System;

// Token: 0x02001E8B RID: 7819
[ayj("HeartbreakPoisonKnifeThrow")]
public sealed class ck7 : a0y
{
	// Token: 0x0600AEF9 RID: 44793 RVA: 0x003FCFC4 File Offset: 0x003FB1C4
	public override string y8()
	{
		return "Бросок ножа";
	}

	// Token: 0x0600AEFA RID: 44794 RVA: 0x003FCFCC File Offset: 0x003FB1CC
	public override string os()
	{
		return "HeartbreakPoisonKnifeThrow";
	}

	// Token: 0x0600AEFB RID: 44795 RVA: 0x003FCFD4 File Offset: 0x003FB1D4
	public override string bp(cnm A_0)
	{
		int num = ezx.v;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return base.bp(A_0) + "\r\n\r\n" + qv.a("ThrowingKnives/HeartbreakPoison", new object[]
		{
			num,
			l4.a(ezx.y, false),
			ezx.x
		});
	}
}
