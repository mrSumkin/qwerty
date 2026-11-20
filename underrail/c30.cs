using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011A9 RID: 4521
[edy("EfT")]
public sealed class c30 : d4x
{
	// Token: 0x06006053 RID: 24659 RVA: 0x002A10A8 File Offset: 0x0029F2A8
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>();
	}

	// Token: 0x06006054 RID: 24660 RVA: 0x002A10B0 File Offset: 0x0029F2B0
	protected override b0b jo(c5k A_0, Guid? A_1 = null)
	{
		int? primitivePropertyValue = A_0.f().GetPrimitivePropertyValue<int>("ComponentsCount", null);
		ccp ccp = null;
		c5x c5x;
		if (primitivePropertyValue != null && primitivePropertyValue.Value > 0)
		{
			c5x = (new c1p().a(A_0, A_1, false) as c5x);
			if (c5x != null)
			{
				ccp = c5x.p.b;
			}
		}
		else
		{
			c5x = (new dvg().a(A_0, A_1, false) as c5x);
			if (c5x != null)
			{
				ccp = c5x.o.b;
			}
		}
		if (c5x != null && ccp != null)
		{
			int? primitivePropertyValue2 = A_0.f().GetPrimitivePropertyValue<int>("Frames", null);
			int? primitivePropertyValue3 = A_0.f().GetPrimitivePropertyValue<int>("PhaseStep", null);
			dha dha = new dha(c5x, ccp, primitivePropertyValue2.GetValueOrDefault(5), primitivePropertyValue3.GetValueOrDefault(100));
			dha.a(A_0.f().GetPrimitivePropertyValue<bool>("Reverse", new bool?(false)).Value);
			c5x.SetAspect<dha>(dha);
			if (c5x.Size == Vector3.Zero)
			{
				c5x.Size = new Vector3(1f, 1f, 1f);
			}
			return c5x;
		}
		return null;
	}
}
