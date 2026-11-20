using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B52 RID: 2898
[eiz("GECATSAK")]
[Serializable]
public sealed class nc : cze, ISerializable
{
	// Token: 0x0600427F RID: 17023 RVA: 0x0019C98C File Offset: 0x0019AB8C
	private nc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x0019C998 File Offset: 0x0019AB98
	public nc()
	{
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x0019C9A0 File Offset: 0x0019ABA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("randomEvents_ge_cats_SetAI", new bool?(false)).Value)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("randomEvent_ge_cats_team1Killed", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("randomEvent_ge_cats_team2Killed", new int?(0)).Value;
			if (value >= 5 || value2 >= 5)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && (d4n.b.aa().FactionId == asp.fe || d4n.b.aa().FactionId == asp.ff))
					{
						bm6 b = d4n.b.a8().t.b;
						if (b != null)
						{
							b.b("cat");
						}
					}
				}
				serviceOrThrow.aqu().r()["randomEvents_ge_cats_SetAI"] = true;
			}
		}
	}
}
