using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B39 RID: 2873
[eiz("D09")]
[Serializable]
public sealed class tq : cze, ISerializable
{
	// Token: 0x06004221 RID: 16929 RVA: 0x0019A1AC File Offset: 0x001983AC
	private tq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x0019A1B8 File Offset: 0x001983B8
	public tq()
	{
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x0019A1C4 File Offset: 0x001983C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b4b service = bpo.GetService<b4b>();
		if (service != null && service.yn() != null && service.yn().Zones.Count > 0)
		{
			aud aud = service.yn().Zones[0].n("si2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("36221d4b-590c-4be3-80c8-594c50d227a9"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<aru>();
					if (c5x.p.b != null && c5x.p.b.a.Count > 1)
					{
						c5x.p.b.a[1].c = null;
					}
				}
			}
		}
	}

	// Token: 0x04001C21 RID: 7201
	private new const int a = 30;
}
