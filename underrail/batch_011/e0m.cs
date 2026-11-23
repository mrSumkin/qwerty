using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B1A RID: 2842
[eiz("XPBLKFJ")]
[Serializable]
public sealed class e0m : cze, ISerializable
{
	// Token: 0x060041AB RID: 16811 RVA: 0x00195030 File Offset: 0x00193230
	private e0m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x0019503C File Offset: 0x0019323C
	public e0m()
	{
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x00195048 File Offset: 0x00193248
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			aud aud = null;
			if (A_0 != null)
			{
				aud = A_0.Area;
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f617b91c-e9b0-41b0-8eda-e9db938e8710"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), aud).ao() as c5x;
				if (c5x2 != null)
				{
					ak1 ak = aud.b((int)c5x2.Location.X, (int)c5x2.Location.Y);
					if (ak != null && c5x != null && (ak.Location.X == 10 || ak.Location.X == 11 || ak.Location.X == 12) && ak.Location.Y == 4)
					{
						if (c5x2.h.b != null)
						{
							coh coh = Enumerable.FirstOrDefault<coh>(c5x2.h.b.aa().Bag.b("key.xpbl_e3_jail"));
							if (coh != null)
							{
								c5x2.h.b.aa().Bag.z5(coh);
							}
							coh coh2 = Enumerable.FirstOrDefault<coh>(c5x2.h.b.aa().Bag.b("key.xpbl_e3_itemsLocker"));
							if (coh2 != null)
							{
								c5x2.h.b.aa().Bag.z5(coh2);
							}
						}
						c5x.Location = new Vector3((float)ak.Location.X + 0.4f, 3.7f, 0.1f);
						c5x.ae = new float?((float)1);
						c5x.ah();
						if (c5x.s.b != null)
						{
							c5x.s.b.g(true);
						}
						bfq bfq = new bfq("keys", "KeysDrop");
						bfq.a(true);
						bfq.a(c9z.b);
						bfq.d(false);
						bfq.ym(c5x, null, null);
					}
				}
			}
		}
	}
}
