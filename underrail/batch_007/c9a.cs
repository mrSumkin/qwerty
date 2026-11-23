using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B7E RID: 2942
[eiz("CCJEAD")]
[Serializable]
public sealed class c9a : cze, ISerializable
{
	// Token: 0x06004331 RID: 17201 RVA: 0x001A4604 File Offset: 0x001A2804
	private c9a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x001A4610 File Offset: 0x001A2810
	public c9a()
	{
	}

	// Token: 0x06004333 RID: 17203 RVA: 0x001A461C File Offset: 0x001A281C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1.qe() == new Guid("a0735df6-b749-42fc-9fe6-fa1c592c3b6f"))
		{
			c5x c5x = A_1 as c5x;
			object obj;
			if (A_2 != null && A_2.TryGetValue("tempcontext", out obj))
			{
				bq8 bq = obj as bq8;
				if (bq != null)
				{
					string classPropertyValue = bq.GetClassPropertyValue<string>("FoodPath");
					if (classPropertyValue != null)
					{
						if (c5x.h.b != null)
						{
							if (c5x.h.b.aa().StatusEffects.a(c9i.a))
							{
								c5x.h.b.aa().StatusEffects.d(Enumerable.FirstOrDefault<c9i>(c5x.h.b.aa().StatusEffects.Get<c9i>()));
							}
							c5x.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\" + classPropertyValue)), true);
						}
						if (c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.b2] = true;
							c5x.t.b.y6()[ddq.b4] = 200;
						}
					}
				}
			}
		}
	}
}
