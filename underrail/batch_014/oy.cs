using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011AB RID: 4523
[edy("CntT")]
public sealed class oy : d4x
{
	// Token: 0x06006060 RID: 24672 RVA: 0x002A2810 File Offset: 0x002A0A10
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>
		{
			{
				"Model",
				typeof(string)
			},
			{
				"SimpleStates",
				typeof(bool)
			},
			{
				"OpenedFrame",
				typeof(int)
			},
			{
				"ClosedFrame",
				typeof(int)
			}
		};
	}

	// Token: 0x06006061 RID: 24673 RVA: 0x002A2878 File Offset: 0x002A0A78
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
		c90.a(c5x, A_0);
		cd0 cd = c90.a(c5x, A_0, "");
		c5x.SetAspect<cd0>(cd);
		c7j c7j = new c7j(c5x);
		c5x.SetAspect<bim>(c7j);
		bool? flag = null;
		if (A_0.f() != null)
		{
			cd.a = A_0.f().GetClassPropertyValue<string>("Model");
			c7j.a(A_0.f().GetPrimitivePropertyValue<int>("OpenedFrame", null));
			c7j.b(A_0.f().GetPrimitivePropertyValue<int>("ClosedFrame", null));
			flag = A_0.f().GetPrimitivePropertyValue<bool>("SimpleStates", null);
		}
		if (flag != null)
		{
			c7j.c(flag.Value);
		}
		c90.a(c7j, A_0);
		c90.a(c7j, A_0);
		return c5x;
	}
}
