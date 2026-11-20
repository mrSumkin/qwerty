using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Generators.Items;

// Token: 0x02001316 RID: 4886
[a(typeof(ery))]
[eiz("GICEA")]
[cnn("TimelapseVertigo.Playfield.Design.Forms.GeneratedItemContainerEntityAspectEditorForm, TimelapseVertigo.Playfield.Design")]
[Serializable]
public sealed class ery : Aspect<c5x>, bp1, dqh, ISerializable
{
	// Token: 0x06006D99 RID: 28057 RVA: 0x002DC954 File Offset: 0x002DAB54
	private ery(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (c9y)A_0.GetValue("GICEA:OS", typeof(c9y));
			this.b = A_0.GetBoolean("GICEA:G");
		}
		else
		{
			this.a = (A_0.GetValue("_OpportunitySet", typeof(c9y)) as c9y);
			this.b = A_0.GetBoolean("_Generated");
		}
		if (ell.a() >= 146)
		{
			this.c = (A_0.GetValue("GICEA:D", typeof(double?)) as double?);
		}
		if (ell.a() >= 507)
		{
			this.d = A_0.GetInt32("GICEA:S");
			return;
		}
		this.d = cuo.a.Next();
		this.e = new bool?(true);
	}

	// Token: 0x06006D9A RID: 28058 RVA: 0x002DCA68 File Offset: 0x002DAC68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GICEA:OS", this.a);
		info.AddValue("GICEA:G", this.b);
		info.AddValue("GICEA:D", this.c);
		info.AddValue("GICEA:S", this.d);
	}

	// Token: 0x06006D9B RID: 28059 RVA: 0x002DCAC8 File Offset: 0x002DACC8
	public c9y f()
	{
		return this.a;
	}

	// Token: 0x06006D9C RID: 28060 RVA: 0x002DCAD0 File Offset: 0x002DACD0
	public void a(c9y A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006D9D RID: 28061 RVA: 0x002DCADC File Offset: 0x002DACDC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06006D9E RID: 28062 RVA: 0x002DCAE4 File Offset: 0x002DACE4
	public double? d()
	{
		return this.c;
	}

	// Token: 0x06006D9F RID: 28063 RVA: 0x002DCAEC File Offset: 0x002DACEC
	public void a(double? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006DA0 RID: 28064 RVA: 0x002DCAF8 File Offset: 0x002DACF8
	public int b()
	{
		return this.d;
	}

	// Token: 0x06006DA1 RID: 28065 RVA: 0x002DCB00 File Offset: 0x002DAD00
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006DA2 RID: 28066 RVA: 0x002DCB0C File Offset: 0x002DAD0C
	public ery(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006DA3 RID: 28067 RVA: 0x002DCB34 File Offset: 0x002DAD34
	public void mx()
	{
		if (this.e.GetValueOrDefault())
		{
			this.e = null;
			if (base.a8() != null && base.a8().Area != null)
			{
				this.d = base.a8().qe().GetHashCode() / 2 + base.a8().Area.qe().GetHashCode() / 2;
			}
		}
		int num = 0;
		if (this.a != null)
		{
			amc aspect = base.a8().GetAspect<amc>();
			if (aspect != null)
			{
				bool flag = aspect.am() == bln.ar || aspect.am() == bln.@as || aspect.am() == bln.at || aspect.am() == bln.au || aspect.am() == bln.av || aspect.am() == bln.aw;
				b0h b0h = null;
				foreach (xs xs in this.a.g())
				{
					b0h = (xs.Generator as b0h);
					if (b0h != null && !b0h.a() && !b0h.b())
					{
						b0h.a(!flag);
						b0h.b(flag);
						break;
					}
				}
				if (b0h == null && flag)
				{
					b0h = new b0h();
					b0h.na(5);
					b0h.nc(10);
					b0h.b(true);
					xs xs2 = new xs();
					xs2.Generator = b0h;
					xs2.AutoEquipMode = AutoEquipMode.Primary;
					this.a.g().Add(xs2);
				}
			}
			if (!this.b)
			{
				cnk service = bpo.GetService<cnk>();
				if (service == null || service.aqu() == null)
				{
					return;
				}
				amc aspect2 = base.a8().GetAspect<amc>();
				c7j c7j = base.a8().GetAspect<bim>() as c7j;
				czz czz = base.a8().GetAspect<bim>() as czz;
				zp.a = new Random(this.d * service.aqu().l());
				dbi dbi = null;
				if (aspect2 != null && aspect2.aa() != null)
				{
					dbi = aspect2.aa().Bag;
				}
				else if (c7j != null)
				{
					dbi = c7j.ItemContainer;
				}
				else if (czz != null)
				{
					dbi = czz.air();
				}
				if (dbi != null)
				{
					List<bmd> list = this.a.c();
					if (list != null)
					{
						foreach (bmd bmd in list)
						{
							if (bmd.Item != null && bmd.Item.Definition != null && !bmd.Item.Definition.a9())
							{
								double num2 = 1.0;
								if (this.c != null)
								{
									num2 = d05.b(0.0, this.c.Value, 1.0);
								}
								else if (aspect2 == null && (bmd.Item.Definition.a8() == 0 || bmd.Item.Definition.a8() > 3))
								{
									num2 = dwh.j.a();
								}
								bmd.Item.Durability = (double)((int)((double)bmd.Item.MaxDurability * num2));
							}
							if (bmd.AutoEquipMode != AutoEquipMode.None && aspect2 != null && aspect2.aa() != null && bn.a(aspect2.aa(), bmd.Item, bmd.AutoEquipMode, ref num))
							{
								euf.a(bmd.Item, aspect2.aa());
							}
							else
							{
								dbi.z3(bmd.Item, true);
							}
						}
					}
					this.b = true;
				}
			}
		}
	}

	// Token: 0x06006DA4 RID: 28068 RVA: 0x002DCFC0 File Offset: 0x002DB1C0
	public void my()
	{
	}

	// Token: 0x06006DA5 RID: 28069 RVA: 0x002DCFC4 File Offset: 0x002DB1C4
	public void e()
	{
		this.d = cuo.a.Next();
	}

	// Token: 0x06006DA6 RID: 28070 RVA: 0x002DCFD8 File Offset: 0x002DB1D8
	public void aip()
	{
		this.e();
	}

	// Token: 0x04002CD6 RID: 11478
	private c9y a = new c9y();

	// Token: 0x04002CD7 RID: 11479
	private bool b;

	// Token: 0x04002CD8 RID: 11480
	private double? c;

	// Token: 0x04002CD9 RID: 11481
	private int d = cuo.a.Next();

	// Token: 0x04002CDA RID: 11482
	[NonSerialized]
	private bool? e;
}
