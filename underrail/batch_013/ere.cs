using System;
using System.Collections.Generic;

// Token: 0x02000456 RID: 1110
public class ere : pd
{
	// Token: 0x06001CF1 RID: 7409 RVA: 0x000A0CA8 File Offset: 0x0009EEA8
	public ere(string A_0, Func<TimeSpan, double, bool> A_1 = null, Func<bool, float> A_2 = null, IEnumerable<c96> A_3 = null) : base(A_0, A_3)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x000A0CC4 File Offset: 0x0009EEC4
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.a == null || this.a(A_0, A_1);
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x000A0CE0 File Offset: 0x0009EEE0
	public override float km(bool A_0)
	{
		if (this.b != null)
		{
			return this.b(A_0);
		}
		return base.km(A_0);
	}

	// Token: 0x04001000 RID: 4096
	private new Func<TimeSpan, double, bool> a;

	// Token: 0x04001001 RID: 4097
	private new Func<bool, float> b;
}
