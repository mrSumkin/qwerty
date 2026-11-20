using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020007DC RID: 2012
[eiz("TSWT")]
[Serializable]
public sealed class c2u : ya, ISerializable
{
	// Token: 0x06003269 RID: 12905 RVA: 0x00139AE0 File Offset: 0x00137CE0
	private c2u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x00139AEC File Offset: 0x00137CEC
	public c2u()
	{
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x00139AF4 File Offset: 0x00137CF4
	protected override void tk(b0b A_0)
	{
		base.tk(A_0);
		if (this.a(A_0))
		{
			this.b(A_0);
		}
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x00139B10 File Offset: 0x00137D10
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		if (this.a(A_0))
		{
			this.b(A_0);
		}
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x00139B30 File Offset: 0x00137D30
	private void b(b0b A_0)
	{
		c5x a_ = A_0 as c5x;
		if (this.a(a_))
		{
			ak1 ak = base.Area.a(base.Location);
			if (ak != null)
			{
				bool flag = false;
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.GetAspect<y2>() != null)
					{
						flag = true;
						c5x.w();
						c5x.an();
					}
				}
				if (flag)
				{
					boj.a(base.Area, new Vector3((float)base.Location.X, (float)base.Location.Y, 0.5f), null, "SpiderWebDestroyed", 1, double.MaxValue, null, null, null, null);
				}
			}
			base.o();
		}
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x00139C58 File Offset: 0x00137E58
	private bool a(c5x A_0)
	{
		return A_0 != null && A_0.h.b != null && A_0.h.b.aa().FactionId != asp.@as;
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x00139C94 File Offset: 0x00137E94
	private bool a(b0b A_0)
	{
		if (base.Area != null)
		{
			ak1 ak = base.Area.a(base.Location);
			if (ak != null)
			{
				return aw1.a(A_0, ak) <= c2u.a;
			}
		}
		return true;
	}

	// Token: 0x04001B00 RID: 6912
	private static readonly double a = 0.65;
}
