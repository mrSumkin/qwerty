using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011A5 RID: 4517
[edy("ChPlT")]
public sealed class bjf : d4x
{
	// Token: 0x06006043 RID: 24643 RVA: 0x0029FE58 File Offset: 0x0029E058
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>();
	}

	// Token: 0x06006044 RID: 24644 RVA: 0x0029FE64 File Offset: 0x0029E064
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
		c5x.Size = new Vector3(1f, 1f, 1f);
		cd0 cd = c90.a(c5x, A_0, "");
		cd.a = "Meta\\CharacterPlaceholder";
		c5x.SetAspect<cd0>(cd);
		ew1 aspect = new ew1(c5x);
		c5x.SetAspect<ew1>(aspect);
		return c5x;
	}
}
