using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020011A7 RID: 4519
[edy("DrT")]
public sealed class cff : d4x
{
	// Token: 0x0600604C RID: 24652 RVA: 0x002A0CE0 File Offset: 0x0029EEE0
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

	// Token: 0x0600604D RID: 24653 RVA: 0x002A0D48 File Offset: 0x0029EF48
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
		cnb cnb = new cnb(c5x);
		cnb.a(c5x.TileFormationModifiers.Clone() as bjp);
		c5x.SetAspect<bim>(cnb);
		bool? flag = null;
		c90.a(cnb, A_0);
		c90.a(cnb, A_0);
		if (A_0.f() != null)
		{
			cd.a = A_0.f().GetClassPropertyValue<string>("Model");
			cnb.a(A_0.f().GetPrimitivePropertyValue<int>("OpenedFrame", null));
			cnb.b(A_0.f().GetPrimitivePropertyValue<int>("ClosedFrame", null));
			cnb.c = A_0.f().GetPrimitivePropertyValue<int>("OpenedVisualPriority", null);
			cnb.b = A_0.f().GetPrimitivePropertyValue<int>("ClosedVisualPriority", null);
			flag = A_0.f().GetPrimitivePropertyValue<bool>("SimpleStates", null);
		}
		if (flag != null)
		{
			cnb.c(flag.Value);
		}
		cnb.d(false);
		return c5x;
	}
}
