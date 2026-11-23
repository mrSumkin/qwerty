using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011AC RID: 4524
[edy("WlT")]
public sealed class duo : d4x
{
	// Token: 0x06006063 RID: 24675 RVA: 0x002A29A4 File Offset: 0x002A0BA4
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

	// Token: 0x06006064 RID: 24676 RVA: 0x002A29C4 File Offset: 0x002A0BC4
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
		c5x.Size = new Vector3(1f, 1f, 1f);
		a9g a9g = new a9g(c5x);
		if (A_0.f() != null)
		{
			a9g.a = A_0.f().GetClassPropertyValue<string>("Model");
		}
		c5x.SetAspect<cd0>(a9g);
		return c5x;
	}
}
