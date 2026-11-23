using System;
using System.Runtime.Serialization;

// Token: 0x02000A3A RID: 2618
[eiz("XPBLYL")]
[Serializable]
public sealed class asl : bdw, ISerializable
{
	// Token: 0x06003E1B RID: 15899 RVA: 0x0017626C File Offset: 0x0017446C
	private asl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E1C RID: 15900 RVA: 0x00176274 File Offset: 0x00174474
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E1D RID: 15901 RVA: 0x00176278 File Offset: 0x00174478
	public asl()
	{
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x00176284 File Offset: 0x00174484
	public void av(c1a A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("edac0ba9-96cc-419d-9816-f8746937d85b"), A_0.n("xpbl_a10U")).ao() as c5x;
		if (c5x != null)
		{
			c5x.w();
			c5x.an();
			A_1.r()["npc_xpbl_yngwar_wentToMonolith"] = true;
			A_1.a(new bw0("xpbl_c3", new eix(), 1));
			c5x c5x2 = new ar7(new Guid("61842ef9-5bbc-4513-a77e-a9ef5bac3840"), A_0.n("xpbl_a10U")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("775be48e-718a-4c35-aaae-95726d90b4f0"), A_0.n("xpbl_a10U")).ao() as c5x;
			if (c5x2 != null && c5x2.s.b is c7j)
			{
				c7j c7j = c5x2.GetAspect<bim>() as c7j;
				if (c7j != null && c7j.ItemContainer.z2().Count != 0)
				{
					c7j.ItemContainer.z2().Clear();
				}
			}
			if (c5x3 != null && c5x3.s.b is c7j)
			{
				c7j c7j2 = c5x3.GetAspect<bim>() as c7j;
				if (c7j2 != null && c7j2.ItemContainer.z2().Count != 0)
				{
					c7j2.ItemContainer.z2().Clear();
				}
			}
			c5x c5x4 = new ar7(new Guid("bd5ac823-273f-48a4-ade0-946e7d986f8e"), A_0.n("xpbl_a10U")).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("30e0d809-712f-44cd-90b5-538cedffd33b"), A_0.n("xpbl_a10U")).ao() as c5x;
			if (c5x4 != null && c5x4.o.b != null)
			{
				c5x4.o.b.b.X = 1;
			}
			if (c5x5 != null)
			{
				c5x5.w();
				c5x5.an();
			}
		}
	}
}
