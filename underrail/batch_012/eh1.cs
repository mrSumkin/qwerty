using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02001115 RID: 4373
[eiz("S13")]
[Serializable]
public sealed class eh1 : cze, ISerializable
{
	// Token: 0x06005D27 RID: 23847 RVA: 0x0027AAD0 File Offset: 0x00278CD0
	private eh1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S13:S");
	}

	// Token: 0x06005D28 RID: 23848 RVA: 0x0027AAEC File Offset: 0x00278CEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S13:S", this.a);
	}

	// Token: 0x06005D29 RID: 23849 RVA: 0x0027AB08 File Offset: 0x00278D08
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005D2A RID: 23850 RVA: 0x0027AB10 File Offset: 0x00278D10
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D2B RID: 23851 RVA: 0x0027AB1C File Offset: 0x00278D1C
	public eh1()
	{
	}

	// Token: 0x06005D2C RID: 23852 RVA: 0x0027AB24 File Offset: 0x00278D24
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count > 0)
			{
				if (this.a)
				{
					etz etz = new etz(c5x);
					if (c5x.p.b.a[0].a.Contains("Orientation"))
					{
						etz.a = "Objects\\Devices\\StandingConsoleOrientation";
						etz.b.X = 1;
						etz.b.Y = c5x.p.b.a[0].b.Y;
					}
					else
					{
						etz.a = "Objects\\Devices\\StandingConsoleText";
						etz.b = c5x.p.b.a[0].b;
					}
					etz.c = new Color?(new Color(255, 255, 255, 255));
					etz.a(0);
					etz.b(1);
					etz.c(2);
					etz.d(350);
					if (c5x.p.b.a.Count > 1)
					{
						c5x.p.b.a[1] = etz;
					}
					else
					{
						c5x.p.b.a.Add(etz);
					}
					this.a(c5x, true);
					aru aru = c5x.c();
					aru.a("power", false);
					aru.a("power", "StandingConsoleTurnOn", 1f, c9z.a, false, false);
					return;
				}
				if (c5x.p.b.a.Count > 1)
				{
					c5x.p.b.a.RemoveRange(1, c5x.p.b.a.Count - 1);
				}
				this.a(c5x, false);
				aru aru2 = c5x.c();
				aru2.a("power", false);
				aru2.a("power", "StandingConsoleTurnOff", 1f, c9z.a, false, false);
			}
		}
	}

	// Token: 0x06005D2D RID: 23853 RVA: 0x0027AD60 File Offset: 0x00278F60
	private void a(c5x A_0, bool A_1)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			ah7 ah = A_0.Zone.i(A_0.qe().ToString() + "_consoleLantern");
			if (A_1)
			{
				if (ah != null)
				{
					ah.Enabled = true;
				}
				else
				{
					ah = new ah7(A_0.qe().ToString() + "_consoleLantern", A_0.Zone);
					ah.Layer = A_0.Layer;
					ah.Light = new ae8(new Color(75, 255, 75), 0.25f, LightType.Increment);
					ah.LightFadeRate = 0.1f;
					ah.Range = 3f;
					A_0.Zone.a(ah);
					ah.g().be(A_0);
				}
				ah.d();
				return;
			}
			if (ah != null)
			{
				ah.Enabled = false;
				ah.d();
			}
		}
	}

	// Token: 0x04002525 RID: 9509
	private new bool a;
}
