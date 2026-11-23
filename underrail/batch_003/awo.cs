using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000904 RID: 2308
[eiz("CCCDGS")]
[Serializable]
public sealed class awo : bdw, ISerializable
{
	// Token: 0x060038FF RID: 14591 RVA: 0x00151C3C File Offset: 0x0014FE3C
	private awo(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x00151C44 File Offset: 0x0014FE44
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x00151C48 File Offset: 0x0014FE48
	public awo()
	{
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x00151C50 File Offset: 0x0014FE50
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc14");
			if (aud != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc14_duffsGangKilled", new int?(0)).Value == 4)
			{
				TypedObjectReference<b0b> typedObjectReference = new ar7(new Guid("cfc4e5d4-b219-444c-a895-3d3e7e27b208"), aud);
				ar7 ar = new ar7(new Guid("e6cf77ed-e090-44ab-96c8-11ce765e43e9"), aud);
				c5x c5x = typedObjectReference.ao() as c5x;
				c5x c5x2 = ar.ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "zoner1_original", false);
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						aspect.y6()[ddq.ay] = new bt4("zoner1_original");
					}
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "zoner2_original", false);
					bm6 aspect2 = c5x2.GetAspect<bm6>();
					if (aspect2 != null)
					{
						aspect2.y6()[ddq.ay] = new bt4("zoner2_original");
					}
				}
			}
		}
	}
}
