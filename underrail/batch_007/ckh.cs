using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B87 RID: 2951
[eiz("CCBRJ")]
[Serializable]
public sealed class ckh : cze, ISerializable
{
	// Token: 0x06004350 RID: 17232 RVA: 0x001A4F78 File Offset: 0x001A3178
	private ckh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004351 RID: 17233 RVA: 0x001A4F84 File Offset: 0x001A3184
	public ckh()
	{
	}

	// Token: 0x06004352 RID: 17234 RVA: 0x001A4F8C File Offset: 0x001A318C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!dz6.e() && A_0 != null && A_0.qe() == new Guid("0bd75ab3-f566-4b64-bd6a-161c8e7f63b1"))
		{
			c0s aspect = A_0.GetAspect<c0s>();
			if (aspect != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.f("cc_shack"), new bool?(false)).Value)
				{
					int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_ccblanket_complaints", new int?(0)).Value;
					List<string> list;
					if (num >= 2)
					{
						list = new List<string>
						{
							"Н-нет, оп-пять!",
							"К-к-к-к... ::Он делает глубокий вдох.:: К-кто это д-делает?! Х-х-хватит! Пожалуйста!",
							"::Начинает плакать.::",
							"З-за что?!"
						};
					}
					else
					{
						list = new List<string>
						{
							"Н-не... Н-нет!",
							"Я ж-же п-п-пропущу и-игру!",
							"П-п-проклятье!",
							"XЪ-XЪ-XЪ-XЪ!"
						};
					}
					string a_ = list[cuo.a.Next(list.Count)];
					aspect.a(a_, true, null, null);
					num++;
					serviceOrThrow.aqu().r()["npc_ccblanket_complaints"] = num;
				}
			}
		}
	}
}
