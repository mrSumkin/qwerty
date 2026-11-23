using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020009F6 RID: 2550
[eiz("XPBLCSS")]
[Serializable]
public sealed class cet : bdw, ISerializable
{
	// Token: 0x06003CE5 RID: 15589 RVA: 0x00169A18 File Offset: 0x00167C18
	private cet(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CE6 RID: 15590 RVA: 0x00169A20 File Offset: 0x00167C20
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CE7 RID: 15591 RVA: 0x00169A24 File Offset: 0x00167C24
	public cet()
	{
	}

	// Token: 0x06003CE8 RID: 15592 RVA: 0x00169A30 File Offset: 0x00167C30
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			c5x c5x = A_0.a().ab5("crabSpiriter") as c5x;
			if (c5x != null && c5x.h.b != null && c5x.t.b != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("xpbl_g11_initialSetupCompleted", new bool?(false)).Value;
					bool flag = (int)serviceOrThrow.aqu().o().TotalMinutes % 60 < 30 && A_0.a().ab4(new string[]
					{
						"youngMaiden"
					}).Count > 0;
					PropertyCollection propertyCollection = c5x.t.b.y6();
					if (flag)
					{
						if (!c5x.h.b.aa().SpecialAbilities.a(typeof(e5b)))
						{
							c5x.h.b.aa().SpecialAbilities.b(dgk.Get<e5b>());
						}
						propertyCollection.RemoveProperty(ddq.k);
						propertyCollection.RemoveProperty(ddq.l);
						propertyCollection.RemoveProperty(ddq.o);
						propertyCollection.RemoveProperty(ddq.s);
						propertyCollection.RemoveProperty(ddq.n);
						propertyCollection[ddq.ay] = new bt4("kvs");
					}
					else
					{
						if (c5x.h.b.aa().SpecialAbilities.a(typeof(e5b)))
						{
							c5x.h.b.aa().SpecialAbilities.a(dgk.Get<e5b>());
						}
						propertyCollection[ddq.k] = new List<string>
						{
							"kvw1",
							"kvw2",
							"kvw3"
						};
						propertyCollection[ddq.l] = 10500;
						propertyCollection[ddq.o] = CharacterState.Operating;
						propertyCollection[ddq.s] = 100;
						propertyCollection[ddq.n] = true;
						propertyCollection.RemoveProperty(ddq.ay);
					}
					if (!value)
					{
						serviceOrThrow.aqu().r()["xpbl_g11_initialSetupCompleted"] = true;
						if (flag)
						{
							a0l.a(c5x, "kvs", true);
							return;
						}
						a0l.a(c5x, "kvw1", true);
					}
				}
			}
		}
	}
}
