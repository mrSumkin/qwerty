using System;
using System.Collections.Generic;

// Token: 0x02000457 RID: 1111
public class cm7 : pd
{
	// Token: 0x06001CF4 RID: 7412 RVA: 0x000A0D04 File Offset: 0x0009EF04
	public cm7(string A_0, Func<bool> A_1 = null, Func<bool, float> A_2 = null, IEnumerable<c96> A_3 = null) : base(A_0, A_3)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x000A0D20 File Offset: 0x0009EF20
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.a == null || this.a();
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x000A0D3C File Offset: 0x0009EF3C
	public override float km(bool A_0)
	{
		if (this.b != null)
		{
			return this.b(A_0);
		}
		return base.km(A_0);
	}

	// Token: 0x04001002 RID: 4098
	private new Func<bool> a;

	// Token: 0x04001003 RID: 4099
	private new Func<bool, float> b;
}
