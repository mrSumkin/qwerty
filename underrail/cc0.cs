using System;
using System.Runtime.Serialization;

// Token: 0x02000947 RID: 2375
[eiz("XPBLLERAJGTP")]
[Serializable]
public sealed class cc0 : bdw, ISerializable
{
	// Token: 0x06003A13 RID: 14867 RVA: 0x001578F8 File Offset: 0x00155AF8
	private cc0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x00157900 File Offset: 0x00155B00
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x00157904 File Offset: 0x00155B04
	public cc0()
	{
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x0015790C File Offset: 0x00155B0C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("xpbl_d5");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("32ff7b37-5c25-4535-84d7-61c039d678d3"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("c85f3616-9b08-43a0-b713-27465787a681"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("6ea1836f-665e-4a42-a73c-ff045cc7c976"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("12dad7f7-98c7-47e6-a033-66a7453c8d58"), aud).ao() as c5x;
			int value = A_1.r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_jetSkiStrength", new int?(0)).Value;
			if (value < 4 && c5x2 != null)
			{
				c5x2.an();
				c5x2.w();
			}
			if (value < 3 && c5x != null)
			{
				c5x.an();
				c5x.w();
			}
			else if (c5x4 != null)
			{
				c5x4.an();
				c5x4.w();
			}
			if (value < 2 && c5x3 != null)
			{
				c5x3.an();
				c5x3.w();
			}
		}
	}
}
