using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011A4 RID: 4516
[edy("OCUsT")]
public sealed class cpx : d4x
{
	// Token: 0x06006040 RID: 24640 RVA: 0x0029FC98 File Offset: 0x0029DE98
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

	// Token: 0x06006041 RID: 24641 RVA: 0x0029FD00 File Offset: 0x0029DF00
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
		b0e b0e = new b0e(c5x);
		c5x.SetAspect<bim>(b0e);
		c90.a(b0e, A_0);
		bool? flag = null;
		if (A_0.f() != null)
		{
			cd.a = A_0.f().GetClassPropertyValue<string>("Model");
			b0e.a(A_0.f().GetPrimitivePropertyValue<int>("OpenedFrame", null));
			b0e.b(A_0.f().GetPrimitivePropertyValue<int>("ClosedFrame", null));
			b0e.c(A_0.f().GetClassPropertyValue<string>("OpenSound"));
			b0e.d(A_0.f().GetClassPropertyValue<string>("CloseSound"));
			flag = A_0.f().GetPrimitivePropertyValue<bool>("SimpleStates", null);
		}
		if (flag != null)
		{
			b0e.c(flag.Value);
		}
		b0e.d(false);
		return c5x;
	}
}
