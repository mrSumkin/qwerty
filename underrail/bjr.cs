using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AE3 RID: 2787
[eiz("XPBLSSMJ")]
[Serializable]
public sealed class bjr : cze, ISerializable
{
	// Token: 0x060040E0 RID: 16608 RVA: 0x0018BB34 File Offset: 0x00189D34
	private bjr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040E1 RID: 16609 RVA: 0x0018BB40 File Offset: 0x00189D40
	public bjr()
	{
	}

	// Token: 0x060040E2 RID: 16610 RVA: 0x0018BB4C File Offset: 0x00189D4C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		try
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.Area != null && c5x.Zone != null && A_2 != null)
			{
				float num = (float)A_2["distance"];
				if ((this.b += (double)num) >= bjr.a / 5.0)
				{
					this.b -= bjr.a / 5.0;
					Vector3 vector = (Vector3)A_2["oldLocation"] + new Vector3(-0.15f + 0.3f * (float)cuo.a.NextDouble(), -0.15f + 0.3f * (float)cuo.a.NextDouble(), -0.05f + 0.1f * (float)cuo.a.NextDouble());
					vector += new Vector3(0f, 0f, A_0.Size.Z * 0.5f);
					aex.a(c5x.Area, vector, 0, 1800, true, false);
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x04001C09 RID: 7177
	private new static readonly double a = 0.3;

	// Token: 0x04001C0A RID: 7178
	[NonSerialized]
	private double b;
}
