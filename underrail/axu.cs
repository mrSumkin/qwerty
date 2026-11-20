using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale.Data;

// Token: 0x020011A8 RID: 4520
[edy("RmT")]
public sealed class axu : d4x
{
	// Token: 0x0600604F RID: 24655 RVA: 0x002A0ED0 File Offset: 0x0029F0D0
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

	// Token: 0x06006050 RID: 24656 RVA: 0x002A0EF0 File Offset: 0x0029F0F0
	protected override b0b jo(c5k A_0, Guid? A_1 = null)
	{
		c5x c5x;
		if (A_0.f().GetPrimitivePropertyValue<bool>("Complex", new bool?(false)).Value)
		{
			c5x = (new c1p().a(A_0, A_1, false) as c5x);
		}
		else
		{
			if (A_1 != null)
			{
				c5x = new c5x(A_1.Value);
			}
			else
			{
				c5x = new c5x();
			}
			cd0 cd = c90.a(c5x, A_0, "");
			cd.a = A_0.f().GetClassPropertyValue<string>("Model");
			c90.a(c5x, A_0);
			c5x.SetAspect<cd0>(cd);
		}
		int? primitivePropertyValue = A_0.f().GetPrimitivePropertyValue<int>("Randomize", null);
		if (primitivePropertyValue != null)
		{
			int num = axu.a.Next(primitivePropertyValue.Value);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					c5x.aji();
				}
			}
		}
		c5x.Size = new Vector3(1f, 1f, 0.1f);
		c5x.IsGround = true;
		ContainerBehavior containerBehavior = ContainerBehavior.None;
		string classPropertyValue = A_0.f().GetClassPropertyValue<string>("Container");
		if (classPropertyValue != null)
		{
			containerBehavior = (ContainerBehavior)Enum.Parse(typeof(ContainerBehavior), classPropertyValue);
		}
		if (containerBehavior != ContainerBehavior.None)
		{
			c7j c7j = new c7j(c5x);
			if (containerBehavior != ContainerBehavior.Normal)
			{
				d3y d3y = new d3y();
				d3y.a(containerBehavior == ContainerBehavior.DespawnWhenEmpty);
				c7j.p().Add(d3y);
			}
			c5x.SetAspect<bim>(c7j);
			c90.a(c7j, A_0);
			c90.a(c7j, A_0);
		}
		return c5x;
	}

	// Token: 0x04002914 RID: 10516
	private new static Random a = new Random();
}
