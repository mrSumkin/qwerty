using System;
using System.Runtime.Serialization;

// Token: 0x0200092C RID: 2348
[eiz("CCPSOLTP")]
[Serializable]
public sealed class bvg : bdw, ISerializable
{
	// Token: 0x060039A4 RID: 14756 RVA: 0x00154ED8 File Offset: 0x001530D8
	private bvg(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039A5 RID: 14757 RVA: 0x00154EE0 File Offset: 0x001530E0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039A6 RID: 14758 RVA: 0x00154EE4 File Offset: 0x001530E4
	public bvg()
	{
	}

	// Token: 0x060039A7 RID: 14759 RVA: 0x00154EF0 File Offset: 0x001530F0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("cc22");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("90092eb5-987f-471c-a18b-58360690203f"), aud).ao() as c5x;
				if (c5x != null)
				{
					c3g aspect = c5x.GetAspect<c3g>();
					if (aspect != null)
					{
						aspect.b().Remove("player");
					}
				}
				serviceOrThrow.aqu().r()["faction_Praetorian_allowedEntry"] = false;
			}
		}
	}
}
