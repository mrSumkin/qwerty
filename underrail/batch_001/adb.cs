using System;
using System.Runtime.Serialization;

// Token: 0x02000C6C RID: 3180
[eiz("FO5VCCC")]
[Serializable]
public sealed class adb : dnh
{
	// Token: 0x0600478D RID: 18317 RVA: 0x001D7874 File Offset: 0x001D5A74
	private adb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600478E RID: 18318 RVA: 0x001D7880 File Offset: 0x001D5A80
	public adb()
	{
	}

	// Token: 0x0600478F RID: 18319 RVA: 0x001D788C File Offset: 0x001D5A8C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("fo5");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("5e9e10c8-0f1d-4a37-80fc-bb75d632ecfd"), aud).ao() as c5x;
				if (c5x != null)
				{
					c7j c7j = c5x.s.b as c7j;
					if (c7j != null)
					{
						foreach (coh coh in c7j.ItemContainer.z2())
						{
							if (coh.Definition != null && coh.Definition.a5() != "impureChromiumBlade")
							{
								return false;
							}
						}
						return true;
					}
				}
			}
		}
		return false;
	}
}
