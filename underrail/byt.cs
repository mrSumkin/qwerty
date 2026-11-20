using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A44 RID: 2628
[eiz("CCCACSFG")]
[Serializable]
public sealed class byt : cze, ISerializable
{
	// Token: 0x06003E41 RID: 15937 RVA: 0x00177BBC File Offset: 0x00175DBC
	private byt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CCCACSFG:JC");
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x00177BD8 File Offset: 0x00175DD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCCACSFG:JC", this.a);
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x00177BF4 File Offset: 0x00175DF4
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x00177BFC File Offset: 0x00175DFC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x00177C08 File Offset: 0x00175E08
	public byt()
	{
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x00177C14 File Offset: 0x00175E14
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x != null)
		{
			c5x c5x2 = new ar7(new Guid("c3db113a-e36b-4c13-97e2-3c1346bcd703"), c5x.Area).ao() as c5x;
			if (c5x2 != null)
			{
				c7j c7j = c5x2.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					int num = 0;
					int num2 = 0;
					List<cgd> list = new List<cgd>();
					foreach (coh coh in Enumerable.ToList<coh>(c7j.ItemContainer.z2()))
					{
						if (num2 >= 10)
						{
							break;
						}
						if (coh is cgd)
						{
							double? num3 = coh.Definition.bf();
							double num4 = (double)6000;
							if (num3.GetValueOrDefault() >= num4 & num3 != null)
							{
								if (!this.a)
								{
									list.Add(coh as cgd);
									c7j.ItemContainer.z2().Remove(coh);
								}
								num2++;
							}
							num++;
						}
					}
					object obj;
					if (num < 10 && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
					{
						bq8 bq = obj as bq8;
						if (bq != null)
						{
							if (num <= 0)
							{
								bq.set_Item("LockerHasNoShields", true);
								return;
							}
							bq.set_Item("NotEnoughShields", true);
							return;
						}
					}
					if (num2 >= 10)
					{
						if (this.a)
						{
							object obj2;
							if (A_2 != null && A_2.TryGetValue("tempcontext", out obj2))
							{
								bq8 bq2 = obj2 as bq8;
								if (bq2 != null)
								{
									bq2.set_Item("EnergyShieldsAreValid", true);
									return;
								}
							}
						}
						else
						{
							serviceOrThrow.aqu().r()["quest_cc_robProtWarehouse_shieldItemList"] = list;
						}
					}
				}
			}
		}
	}

	// Token: 0x04001BB3 RID: 7091
	private new bool a;
}
