using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000999 RID: 2457
[eiz("LUXMD")]
[Serializable]
public sealed class cwg : bdw, ISerializable
{
	// Token: 0x06003B60 RID: 15200 RVA: 0x0015FAF0 File Offset: 0x0015DCF0
	private cwg(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x0015FAF8 File Offset: 0x0015DCF8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x0015FAFC File Offset: 0x0015DCFC
	public cwg()
	{
	}

	// Token: 0x06003B63 RID: 15203 RVA: 0x0015FB08 File Offset: 0x0015DD08
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && !A_1.r().GetPrimitivePropertyValue<bool>("loc_lux-md_frozenMutants", new bool?(false)).Value && A_0 != null)
		{
			A_1.r()["loc_lux-md_frozenMutants"] = true;
			aud aud = A_0.n("lux-md");
			if (aud != null)
			{
				foreach (string g in new string[]
				{
					"2f548ae9-b0d5-48ce-9117-67aa472d5133",
					"2cfc0a92-6cc3-4d58-a111-73db90689764",
					"bbaf7969-5128-4cc1-8287-6cc565db0e54",
					"cdc5ef7c-0ccd-420b-a18e-1fb06a2e239b",
					"f36502fa-2df6-482a-a93a-d9edc8d4cef6",
					"64baf23a-1700-4c62-ac69-fac84e9f8674"
				})
				{
					EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(aud, new Guid(g));
					if (entityAspectReference.ao() != null)
					{
						entityAspectReference.ao().u();
						entityAspectReference.ao().aa().StatusEffects.a(new a2(0, new double?(co4.b)), false, false, false);
						awq.e(entityAspectReference.ao());
						awq.b(entityAspectReference.ao());
					}
				}
			}
		}
	}
}
