using System;
using System.Collections.Generic;

// Token: 0x02000452 RID: 1106
public sealed class cz8 : pd
{
	// Token: 0x06001CE1 RID: 7393 RVA: 0x000A0A14 File Offset: 0x0009EC14
	public cz8(string A_0, string A_1, object A_2) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x000A0A2C File Offset: 0x0009EC2C
	public cz8(string A_0, string A_1, object A_2, IEnumerable<c96> A_3) : base(A_0, A_3)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x000A0A48 File Offset: 0x0009EC48
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject != null && this.Subject.y6().GetPropertyValue(this.a) == this.b;
	}

	// Token: 0x04000FFE RID: 4094
	private new string a;

	// Token: 0x04000FFF RID: 4095
	private new object b;
}
