using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000B1E RID: 2846
[eiz("XPBLMPC")]
[Serializable]
public sealed class bx1 : cze, ISerializable
{
	// Token: 0x060041BB RID: 16827 RVA: 0x00195A9C File Offset: 0x00193C9C
	private bx1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x00195AA8 File Offset: 0x00193CA8
	public bx1()
	{
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x00195AB4 File Offset: 0x00193CB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c1a c1a = c5x.Zone;
				c5x c5x2 = new ar7(new Guid("73ba905d-5255-40e1-9d98-779c27d127ef"), c1a.n("xpbl_mc1")).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("eabde184-521e-4f9e-a163-22b091837252"), c1a.n("xpbl_mc1_west")).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("af9ad050-6170-4e64-add5-ba413a0d6e44"), c1a.n("xpbl_mc1_west")).ao() as c5x;
				if (c5x2 == null)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_mc1_l" + 2.ToString()) + ".uzl");
					c1a.a(a_, 1, null);
					if (c5x2 != null && c5x2.h.b != null)
					{
						c5x2.h.b.aa().c(asp.a);
					}
				}
				if (c5x3 == null)
				{
					doq a_2 = doq.a(Path.Combine(d5x.q(), "xpbl_mc1_l" + 3.ToString()) + ".uzl");
					c1a.a(a_2, 1, null);
					if (c5x3 != null && c5x3.h.b != null)
					{
						c5x3.h.b.aa().c(asp.a);
					}
				}
				if (c5x4 != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_handledPharmacist", null).Value)
				{
					if (new Random().Next(0, 101) > 70)
					{
						c5x4.w();
						c5x4.an();
					}
					serviceOrThrow.aqu().r()["loc_xpbl_mc_handledPharmacist"] = true;
				}
			}
		}
	}
}
