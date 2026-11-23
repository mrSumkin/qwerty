using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001113 RID: 4371
[eiz("SLSS")]
[Serializable]
public sealed class ckm : cze, ISerializable
{
	// Token: 0x06005D18 RID: 23832 RVA: 0x0027A7C0 File Offset: 0x002789C0
	private ckm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SLSS:S");
	}

	// Token: 0x06005D19 RID: 23833 RVA: 0x0027A7DC File Offset: 0x002789DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLSS:S", this.a);
	}

	// Token: 0x06005D1A RID: 23834 RVA: 0x0027A7F8 File Offset: 0x002789F8
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005D1B RID: 23835 RVA: 0x0027A800 File Offset: 0x00278A00
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D1C RID: 23836 RVA: 0x0027A80C File Offset: 0x00278A0C
	public ckm()
	{
	}

	// Token: 0x06005D1D RID: 23837 RVA: 0x0027A818 File Offset: 0x00278A18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
			{
				if (this.a)
				{
					c5x.p.b.a[1].b = new Point(2, c5x.p.b.a[1].b.Y);
					c5x.p.b.a[1].c = null;
				}
				else
				{
					c5x.p.b.a[1].b = new Point(1, c5x.p.b.a[1].b.Y);
					c5x.p.b.a[1].c = new Color?(new Color(255, 255, 255));
				}
				aru aru = c5x.c();
				aru.a("switch", false);
				aru.a("switch", "LightSwitch", 1f, c9z.a, false, false);
			}
		}
	}

	// Token: 0x04002522 RID: 9506
	private new bool a;
}
