using System;
using System.Collections.Generic;

// Token: 0x020011A1 RID: 4513
[edy("SiObT")]
public sealed class dvg : d4x
{
	// Token: 0x0600603A RID: 24634 RVA: 0x0029FB48 File Offset: 0x0029DD48
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>
		{
			{
				"Model",
				typeof(string)
			}
		};
	}

	// Token: 0x0600603B RID: 24635 RVA: 0x0029FB64 File Offset: 0x0029DD64
	protected override b0b jo(c5k A_0, Guid? A_1 = null)
	{
		c5x c5x;
		if (A_1 != null)
		{
			c5x = new c5x(A_1.Value);
		}
		else
		{
			c5x = new c5x();
		}
		c90.a(c5x, A_0);
		cd0 cd = c90.a(c5x, A_0, "");
		c5x.SetAspect<cd0>(cd);
		c90.a(c5x, A_0, cd);
		return c5x;
	}
}
