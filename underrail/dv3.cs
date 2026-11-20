using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000952 RID: 2386
[eiz("GEKWM")]
[Serializable]
public sealed class dv3 : bdw, ISerializable
{
	// Token: 0x06003A42 RID: 14914 RVA: 0x001593B0 File Offset: 0x001575B0
	private dv3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x001593B8 File Offset: 0x001575B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A44 RID: 14916 RVA: 0x001593BC File Offset: 0x001575BC
	public dv3()
	{
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x001593C8 File Offset: 0x001575C8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.v().b().Area != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"globalEventWoundedMan"
				})) as c5x;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Defense.q().zo() / Math.Max(1f, c5x.h.b.aa().Defense.q().zm()) < 0.5f)
				{
					c5x.h.b.aa().a(null, null, false);
				}
			}
		}
	}
}
