using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A50 RID: 2640
[eiz("CCUPZDGJ")]
[Serializable]
public sealed class a42 : cze, ISerializable
{
	// Token: 0x06003E79 RID: 15993 RVA: 0x001794A8 File Offset: 0x001776A8
	private a42(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x001794B4 File Offset: 0x001776B4
	public a42()
	{
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x001794C0 File Offset: 0x001776C0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			if (dk2.f())
			{
				float? ae = c5x.ae;
				float num = 0f;
				if (!(ae.GetValueOrDefault() == num & ae != null))
				{
					c5x.ae = new float?(0f);
					c5x.TileFormationModifiers = new bjp();
					return;
				}
			}
			else if (c5x.ae != null)
			{
				c5x.ae = null;
				c5x.TileFormationModifiers = new bjp(new byte[]
				{
					0,
					1,
					2
				});
			}
		}
	}
}
