using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009F5 RID: 2549
[eiz("XPBLPIRRAFC")]
[Serializable]
public sealed class f2 : bdw, ISerializable
{
	// Token: 0x06003CE0 RID: 15584 RVA: 0x00169680 File Offset: 0x00167880
	private f2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CE1 RID: 15585 RVA: 0x00169688 File Offset: 0x00167888
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CE2 RID: 15586 RVA: 0x0016968C File Offset: 0x0016788C
	public f2()
	{
	}

	// Token: 0x06003CE3 RID: 15587 RVA: 0x00169698 File Offset: 0x00167898
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					"loc_" + A_0.y8() + "_aegisSecTroopers"
				});
				List<b0b> list2 = addon.ab4(new string[]
				{
					"loc_" + A_0.y8() + "_aegisJets"
				});
				foreach (b0b b0b in list)
				{
					if (b0b != null)
					{
						b0b.w();
						b0b.an();
					}
				}
				foreach (b0b b0b2 in list2)
				{
					if (b0b2 != null)
					{
						b0b2.w();
						b0b2.an();
					}
				}
			}
			this.a(A_0);
		}
	}

	// Token: 0x06003CE4 RID: 15588 RVA: 0x001697BC File Offset: 0x001679BC
	private void a(c1a A_0)
	{
		foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
				{
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					if (c7j != null)
					{
						foreach (coh coh in Enumerable.ToList<coh>(c7j.ItemContainer.z2()))
						{
							if (coh.Definition.bi() == a0.c)
							{
								Guid a_ = new Guid("0510a4a4-a842-4ae7-a160-b704b63e1f26");
								if (string.Equals(A_0.y8(), "xpbl_f3", StringComparison.OrdinalIgnoreCase))
								{
									a_ = new Guid("f9f5923d-e740-4d4e-98ae-2c8034570cee");
								}
								else if (string.Equals(A_0.y8(), "xpbl_e3", StringComparison.OrdinalIgnoreCase))
								{
									a_ = new Guid("0b3f27cd-4aa6-4175-ad9e-c21bbf116683");
								}
								c5x c5x2 = new ar7(a_, aud).ao() as c5x;
								if (c5x2 != null)
								{
									c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
									if (c7j2 != null)
									{
										c7j2.ItemContainer.z3(coh, true);
									}
								}
							}
						}
					}
					c5x.w();
					c5x.an();
				}
				else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
