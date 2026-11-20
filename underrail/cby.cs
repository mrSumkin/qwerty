using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A0F RID: 2575
[eiz("XPBLPIRITP")]
[Serializable]
public sealed class cby : bdw, ISerializable
{
	// Token: 0x06003D53 RID: 15699 RVA: 0x0016D4E0 File Offset: 0x0016B6E0
	private cby(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D54 RID: 15700 RVA: 0x0016D4E8 File Offset: 0x0016B6E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D55 RID: 15701 RVA: 0x0016D4EC File Offset: 0x0016B6EC
	public cby()
	{
	}

	// Token: 0x06003D56 RID: 15702 RVA: 0x0016D4F8 File Offset: 0x0016B6F8
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_e3_down");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("ceb3118b-2c1c-4cd4-890b-88b341a12124"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("eb05b186-af5c-4a8c-af21-e096db36046f"), aud).ao() as c5x;
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
				if (c5x4 != null)
				{
					float? ae = c5x4.ae;
					float num = (float)1;
					if (!(ae.GetValueOrDefault() == num & ae != null))
					{
						c5x4.ae = new float?((float)1);
					}
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "flinger_professor", true);
					if (c5x2.t.b != null)
					{
						List<string> classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
						if (classPropertyValue != null)
						{
							c5x2.t.b.y6()["UnusedPatrolRoute"] = classPropertyValue;
							c5x2.t.b.y6()[ddq.ay] = new bt4("flinger_professor");
							c5x2.t.b.y6().RemoveProperty(ddq.k);
						}
					}
				}
				axh aspect = new ar7(new Guid("c6c0e4c7-fad3-4235-b079-ba9718e6dbb6"), aud).ao().GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, true, null);
				}
				if (c5x != null)
				{
					List<ble> list = new List<ble>();
					list.AddRange(a37.a(aud));
					serviceOrThrow2.amu("characters\\xpbl\\le_oldfield", serviceOrThrow.aqu().v().b(), c5x, list, false, true, true, null, false, false);
				}
			}
		}
	}
}
