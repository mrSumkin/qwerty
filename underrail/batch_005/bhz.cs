using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011AD RID: 4525
[edy("TrT")]
public sealed class bhz : d4x
{
	// Token: 0x06006066 RID: 24678 RVA: 0x002A2A50 File Offset: 0x002A0C50
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

	// Token: 0x06006067 RID: 24679 RVA: 0x002A2A6C File Offset: 0x002A0C6C
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
		c5x.IsFloor = true;
		c5x.Size = new Vector3(1f, 1f, 0f);
		cd0 cd = new c2j(c5x);
		if (A_0.f() != null)
		{
			cd.a = A_0.f().GetClassPropertyValue<string>("Model");
		}
		c5x.SetAspect<cd0>(cd);
		c90.a(c5x, A_0);
		string classPropertyValue = A_0.f().GetClassPropertyValue<string>("Frame");
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			cd.b = zy.b(classPropertyValue);
		}
		return c5x;
	}
}
