using System;

// Token: 0x02001E54 RID: 7764
internal class eu2
{
	// Token: 0x0600AC20 RID: 44064 RVA: 0x003F8FA0 File Offset: 0x003F71A0
	public static void a(c3n A_0, cnm A_1)
	{
		if (A_1 != null && A_1.b8() != null && A_0 != null)
		{
			v5 a_ = bpo.GetServiceOrThrow<io>().ahg() ? v5.a : v5.b;
			A_1.b8().Cooldowns.a(A_0.bq(A_1, a_));
			A_1.b8().Cooldowns.a(A_0.p5(A_1, a_));
		}
	}
}
