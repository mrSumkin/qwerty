using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A53 RID: 2643
[eiz("SLPSJ")]
[Serializable]
public sealed class qs : cze
{
	// Token: 0x06003E82 RID: 16002 RVA: 0x001798DC File Offset: 0x00177ADC
	private qs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SLPSJ:S");
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x001798F8 File Offset: 0x00177AF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLPSJ:S", this.a);
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x00179914 File Offset: 0x00177B14
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x0017991C File Offset: 0x00177B1C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x00179928 File Offset: 0x00177B28
	public qs()
	{
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x00179934 File Offset: 0x00177B34
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				if (this.a)
				{
					if (!(c5x.GetAspect<cd0>() is etz))
					{
						etz etz = new etz(c5x);
						if (c5x.o.b != null)
						{
							etz.b = c5x.o.b.b;
							etz.a = c5x.o.b.a;
						}
						else
						{
							string str = "X";
							if (c5x.Size.Y > 1f)
							{
								str = "Y";
							}
							etz.b = new Point(0, 0);
							etz.a = "Objects\\Devices\\OilPump" + str;
						}
						etz.a(0);
						etz.b(1);
						etz.c(16);
						etz.d(150);
						c5x.RemoveAspect<cd0>();
						c5x.SetAspect<cd0>(etz);
						c5x.c().a("power", "OilPumpLoop", 1f, c9z.b, true, false);
						return;
					}
				}
				else
				{
					etz etz2 = c5x.GetAspect<cd0>() as etz;
					if (etz2 != null)
					{
						cd0 cd = new cd0(c5x);
						cd.b = etz2.a(true, null);
						cd.a = etz2.a;
						c5x.RemoveAspect<etz>();
						c5x.SetAspect<cd0>(cd);
					}
					c5x.c().a("power", false);
				}
			}
		}
	}

	// Token: 0x04001BBB RID: 7099
	private new bool a;
}
