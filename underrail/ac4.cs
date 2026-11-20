using System;
using System.IO;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02000A08 RID: 2568
[eiz("XPBLE3ALT")]
[Serializable]
public sealed class ac4 : bdw, ISerializable
{
	// Token: 0x06003D36 RID: 15670 RVA: 0x0016C50C File Offset: 0x0016A70C
	private ac4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x0016C514 File Offset: 0x0016A714
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x0016C518 File Offset: 0x0016A718
	public ac4()
	{
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x0016C524 File Offset: 0x0016A724
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_e5");
			if (serviceOrThrow != null)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_lemurianTurretsActive", new int?(0)).Value;
				if (aud != null)
				{
					axh axh = new EntityAspectReference<axh, axh>(aud, new Guid("1d0f3980-8f26-4928-82f6-bd1ccb666b34")).ao();
					if (axh != null)
					{
						axh.a(null, true, null);
					}
					doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_e5_L6_turrets") + ".uzl");
					aud.Zone.a(a_, 1, null);
				}
				c5x c5x = new ar7(new Guid("2189261b-8868-4b56-9ee9-2213a5f0df58"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("19857327-fe31-45c4-a50d-2378a4a40137"), aud).ao() as c5x;
				bu6 serviceOrThrow2 = bpo.GetServiceOrThrow<bu6>();
				if (c5x != null && serviceOrThrow2 != null && serviceOrThrow2.aq2() < GameDifficulty.Hard)
				{
					c5x.w();
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				c5x c5x3 = new ar7(new Guid("49ab1f71-bd37-4dbc-b169-7aae2fd2ab21"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("f99444a9-0ce8-4fbb-8f7a-ebdd19473e11"), aud).ao() as c5x;
				if (c5x3 != null && value < 2)
				{
					c5x3.h.b.aa().a(null, null, false);
				}
				if (c5x4 != null && value < 1)
				{
					c5x4.h.b.aa().a(null, null, false);
				}
			}
		}
	}
}
