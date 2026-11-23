using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AD8 RID: 2776
[eiz("XPBLCVWPRTLSJ")]
[Serializable]
public sealed class wh : cze, ISerializable
{
	// Token: 0x060040BA RID: 16570 RVA: 0x0018A944 File Offset: 0x00188B44
	private wh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040BB RID: 16571 RVA: 0x0018A950 File Offset: 0x00188B50
	public wh()
	{
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x0018A95C File Offset: 0x00188B5C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_cvw_prc1_raisedShields", new bool?(false)).Value)
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
						c5x.o.b.b.X = ((c5x.o.b.b.X == 5) ? 0 : 2);
						c5x.TileFormationModifiers.c();
						c5x.z();
					}
				}
				bfq bfq = new bfq();
				bfq.b("shields");
				bfq.c("MetalShieldsSlideDown");
				bfq.ym(null, serviceOrThrow.aqu().v().b(), null);
				c5x c5x2 = new ar7(new Guid("b5c37c08-7a9e-43b9-97b0-f63d9231bde1"), serviceOrThrow.aqu().v().b().Area).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
			}
		}
	}
}
