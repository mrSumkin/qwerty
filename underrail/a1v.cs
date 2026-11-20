using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B56 RID: 2902
[eiz("CVWRCFCJ")]
[Serializable]
public sealed class a1v : cze, ISerializable
{
	// Token: 0x0600428B RID: 17035 RVA: 0x0019CE30 File Offset: 0x0019B030
	private a1v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x0019CE3C File Offset: 0x0019B03C
	public a1v()
	{
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x0019CE48 File Offset: 0x0019B048
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = new ar7(new Guid("86861088-6417-40da-bdb2-27bf7b47fb0d"), A_0.Area).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					foreach (coh coh in c7j.ItemContainer.z2())
					{
						if (coh.Definition != null && coh.Definition.a5() == "cigar")
						{
							c7j.ItemContainer.z5(coh);
							break;
						}
					}
				}
			}
		}
	}
}
