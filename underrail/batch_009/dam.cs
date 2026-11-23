using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000991 RID: 2449
[eiz("UPDEL")]
[Serializable]
public sealed class dam : bdw, ISerializable
{
	// Token: 0x06003B40 RID: 15168 RVA: 0x0015F2CC File Offset: 0x0015D4CC
	private dam(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B41 RID: 15169 RVA: 0x0015F2D4 File Offset: 0x0015D4D4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B42 RID: 15170 RVA: 0x0015F2D8 File Offset: 0x0015D4D8
	public dam()
	{
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x0015F2E4 File Offset: 0x0015D4E4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up-lw1");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "up-lw_L2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				c5x c5x = new ar7(new Guid("59b21330-98ef-49a3-9a35-84e2b86a68fe"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				c5x c5x2 = new ar7(new Guid("64487dca-7403-4e2c-9174-02774f51d467"), aud).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				c5x c5x3 = new ar7(new Guid("662ee008-9437-4968-970b-0c9272d805fc"), aud).ao() as c5x;
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x4 = (c5x)b0b;
					if (c5x4.h.b != null && c5x4.h.b.aa().FactionId == asp.bp)
					{
						c5x4.w();
						c5x4.an();
					}
					else if (c5x4.s.b != null && c5x4.s.b is c7j)
					{
						c3g aspect = c5x4.GetAspect<c3g>();
						if (aspect != null && aspect.d().Contains("protectorate_epione"))
						{
							c7j c7j = c5x4.GetAspect<bim>() as c7j;
							if (c7j != null)
							{
								c7j.ItemContainer.z2().Clear();
								if (c5x4.y8().Equals("Locker"))
								{
									c7j.d(true);
								}
								d2b aspect2 = c5x4.GetAspect<d2b>();
								if (aspect2 != null)
								{
									aspect2.a(true, false);
								}
							}
						}
					}
				}
			}
		}
	}
}
