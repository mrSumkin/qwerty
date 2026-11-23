using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200147A RID: 5242
[eiz("LFA")]
[Serializable]
public sealed class ena : a6k, ISerializable
{
	// Token: 0x0600764C RID: 30284 RVA: 0x003202EC File Offset: 0x0031E4EC
	private ena(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600764D RID: 30285 RVA: 0x003202F8 File Offset: 0x0031E4F8
	public ena()
	{
	}

	// Token: 0x0600764E RID: 30286 RVA: 0x00320304 File Offset: 0x0031E504
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			base.vg().q().c().a("Lighter");
			eks eks = c5x.GetAspect<bim>() as eks;
			if (eks != null)
			{
				string text;
				if (!eks.b(out text))
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
