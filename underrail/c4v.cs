using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000A30 RID: 2608
[eiz("CEPFM")]
[Serializable]
public sealed class c4v : bdw, ISerializable
{
	// Token: 0x06003DF6 RID: 15862 RVA: 0x00175408 File Offset: 0x00173608
	private c4v(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x00175410 File Offset: 0x00173610
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x00175414 File Offset: 0x00173614
	public c4v()
	{
	}

	// Token: 0x06003DF9 RID: 15865 RVA: 0x00175420 File Offset: 0x00173620
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null && dk2.b("xpbl") && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_withoutMedallion", new bool?(false)).Value)
		{
			int i = 0;
			while (i < A_0.Areas.Count)
			{
				c5x c5x = new ar7(new Guid("c3523654-2a7d-4490-8c19-e56e53bc8971"), A_0.Areas[i]).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					if (Enumerable.Sum<d5o>(c5x.h.b.aa().Bag.z2().a("xpbl.temporalMedallion", 1), new Func<d5o, int>(c4v.a.a.a)) < 1)
					{
						A_1.r()["npc_xpbl_ethan_withoutMedallion"] = true;
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}
	}

	// Token: 0x02000A31 RID: 2609
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003DFC RID: 15868 RVA: 0x0017554C File Offset: 0x0017374C
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x04001BAB RID: 7083
		public static readonly c4v.a a = new c4v.a();

		// Token: 0x04001BAC RID: 7084
		public static Func<d5o, int> b;
	}
}
