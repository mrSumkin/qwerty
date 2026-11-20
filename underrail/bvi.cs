using System;
using System.Runtime.Serialization;

// Token: 0x0200092B RID: 2347
[eiz("CCJKKOLTP")]
[Serializable]
public sealed class bvi : bdw, ISerializable
{
	// Token: 0x060039A0 RID: 14752 RVA: 0x00154E14 File Offset: 0x00153014
	private bvi(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039A1 RID: 14753 RVA: 0x00154E1C File Offset: 0x0015301C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x00154E20 File Offset: 0x00153020
	public bvi()
	{
	}

	// Token: 0x060039A3 RID: 14755 RVA: 0x00154E2C File Offset: 0x0015302C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("cc20");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("e50a471d-2b99-4847-b044-c01b71cfeb58"), aud).ao() as c5x;
				if (c5x != null)
				{
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					c3g aspect = c5x.GetAspect<c3g>();
					if (cnb != null && cnb.q())
					{
						cnb.d(false);
					}
					if (aspect != null)
					{
						aspect.b().Remove("player");
					}
				}
				serviceOrThrow.aqu().r()["faction_JKK_allowedEntry"] = false;
			}
		}
	}
}
