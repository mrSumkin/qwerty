using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B02 RID: 2818
[eiz("XPBLCVWPRTRSJ")]
[Serializable]
public sealed class cpa : cze, ISerializable
{
	// Token: 0x06004147 RID: 16711 RVA: 0x0018F194 File Offset: 0x0018D394
	private cpa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004148 RID: 16712 RVA: 0x0018F1A0 File Offset: 0x0018D3A0
	public cpa()
	{
	}

	// Token: 0x06004149 RID: 16713 RVA: 0x0018F1AC File Offset: 0x0018D3AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_cvw_prc1_raisedShields", new bool?(false)).Value)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"shields"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.o.b != null)
					{
						c5x.o.b.b.X = ((c5x.o.b.b.X == 0) ? 5 : 6);
						c5x.TileFormationModifiers = new bjp(new byte[]
						{
							0,
							1,
							2
						});
						c5x.z();
					}
				}
				bfq bfq = new bfq();
				bfq.b("shields");
				bfq.c("MetalShieldsSlideUp");
				bfq.ym(null, serviceOrThrow.aqu().v().b(), null);
				c5x c5x2 = new ar7(new Guid("b5c37c08-7a9e-43b9-97b0-f63d9231bde1"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
				if (c5x2 != null && c5x2.s.b != null)
				{
					c5x2.s.b.g(true);
				}
				serviceOrThrow.aqu().r()["loc_xpbl_cvw_prc1_raisedShields"] = true;
			}
		}
	}
}
