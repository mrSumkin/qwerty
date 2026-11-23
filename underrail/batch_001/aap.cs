using System;
using System.Runtime.Serialization;

// Token: 0x02000A11 RID: 2577
[eiz("XPBLI5UCTG")]
[Serializable]
public sealed class aap : bdw, ISerializable
{
	// Token: 0x06003D5B RID: 15707 RVA: 0x0016D7A8 File Offset: 0x0016B9A8
	private aap(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D5C RID: 15708 RVA: 0x0016D7B0 File Offset: 0x0016B9B0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D5D RID: 15709 RVA: 0x0016D7B4 File Offset: 0x0016B9B4
	public aap()
	{
	}

	// Token: 0x06003D5E RID: 15710 RVA: 0x0016D7C0 File Offset: 0x0016B9C0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bool serviceOrThrow = bpo.GetServiceOrThrow<cnk>() != null;
			aud a_ = A_0.n("xpbl_i5u");
			if (serviceOrThrow)
			{
				c5x c5x = new ar7(new Guid("ef264853-cbd9-4c50-a74d-2295b5d8bc89"), a_).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("dc116ffd-f539-4d37-aaf3-8cf74a256887"), a_).ao() as c5x;
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.s3(2);
					c5x.z();
					if (aspect != null)
					{
						aspect.b.X = 0;
						aspect.b.Y = 0;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers.s3(2);
					c5x2.z();
					if (aspect2 != null)
					{
						aspect2.b.X = 0;
						aspect2.b.Y = 0;
					}
				}
			}
		}
	}
}
