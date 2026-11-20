using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B9C RID: 2972
[eiz("XPBLMCCIPDSBO")]
[Serializable]
public sealed class dne : cze, ISerializable
{
	// Token: 0x0600439A RID: 17306 RVA: 0x001A874C File Offset: 0x001A694C
	private dne(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600439B RID: 17307 RVA: 0x001A8758 File Offset: 0x001A6958
	public dne()
	{
	}

	// Token: 0x0600439C RID: 17308 RVA: 0x001A8764 File Offset: 0x001A6964
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_pharmacyRoomExists", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("af9ad050-6170-4e64-add5-ba413a0d6e44"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("8a507957-2b55-4f2a-bb9a-af2437af393d"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("e7a71fbf-86f9-49d5-8fe9-98da64d8d5ec"), aud).ao() as c5x;
				Random random = new Random(serviceOrThrow.aqu().l());
				if (c5x != null && c5x2 != null && c5x3 != null && c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4("guard_pharmacist2");
					c5x2.w();
					c5x2.an();
					cnb cnb = c5x3.GetAspect<bim>() as cnb;
					if (cnb != null)
					{
						cnb.g(true);
					}
					if (c5x.h.b != null)
					{
						if (random.Next(0, 101) > 50)
						{
							c5x.h.b.aa().FactionId = asp.a3;
							d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
							if (addon == null)
							{
								return;
							}
							using (List<b0b>.Enumerator enumerator = addon.ab4(new string[]
							{
								"loc_xpbl_mc1_protectedContainers"
							}).GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									b0b b0b = enumerator.Current;
									c5x c5x4 = (c5x)b0b;
									if (c5x4 != null && c5x4.GetAspect<c3g>() == null)
									{
										c3g c3g = new c3g(c5x4);
										c5x4.SetAspect<c3g>(c3g);
										c3g.d().Add(asp.a3);
									}
								}
								return;
							}
						}
						c5x.b("dsp_xpbl_mc1_servants");
					}
				}
			}
		}
	}
}
