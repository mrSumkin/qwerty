using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008FE RID: 2302
[eiz("CCGAUNT8")]
[Serializable]
public sealed class cp8 : bdw, ISerializable
{
	// Token: 0x060038E7 RID: 14567 RVA: 0x001515C4 File Offset: 0x0014F7C4
	private cp8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038E8 RID: 14568 RVA: 0x001515CC File Offset: 0x0014F7CC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038E9 RID: 14569 RVA: 0x001515D0 File Offset: 0x0014F7D0
	public cp8()
	{
	}

	// Token: 0x060038EA RID: 14570 RVA: 0x001515DC File Offset: 0x0014F7DC
	public void av(c1a A_0, cyt A_1)
	{
		int num = dkr.f();
		if (A_0 != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_0.Areas);
			if (aud != null)
			{
				dkr.a(aud, new string[]
				{
					"939ba19f-fc87-4a76-97bc-ffc12c7639c6"
				});
				c5x c5x = aud.a(new Guid("b309c915-88da-4d64-b905-181fdb6d92ad")) as c5x;
				if (c5x != null)
				{
					bpq.e(c5x);
				}
				if (num > 0)
				{
					csd csd = A_0.g("e1");
					csd csd2 = A_0.g("e2");
					csd csd3 = A_0.g("e3");
					if (csd != null)
					{
						c5x c5x2 = vq.a("creatures\\machines\\wheeledBot1", csd, false);
						if (c5x2 != null)
						{
							c5x2.h.b.aa().FactionId = asp.@as;
						}
					}
					if (csd2 != null && num > 1)
					{
						c5x c5x3 = vq.a("creatures\\machines\\wheeledBot1", csd2, false);
						if (c5x3 != null)
						{
							c5x3.h.b.aa().FactionId = asp.@as;
						}
					}
					if (csd3 != null && num > 2)
					{
						c5x c5x4 = vq.a("creatures\\machines\\plasmaSentry", csd3, false);
						if (c5x4 != null)
						{
							c5x4.h.b.aa().FactionId = asp.@as;
						}
					}
				}
			}
		}
	}
}
