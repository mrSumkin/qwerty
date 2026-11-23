using System;
using System.Runtime.Serialization;

// Token: 0x02000C69 RID: 3177
[eiz("FOSSATLC")]
[Serializable]
public sealed class ddd : dnh
{
	// Token: 0x0600477E RID: 18302 RVA: 0x001D7630 File Offset: 0x001D5830
	private ddd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600477F RID: 18303 RVA: 0x001D763C File Offset: 0x001D583C
	public ddd()
	{
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x001D7648 File Offset: 0x001D5848
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("lu-b24");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("e0ec9d7d-e551-4ebe-ac32-ae02c3fa1b66"), aud).ao() as c5x;
				if (c5x != null)
				{
					c7j c7j = c5x.s.b as c7j;
					if (c7j != null)
					{
						foreach (coh coh in c7j.ItemContainer.z2())
						{
							if (coh.Definition != null && coh.Definition.a5() == "supersteel")
							{
								return true;
							}
						}
						return false;
					}
				}
			}
		}
		return false;
	}
}
