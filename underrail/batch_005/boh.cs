using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A68 RID: 2664
[eiz("DCSTLSJ")]
[Serializable]
public sealed class boh : cze, ISerializable
{
	// Token: 0x06003EE7 RID: 16103 RVA: 0x0017C494 File Offset: 0x0017A694
	private boh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("DCSTLSJ:E");
	}

	// Token: 0x06003EE8 RID: 16104 RVA: 0x0017C4B0 File Offset: 0x0017A6B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCSTLSJ:E", this.a);
	}

	// Token: 0x06003EE9 RID: 16105 RVA: 0x0017C4CC File Offset: 0x0017A6CC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x0017C4D4 File Offset: 0x0017A6D4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x0017C4E0 File Offset: 0x0017A6E0
	public boh()
	{
	}

	// Token: 0x06003EEC RID: 16108 RVA: 0x0017C4E8 File Offset: 0x0017A6E8
	public boh(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EED RID: 16109 RVA: 0x0017C4FC File Offset: 0x0017A6FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(serviceOrThrow.aqw().Areas);
			if (aud != null)
			{
				EntityAspectReference<bim, bim> entityAspectReference = new EntityAspectReference<bim, bim>(aud, new Guid("9565ef9f-d50b-4aa2-a558-a630b35b229a"));
				if (entityAspectReference.ao() != null)
				{
					serviceOrThrow.aqu().r()["loc_dc_tchb_ladderElectrified"] = this.a;
					entityAspectReference.ao().s().Clear();
					d60 d = serviceOrThrow.aqw().a();
					if (d != null)
					{
						foreach (b0b b0b in d.ab4(new string[]
						{
							"ladderSpark"
						}))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.o.b != null)
							{
								if (this.a)
								{
									c5x.o.b.d = null;
								}
								else
								{
									c5x.o.b.d = new float?(0f);
								}
							}
						}
					}
					if (this.a)
					{
						entityAspectReference.ao().s().Add(new n0());
						entityAspectReference.ao().a8().c().a("electricity", "OpenElectricity", 1f, c9z.b, true, false);
						return;
					}
					entityAspectReference.ao().s().Add(new e68
					{
						Destination = new c2w("dc-de3", "FromTchort")
					});
					entityAspectReference.ao().a8().c().a("electricity", false);
				}
			}
		}
	}

	// Token: 0x04001BCD RID: 7117
	private new bool a;
}
