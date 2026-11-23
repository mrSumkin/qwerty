using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x020010D5 RID: 4309
[eiz("REJ0")]
[Serializable]
public sealed class ccv : cze, ISerializable
{
	// Token: 0x06005ACE RID: 23246 RVA: 0x00271EF8 File Offset: 0x002700F8
	private ccv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x00271F04 File Offset: 0x00270104
	public ccv()
	{
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x00271F10 File Offset: 0x00270110
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.t.b != null)
		{
			e4w.b(c5x.t.b.y6());
			string classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<string>(ddq.bp);
			Dictionary<string, h> classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<Dictionary<string, h>>(ddq.bq);
			if (!string.IsNullOrEmpty(classPropertyValue) && classPropertyValue2 != null)
			{
				c5x.h.b.aa().FactionId = classPropertyValue;
				c5x.h.b.aa().PersonalAttitudes.Clear();
				foreach (KeyValuePair<string, h> keyValuePair in classPropertyValue2)
				{
					c5x.h.b.aa().PersonalAttitudes[keyValuePair.Key] = keyValuePair.Value;
				}
				c5x.t.b.y6().RemoveProperty(ddq.bp);
				c5x.t.b.y6().RemoveProperty(ddq.bq);
			}
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					foreach (d4n d4n in service.ahl())
					{
						if (d4n.b != c5x.h.b && d4n.b.a8().t.b != null && !d4n.b.a8().IsPlayer)
						{
							PropertyCollection propertyCollection = d4n.b.a8().t.b.y6();
							EntityAspectReference<amc, amc> classPropertyValue3 = propertyCollection.GetClassPropertyValue<EntityAspectReference<amc, amc>>(cy1.b);
							if (classPropertyValue3 != null && classPropertyValue3.ao() == c5x.h.b && d4n.b.aa().a(serviceOrThrow.aqu().ac(), c5x.h.b.aa().FactionId) != h.a)
							{
								e4w.b(propertyCollection);
							}
						}
					}
				}
			}
		}
	}
}
