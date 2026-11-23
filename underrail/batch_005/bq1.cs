using System;
using System.Collections.Generic;
using Ouroboros.Playfield.References;

// Token: 0x02000357 RID: 855
public sealed class bq1 : abg
{
	// Token: 0x06001827 RID: 6183 RVA: 0x0007A3B4 File Offset: 0x000785B4
	public override abg f7()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bzv bzv = new bzv(base.b().c().y6());
		bzv.g();
		bool value = base.b().d().GetPrimitivePropertyValue<bool>("forceFieldKillingMode", new bool?(false)).Value;
		bzv.h();
		Guid? primitivePropertyValue = base.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
		bool flag = base.b().g().aa().b(d8o.b | d8o.c | d8o.d);
		if (primitivePropertyValue != null)
		{
			EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(base.b().c().a8().Area, primitivePropertyValue.Value);
			if (entityAspectReference.ao() != null)
			{
				base.b().c().y6()[cy1.b] = entityAspectReference;
				return this.b;
			}
		}
		else
		{
			Guid? primitivePropertyValue2 = base.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.a4, null);
			List<Guid> classPropertyValue = base.b().c().y6().GetClassPropertyValue<List<Guid>>(ddq.a5);
			int num = bzv.f();
			Dictionary<Guid, blk> dictionary = bzv.a();
			amc amc = null;
			double num2 = double.MaxValue;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			if (num > 0)
			{
				foreach (blk blk in dictionary.Values)
				{
					if (blk != null && blk.e() != null && blk.e().a8() != null && blk.a().f() == cem.d && !blk.e().aa().Dead && !blk.e().aa().Passive && (base.b().c().a8().h.b.aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == h.a || base.b().g().aa().FactionId == asp.e) && (base.b().g().a8().k.b != null || base.b().vz() || blk.b()))
					{
						if (primitivePropertyValue2 != null && primitivePropertyValue2.Value == blk.e().a8().qe())
						{
							amc = blk.e();
							break;
						}
						if (blk.e().a8().t.b == null || !blk.e().a8().t.b.y6().GetPrimitivePropertyValue<bool>(ddq.a6, new bool?(false)).Value)
						{
							double num3 = aw1.b(blk.e().a8(), base.b().g().a8());
							bool flag5 = classPropertyValue != null && classPropertyValue.Contains(blk.e().a8().qe());
							if (!flag5)
							{
								if (blk.e().aa().Vehicle != null && base.b().g().aa().Vehicle == null)
								{
									flag5 = true;
								}
								if (!value && blk.e().aa().FactionId == asp.c)
								{
									flag5 = true;
								}
							}
							bool k = blk.e().aa().SpecialStates.k;
							bool flag6 = false;
							if (amc == null)
							{
								flag6 = true;
							}
							else if (flag && !k && flag4)
							{
								flag6 = true;
							}
							else if (!flag || flag4 || !k)
							{
								if (flag5)
								{
									if (flag3 && (num2 > num3 || (!flag2 && blk.b())))
									{
										flag6 = true;
									}
								}
								else if (flag3)
								{
									flag6 = true;
								}
								else if (num2 > num3 || (!flag2 && blk.b()))
								{
									flag6 = true;
								}
							}
							if (flag6)
							{
								amc = blk.e();
								num2 = num3;
								flag2 = blk.b();
								flag3 = flag5;
								flag4 = k;
							}
						}
					}
				}
				if (amc != null)
				{
					base.b().c().y6()[cy1.b] = new EntityAspectReference<amc, amc>(amc);
					return this.b;
				}
			}
		}
		return this.a;
	}

	// Token: 0x04000E26 RID: 3622
	public abg a;

	// Token: 0x04000E27 RID: 3623
	public abg b;
}
