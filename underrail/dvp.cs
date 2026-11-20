using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Core.Logging;

// Token: 0x0200130D RID: 4877
[eiz("MEA1")]
[Serializable]
public sealed class dvp : Aspect<c5x>, eg, ISerializable
{
	// Token: 0x06006D45 RID: 27973 RVA: 0x002DAAB4 File Offset: 0x002D8CB4
	private dvp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (dcw)A_0.GetValue("MEA1:IC", typeof(dcw));
			this.b = A_0.GetString("MEA1:S");
			di7.ReadList<string>("MEA1:RS", ref this.c, A_0);
			if (ell.a() >= 143)
			{
				this.h = (TimeSpan)A_0.GetValue("MEA1:R", typeof(TimeSpan));
			}
			if (ell.a() >= 190)
			{
				di7.ReadDictionary<a0, int>("MEA1:D", ref this.d, A_0);
			}
			else
			{
				this.d = new Dictionary<a0, int>();
			}
			if (ell.a() >= 211)
			{
				this.i = A_0.GetBoolean("MEA1:M");
			}
			if (ell.a() >= 313)
			{
				this.k = A_0.GetInt32("MEA1:US");
				this.l = A_0.GetInt32("MEA1:FS");
			}
			else
			{
				this.k = 1;
				this.l = cuo.a.Next();
			}
			if (ell.a() >= 338)
			{
				this.j = A_0.GetBoolean("MEA1:P");
				return;
			}
		}
		else
		{
			this.b = A_0.GetString("_Store");
			this.a = (A_0.GetValue("_ItemContainer", typeof(dcw)) as dcw);
			di7.ReadList<string>("_RecievedShipments", ref this.c, A_0);
		}
	}

	// Token: 0x06006D46 RID: 27974 RVA: 0x002DAC7C File Offset: 0x002D8E7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MEA1:IC", this.a);
		info.AddValue("MEA1:S", this.b);
		di7.WriteList<string>("MEA1:RS", this.c, info);
		info.AddValue("MEA1:R", this.h);
		di7.WriteDictionary<a0, int>("MEA1:D", this.d, info);
		info.AddValue("MEA1:M", this.i);
		info.AddValue("MEA1:US", this.k);
		info.AddValue("MEA1:FS", this.l);
		info.AddValue("MEA1:P", this.j);
	}

	// Token: 0x06006D47 RID: 27975 RVA: 0x002DAD30 File Offset: 0x002D8F30
	public dbi ap7()
	{
		return this.a;
	}

	// Token: 0x06006D48 RID: 27976 RVA: 0x002DAD38 File Offset: 0x002D8F38
	public string g()
	{
		return this.b;
	}

	// Token: 0x06006D49 RID: 27977 RVA: 0x002DAD40 File Offset: 0x002D8F40
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006D4A RID: 27978 RVA: 0x002DAD4C File Offset: 0x002D8F4C
	public List<string> ap8()
	{
		return this.c;
	}

	// Token: 0x06006D4B RID: 27979 RVA: 0x002DAD54 File Offset: 0x002D8F54
	public efk ap9()
	{
		if (base.a8().h != null && base.a8().h.b != null)
		{
			return base.a8().h.b.aa();
		}
		return null;
	}

	// Token: 0x06006D4C RID: 27980 RVA: 0x002DAD94 File Offset: 0x002D8F94
	public p9 e()
	{
		if (this.e == null && !this.f)
		{
			this.b();
		}
		return this.e;
	}

	// Token: 0x06006D4D RID: 27981 RVA: 0x002DADB8 File Offset: 0x002D8FB8
	public List<string> aqa()
	{
		if (this.e() != null)
		{
			return this.e().e();
		}
		return null;
	}

	// Token: 0x06006D4E RID: 27982 RVA: 0x002DADD4 File Offset: 0x002D8FD4
	public Dictionary<a0, int> aqb()
	{
		return this.d;
	}

	// Token: 0x06006D4F RID: 27983 RVA: 0x002DADDC File Offset: 0x002D8FDC
	public dvp(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D50 RID: 27984 RVA: 0x002DAE28 File Offset: 0x002D9028
	public void aqc(bool A_0 = false)
	{
		if (this.a == null)
		{
			this.a = new dcw();
		}
		if (string.IsNullOrEmpty(this.b))
		{
			dux.b(LogSeverity.Warning, "Merchant '{0}' does not have a store set.", new object[]
			{
				base.a8().ToString()
			});
			return;
		}
		bool flag = false;
		p9 p = c8j.a(this.b);
		if (p == null)
		{
			dux.b(LogSeverity.Warning, "Failed to retrieve store '{0}' for merchant '{1}'.", new object[]
			{
				this.g(),
				base.a8().ToString()
			});
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		double num = 1.0;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Feats.Contains<pg>())
		{
			num += pg.a * (double)serviceOrThrow.aqu().v().Skills.Get<e70>().g();
		}
		num *= (double)euf.b().MerchantPurchasingPower;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Feats.Contains<pg>() && !this.j)
		{
			this.j = true;
			foreach (coh coh in this.a.z2())
			{
				if (num != 1.0 && coh.Definition != null && coh.Definition.a5() != null && this.aqa() != null && this.aqa().Contains(coh.Definition.a5()))
				{
					coh.Stacks = (int)((double)coh.Stacks * num);
				}
			}
		}
		if (serviceOrThrow.aqu() != null && (p.c() != null || A_0) && (A_0 || serviceOrThrow.aqu().p() > this.h))
		{
			this.f();
			this.h = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes((double)p.c().Value);
			this.a();
			flag = true;
		}
		zp.a = new Random(this.l * this.k * serviceOrThrow.aqu().l());
		iv iv = p.a(this);
		if (iv != null)
		{
			if (iv.a)
			{
				this.f();
				this.h = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes((double)p.c().Value);
				this.a();
				flag = true;
			}
			else if (iv.b)
			{
				this.a();
			}
			if (iv.d != null && iv.d.Count > 0)
			{
				this.c.AddRange(iv.d);
				this.k++;
			}
			if (iv.c != null && iv.c.Count > 0)
			{
				flag = true;
				foreach (coh coh2 in iv.c)
				{
					if (coh2 != null)
					{
						if (num != 1.0 && coh2.Definition != null && coh2.Definition.a5() != null && this.aqa() != null && this.aqa().Contains(coh2.Definition.a5()))
						{
							coh2.Stacks = (int)((double)coh2.Stacks * num);
						}
						this.a.z3(coh2, true);
					}
				}
			}
		}
		if (flag)
		{
			this.b(p);
			return;
		}
		this.a(p);
	}

	// Token: 0x06006D51 RID: 27985 RVA: 0x002DB268 File Offset: 0x002D9468
	public void f()
	{
		foreach (string item in Enumerable.ToList<string>(this.c))
		{
			bool flag = false;
			foreach (d6w d6w in this.e().b())
			{
				if (item == d6w.d() && d6w.a())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.c.Remove(item);
			}
		}
	}

	// Token: 0x06006D52 RID: 27986 RVA: 0x002DB344 File Offset: 0x002D9544
	public float aqd(efk A_0)
	{
		if (!string.IsNullOrEmpty(this.b) && this.e() != null)
		{
			return this.e().a(this, A_0);
		}
		return bhm.a;
	}

	// Token: 0x06006D53 RID: 27987 RVA: 0x002DB374 File Offset: 0x002D9574
	public bool aqe(coh A_0)
	{
		if (this.e() != null)
		{
			if (A_0.Definition is a54 && A_0.Definition.a5() != null)
			{
				return this.a(A_0.Definition.a5());
			}
			if (this.e().a() != efi.a && this.e().f() != null)
			{
				bool flag = false;
				foreach (bp2 bp in this.e().f())
				{
					flag |= bp.cx(A_0);
				}
				if (this.e().a() == efi.b)
				{
					return !flag;
				}
				if (this.e().a() == efi.c)
				{
					return flag;
				}
			}
		}
		return true;
	}

	// Token: 0x06006D54 RID: 27988 RVA: 0x002DB460 File Offset: 0x002D9660
	public List<string> d()
	{
		List<string> list = new List<string>();
		if (this.e() != null)
		{
			list.AddRange(this.e().e());
		}
		return list;
	}

	// Token: 0x06006D55 RID: 27989 RVA: 0x002DB490 File Offset: 0x002D9690
	private void b()
	{
		this.g = null;
		this.e = c8j.a(this.b);
		if (this.e == null)
		{
			this.f = true;
		}
	}

	// Token: 0x06006D56 RID: 27990 RVA: 0x002DB4BC File Offset: 0x002D96BC
	private bool a(string A_0)
	{
		if (this.g == null)
		{
			if (this.e != null)
			{
				this.g = new HashSet<string>(this.e.e());
			}
			else
			{
				this.g = new HashSet<string>();
			}
		}
		return this.g.Contains(A_0);
	}

	// Token: 0x06006D57 RID: 27991 RVA: 0x002DB514 File Offset: 0x002D9714
	private void b(p9 A_0)
	{
		double num = 1.0;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Feats.Contains<euv>())
		{
			num += (euv.a + (double)serviceOrThrow.aqu().v().GetSpecializationValue<bco>(true) * bco.a) * (double)serviceOrThrow.aqu().v().Skills.Get<e70>().g();
			this.i = true;
		}
		num *= (double)euf.b().MerchantPurchasingPower;
		this.d.Clear();
		List<d9n> list = new List<d9n>();
		foreach (d9n d9n in A_0.h())
		{
			if (d9n.Condition == null || d9n.Condition.jh(null))
			{
				if (d9n.AlwaysInclude || d9n.UnlimitedDemand)
				{
					if (d9n.UnlimitedDemand)
					{
						this.d.Add(d9n.Category, -1);
					}
					else
					{
						this.d.Add(d9n.Category, Convert.ToInt32((double)cuo.a.Next(d9n.MinDemand, d9n.MaxDemand + 1) * num));
					}
				}
				else
				{
					list.Add(d9n);
				}
			}
		}
		int num2 = A_0.d();
		while (num2 > 0 && list.Count > 0)
		{
			List<d9n> list2 = new List<d9n>();
			int num3 = Enumerable.Max<d9n>(list, new Func<d9n, int>(dvp.a.a.a));
			foreach (d9n d9n2 in list)
			{
				int num4 = (int)Math.Ceiling((double)num3 / (double)d9n2.RarityFactor);
				for (int i = 0; i < num4; i++)
				{
					list2.Add(d9n2);
				}
			}
			if (list2.Count <= 0)
			{
				break;
			}
			d9n d9n3 = list2[cuo.a.Next(list2.Count)];
			list.Remove(d9n3);
			this.d.Add(d9n3.Category, Convert.ToInt32((double)cuo.a.Next(d9n3.MinDemand, d9n3.MaxDemand + 1) * num));
			num2--;
		}
	}

	// Token: 0x06006D58 RID: 27992 RVA: 0x002DB7D8 File Offset: 0x002D99D8
	private void a(p9 A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (!this.i && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Feats.Contains<euv>())
		{
			double num = 1.0 + (euv.a + (double)serviceOrThrow.aqu().v().GetSpecializationValue<bco>(true) * bco.a) * (double)serviceOrThrow.aqu().v().Skills.Get<e70>().g();
			this.i = true;
			foreach (KeyValuePair<a0, int> keyValuePair in Enumerable.ToList<KeyValuePair<a0, int>>(this.d))
			{
				if (keyValuePair.Value > 0)
				{
					this.d[keyValuePair.Key] = Convert.ToInt32((double)keyValuePair.Value * num);
				}
			}
		}
	}

	// Token: 0x06006D59 RID: 27993 RVA: 0x002DB8F0 File Offset: 0x002D9AF0
	private void a()
	{
		foreach (coh coh in Enumerable.ToList<coh>(this.a.z2()))
		{
			if (coh != null && (coh.Definition == null || coh.Definition.bc() < cr1.e) && !coh.CustomProperties.GetPrimitivePropertyValue<bool>(vo.i, new bool?(false)).Value)
			{
				this.a.z5(coh);
			}
		}
	}

	// Token: 0x04002CB9 RID: 11449
	private dcw a = new dcw();

	// Token: 0x04002CBA RID: 11450
	private string b;

	// Token: 0x04002CBB RID: 11451
	private List<string> c = new List<string>();

	// Token: 0x04002CBC RID: 11452
	private Dictionary<a0, int> d = new Dictionary<a0, int>();

	// Token: 0x04002CBD RID: 11453
	[NonSerialized]
	private p9 e;

	// Token: 0x04002CBE RID: 11454
	[NonSerialized]
	private bool f;

	// Token: 0x04002CBF RID: 11455
	[NonSerialized]
	private HashSet<string> g;

	// Token: 0x04002CC0 RID: 11456
	private TimeSpan h;

	// Token: 0x04002CC1 RID: 11457
	private bool i;

	// Token: 0x04002CC2 RID: 11458
	private bool j;

	// Token: 0x04002CC3 RID: 11459
	private int k = 1;

	// Token: 0x04002CC4 RID: 11460
	private int l = cuo.a.Next();

	// Token: 0x0200130E RID: 4878
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006D5C RID: 27996 RVA: 0x002DB9B4 File Offset: 0x002D9BB4
		internal int a(d9n A_0)
		{
			return A_0.RarityFactor;
		}

		// Token: 0x04002CC5 RID: 11461
		public static readonly dvp.a a = new dvp.a();

		// Token: 0x04002CC6 RID: 11462
		public static Func<d9n, int> b;
	}
}
