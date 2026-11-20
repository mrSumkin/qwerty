using System;
using System.Runtime.Serialization;

// Token: 0x0200092A RID: 2346
[eiz("CCCOLTP")]
[Serializable]
public sealed class dmc : bdw, ISerializable
{
	// Token: 0x0600399C RID: 14748 RVA: 0x00154D50 File Offset: 0x00152F50
	private dmc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600399D RID: 14749 RVA: 0x00154D58 File Offset: 0x00152F58
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x00154D5C File Offset: 0x00152F5C
	public dmc()
	{
	}

	// Token: 0x0600399F RID: 14751 RVA: 0x00154D68 File Offset: 0x00152F68
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("cc18");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f82c3fd8-7f69-4b63-8c1a-9d61d22ab95f"), aud).ao() as c5x;
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
				serviceOrThrow.aqu().r()["faction_Coretech_allowedEntry"] = false;
			}
		}
	}
}
