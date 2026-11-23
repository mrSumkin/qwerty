using System;
using System.Runtime.Serialization;

// Token: 0x02000A38 RID: 2616
[eiz("RNDEXPBLDADR")]
[Serializable]
public sealed class ewb : bdw, ISerializable
{
	// Token: 0x06003E13 RID: 15891 RVA: 0x00175E04 File Offset: 0x00174004
	private ewb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E14 RID: 15892 RVA: 0x00175E0C File Offset: 0x0017400C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E15 RID: 15893 RVA: 0x00175E10 File Offset: 0x00174010
	public ewb()
	{
	}

	// Token: 0x06003E16 RID: 15894 RVA: 0x00175E18 File Offset: 0x00174018
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(2)).Value == 5 || A_1.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(2)).Value == 6)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() != null)
			{
				bool flag = false;
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in service.ahl())
					{
						h h;
						if (d4n.b != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.fk && d4n.b.aa().PersonalAttitudes.TryGetValue(asp.a, out h) && h == h.a)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					bv9 bv = serviceOrThrow.aqu().ac() as bv9;
					if (bv != null)
					{
						if (A_1.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(2)).Value == 5)
						{
							bv.a(asp.fr, asp.a, h.a, null, true, false, false);
							bv.a(asp.fv, asp.a, h.a, null, true, false, false);
							bv.a(asp.fs, asp.a, h.a, null, true, false, false);
							bv.a(asp.ft, asp.a, h.a, null, true, false, false);
							bv.a(asp.fu, asp.a, h.a, null, true, false, false);
							return;
						}
						bv.a(asp.bf, asp.a, h.a, null, true, false, false);
					}
				}
			}
		}
	}
}
