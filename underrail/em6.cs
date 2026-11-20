using System;
using System.Collections.Generic;

// Token: 0x0200184B RID: 6219
public sealed class em6 : a98
{
	// Token: 0x06008484 RID: 33924 RVA: 0x00372378 File Offset: 0x00370578
	public em6()
	{
	}

	// Token: 0x06008485 RID: 33925 RVA: 0x00372380 File Offset: 0x00370580
	public em6(string A_0, string A_1 = null, int A_2 = 1) : base(A_0, A_1)
	{
		this.a = A_2;
	}

	// Token: 0x06008486 RID: 33926 RVA: 0x00372394 File Offset: 0x00370594
	public override void m8(bm6 A_0, d7 A_1)
	{
		List<string> list = new List<string>();
		for (int i = 1; i <= this.a; i++)
		{
			list.Add(this.a + ":" + i.ToString());
		}
		A_0.y6()[ddq.k] = list;
		A_0.y6()[ddq.l] = A_1.b();
		A_0.y6()[ddq.n] = A_1.d();
	}

	// Token: 0x040032C3 RID: 12995
	public new int a;
}
