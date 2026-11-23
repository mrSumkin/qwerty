using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000A34 RID: 2612
[eiz("CCCDP")]
[Serializable]
public sealed class d5l : bdw, ISerializable
{
	// Token: 0x06003E04 RID: 15876 RVA: 0x00175748 File Offset: 0x00173948
	private d5l(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E05 RID: 15877 RVA: 0x00175750 File Offset: 0x00173950
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E06 RID: 15878 RVA: 0x00175754 File Offset: 0x00173954
	public d5l()
	{
	}

	// Token: 0x06003E07 RID: 15879 RVA: 0x0017575C File Offset: 0x0017395C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc14");
			if (aud != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_gaveICPD", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("0d8f27d6-203e-4118-b504-e32590b565fa"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					IEnumerable<d5o> enumerable = c5x.h.b.aa().Bag.z2().a("currency.sc", 6000);
					cky cky = serviceOrThrow.aqu().ac().abu(asp.a, asp.dt);
					if (Enumerable.Sum<d5o>(enumerable, new Func<d5o, int>(d5l.a.a.a)) >= 1000 && cky.a != h.a)
					{
						serviceOrThrow.aqu().r()["npc_cc_duff_hasEnoughMoney"] = true;
						foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.h.b != null && c5x2.h.b.aa().FactionId == asp.dt)
							{
								c5x2.an();
								c5x2.w();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x02000A35 RID: 2613
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003E0A RID: 15882 RVA: 0x00175934 File Offset: 0x00173B34
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x04001BAF RID: 7087
		public static readonly d5l.a a = new d5l.a();

		// Token: 0x04001BB0 RID: 7088
		public static Func<d5o, int> b;
	}
}
