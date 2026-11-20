using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001748 RID: 5960
[eiz("RFA6")]
[Serializable]
public sealed class enl : a6k
{
	// Token: 0x0600806E RID: 32878 RVA: 0x003644C4 File Offset: 0x003626C4
	private enl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600806F RID: 32879 RVA: 0x003644D0 File Offset: 0x003626D0
	public enl()
	{
	}

	// Token: 0x06008070 RID: 32880 RVA: 0x003644DC File Offset: 0x003626DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			eks eks = c5x.GetAspect<bim>() as eks;
			if (eks != null)
			{
				string text;
				if (!eks.a(out text))
				{
					if (!string.IsNullOrEmpty(text))
					{
						bmj.a(base.vg().q(), new d53(text, adi.l, null, true));
						if (base.vg().q().h.b != null)
						{
							a7v.a(new h0(text, new Color?(adi.m)));
						}
					}
					return dc4.e;
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
