using System;
using System.Collections.Generic;

// Token: 0x020011A3 RID: 4515
[edy("CmpObT")]
public sealed class c1p : d4x
{
	// Token: 0x0600603D RID: 24637 RVA: 0x0029FBC4 File Offset: 0x0029DDC4
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>();
	}

	// Token: 0x0600603E RID: 24638 RVA: 0x0029FBD0 File Offset: 0x0029DDD0
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
		c5x.g = e2b.e;
		c90.a(c5x, A_0);
		alv alv = new alv(c5x);
		int? primitivePropertyValue = A_0.f().GetPrimitivePropertyValue<int>("ComponentsCount", null);
		if (primitivePropertyValue != null)
		{
			for (int i = 0; i < primitivePropertyValue.Value; i++)
			{
				cd0 a_ = c90.a(c5x, A_0, i.ToString() + ":");
				alv.a(a_);
			}
		}
		c5x.SetAspect<alv>(alv);
		c90.a(c5x, A_0, alv);
		return c5x;
	}
}
