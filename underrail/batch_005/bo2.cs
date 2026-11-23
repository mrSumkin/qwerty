using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009A9 RID: 2473
[eiz("LUSRDF")]
[Serializable]
public sealed class bo2 : bdw, ISerializable
{
	// Token: 0x06003BA0 RID: 15264 RVA: 0x00161080 File Offset: 0x0015F280
	private bo2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BA1 RID: 15265 RVA: 0x00161088 File Offset: 0x0015F288
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BA2 RID: 15266 RVA: 0x0016108C File Offset: 0x0015F28C
	public bo2()
	{
	}

	// Token: 0x06003BA3 RID: 15267 RVA: 0x00161098 File Offset: 0x0015F298
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b30");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null)
				{
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROSpyRevealed", new bool?(false)).Value)
					{
						doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b30_l2") + ".uzl");
						aud.Zone.a(a_, 1, null);
					}
					c5x c5x = new ar7(new Guid("f90895e8-bd57-4abb-923c-f9cf73213ca7"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("c8f0375e-09b4-402c-bc19-cdc2bbf49601"), aud).ao() as c5x;
					if (c5x != null)
					{
						c5x.an();
						c5x.w();
					}
					if (c5x2 != null)
					{
						c5x2.an();
						c5x2.w();
					}
				}
			}
		}
	}
}
