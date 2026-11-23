using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B62 RID: 2914
[eiz("JY0")]
[Serializable]
public sealed class h9 : cze, ISerializable
{
	// Token: 0x060042B0 RID: 17072 RVA: 0x0019DFE8 File Offset: 0x0019C1E8
	private h9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x0019DFF4 File Offset: 0x0019C1F4
	public h9()
	{
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x0019E000 File Offset: 0x0019C200
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyvince_canPass", new bool?(false)).Value && A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && aspect.aa().FactionId == asp.a)
			{
				aud aud = A_0.Area;
				if (aud != null && aud.Zone != null)
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						foreach (d4n d4n in service.ahl())
						{
							if (!d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.r)
							{
								bm6 b = d4n.b.a8().t.b;
								if (b != null)
								{
									erl erl = b.c(aspect);
									if (erl != null && erl.f() == cem.d)
									{
										awq.a(d4n.b.a8(), aspect.a8(), false, false, true, false, false, false);
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
