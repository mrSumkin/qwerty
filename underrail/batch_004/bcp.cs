using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AE7 RID: 2791
[eiz("XPBLPIRDBJ")]
[Serializable]
public sealed class bcp : cze, ISerializable
{
	// Token: 0x060040ED RID: 16621 RVA: 0x0018BF04 File Offset: 0x0018A104
	private bcp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040EE RID: 16622 RVA: 0x0018BF10 File Offset: 0x0018A110
	public bcp()
	{
	}

	// Token: 0x060040EF RID: 16623 RVA: 0x0018BF1C File Offset: 0x0018A11C
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
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = new ar7(new Guid("35e575e9-eecb-42fb-ba18-3c887bb4c401"), aud).ao() as c5x;
				if (c5x != null && c5x.o.b != null)
				{
					ny aspect = c5x.GetAspect<ny>();
					if (aspect != null)
					{
						dqm dqm = new dqm(c5x.o.b);
						dqm.c(7);
						dqm.a(true);
						dqm.b(0);
						dqm.a(1);
						dqm.a(150.0);
						aspect.b(dqm, atp.a);
						c5x c5x2 = new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), aud).ao() as c5x;
						if (c5x2 != null && c5x2.t.b != null)
						{
							TimeSpan? primitivePropertyValue = c5x2.t.b.y6().GetPrimitivePropertyValue<TimeSpan>("NextBatResponse", null);
							if (primitivePropertyValue == null || primitivePropertyValue.Value < serviceOrThrow.aqu().o())
							{
								List<string> list = new List<string>
								{
									"Оставь эту летучую мышь в покое.",
									"Оставь это!",
									"Ты хочешь потерять палец?",
									"Эй!",
									"Что с тобой?",
									"Отойди от этой клетки."
								};
								string a_ = list[cuo.a.Next(0, list.Count)];
								c0s aspect2 = c5x2.GetAspect<c0s>();
								if (aspect2 != null)
								{
									aspect2.a(a_, true, null, null);
								}
								c5x2.t.b.y6()["NextBatResponse"] = serviceOrThrow.aqu().o() + TimeSpan.FromSeconds(5.0);
							}
						}
					}
				}
			}
		}
	}
}
