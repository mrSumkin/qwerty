using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x020007C1 RID: 1985
[eiz("DCTSCS")]
[Serializable]
public sealed class asd : cze, ISerializable
{
	// Token: 0x060031B6 RID: 12726 RVA: 0x0013085C File Offset: 0x0012EA5C
	private asd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("DCTSCS:S");
	}

	// Token: 0x060031B7 RID: 12727 RVA: 0x00130878 File Offset: 0x0012EA78
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCTSCS:S", this.a);
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x00130894 File Offset: 0x0012EA94
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060031B9 RID: 12729 RVA: 0x0013089C File Offset: 0x0012EA9C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x001308A8 File Offset: 0x0012EAA8
	public asd()
	{
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x001308B4 File Offset: 0x0012EAB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				if (this.a)
				{
					c5x.o.b.b = new Point(2, 0);
					this.a(c5x, true);
					aru aru = c5x.c();
					aru.a("power", false);
					aru.a("power", "StandingConsoleTurnOn", 1f, c9z.a, false, false);
					return;
				}
				c5x.o.b.b = new Point(2, 1);
				this.a(c5x, false);
				aru aru2 = c5x.c();
				aru2.a("power", false);
				aru2.a("power", "StandingConsoleTurnOff", 1f, c9z.a, false, false);
			}
		}
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x00130984 File Offset: 0x0012EB84
	private void a(c5x A_0, bool A_1)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			ah7 ah = A_0.Zone.i(A_0.qe().ToString() + "_cellLantern");
			if (A_1)
			{
				if (ah != null)
				{
					ah.Enabled = true;
				}
				else
				{
					ah = new ah7(A_0.qe().ToString() + "_cellLantern", A_0.Zone);
					ah.Layer = A_0.Layer;
					ah.Light = new ae8(new Color(0, 20, 50), 1f, LightType.Increment);
					ah.LightFadeRate = 0.11f;
					ah.Range = 2f;
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

	// Token: 0x04001ABD RID: 6845
	private new bool a;
}
