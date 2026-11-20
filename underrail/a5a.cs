using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A0E RID: 2574
[eiz("XPBLPIRSITP")]
[Serializable]
public sealed class a5a : bdw, ISerializable
{
	// Token: 0x06003D4F RID: 15695 RVA: 0x0016D2B0 File Offset: 0x0016B4B0
	private a5a(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D50 RID: 15696 RVA: 0x0016D2B8 File Offset: 0x0016B4B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D51 RID: 15697 RVA: 0x0016D2BC File Offset: 0x0016B4BC
	public a5a()
	{
	}

	// Token: 0x06003D52 RID: 15698 RVA: 0x0016D2C8 File Offset: 0x0016B4C8
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		bpo.GetServiceOrThrow<ps>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_e3_down");
			if (aud != null)
			{
				axh aspect = new ar7(new Guid("c6c0e4c7-fad3-4235-b079-ba9718e6dbb6"), aud).ao().GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, false, null);
				}
				c5x c5x = new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), aud).ao() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					List<string> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<string>>("UnusedPatrolRoute");
					if (classPropertyValue != null)
					{
						c5x.t.b.y6()[ddq.k] = classPropertyValue;
						c5x.t.b.y6().RemoveProperty(ddq.ay);
						c5x.t.b.y6().RemoveProperty("UnusedPatrolRoute");
					}
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2 != null && c5x2.o.b != null && c5x2.o.b.a == "Effects\\BloodPool")
						{
							c5x2.w();
							c5x2.an();
						}
						else if (c5x2 != null && c5x2.GetAspect<a3f>() != null && c5x2.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
						{
							c5x2.an();
							c5x2.w();
						}
					}
				}
			}
		}
	}
}
