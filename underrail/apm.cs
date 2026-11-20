using System;
using System.Runtime.Serialization;

// Token: 0x02000A20 RID: 2592
[eiz("XPBLLUXP")]
[Serializable]
public sealed class apm : bdw, ISerializable
{
	// Token: 0x06003DA4 RID: 15780 RVA: 0x00171BA0 File Offset: 0x0016FDA0
	private apm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x00171BA8 File Offset: 0x0016FDA8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x00171BAC File Offset: 0x0016FDAC
	public apm()
	{
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x00171BB8 File Offset: 0x0016FDB8
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_lux_dh");
			if (aud != null)
			{
				new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), aud).ao();
				c5x c5x = new ar7(new Guid("27ee78f4-69dc-4380-8dee-6e6623ed4ce1"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("7a6e2b12-49c2-44e2-9bfe-41176b9aae00"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("d6ea184b-6be0-479c-bd6d-ca0506d8eaa5"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("9dc90870-1921-4a80-bb27-4e54cf642f7e"), aud).ao() as c5x;
				if (c5x3 != null)
				{
					c5x3.an();
					c5x3.w();
				}
				if (c5x4 != null)
				{
					c5x4.ae = new float?((float)1);
					a2r a2r = c5x4.GetAspect<a2r>();
					if (a2r == null)
					{
						a2r = new a2r(c5x4);
						c5x4.SetAspect<a2r>(a2r);
					}
					a2r.a(3f);
				}
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(null, true, null);
					}
				}
				if (c5x != null)
				{
					axh aspect2 = c5x2.GetAspect<axh>();
					if (aspect2 != null)
					{
						aspect2.a(null, true, null);
					}
				}
			}
		}
	}
}
