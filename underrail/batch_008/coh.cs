using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200004C RID: 76
[eiz("II")]
[Serializable]
public abstract class coh : c7t, mp, ISerializable
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00004DBC File Offset: 0x00002FBC
	protected coh(SerializationInfo A_0, StreamingContext A_1)
	{
		this.c = (Guid)A_0.GetValue("II:I", typeof(Guid));
		this.d = A_0.GetInt32("II:S");
		this.e = (bit)A_0.GetValue("II:DP", typeof(bit));
		this.f = A_0.GetBoolean("II:L");
		this.g = (PropertyCollection)A_0.GetValue("II:CP", typeof(PropertyCollection));
		if (this.g == null)
		{
			this.g = new PropertyCollection();
		}
		this.h = A_0.GetBoolean("II:S1");
		if (ell.a() >= 30)
		{
			this.i = A_0.GetDouble("II:B");
			this.j = A_0.GetInt32("II:MB");
		}
		if (ell.a() >= 145)
		{
			this.k = A_0.GetDouble("II:D");
		}
		if (ell.a() >= 510)
		{
			this.l = (Version)A_0.GetValue("II:V", typeof(Version));
		}
		else
		{
			this.l = new Version(0, 0, 0, 0);
		}
		if (ell.a() >= 540)
		{
			di7.ReadList<dbj>("II:F", ref this.m, A_0);
		}
		else
		{
			this.m = new List<dbj>();
		}
		if (ell.a() >= 651)
		{
			this.n = A_0.GetDouble("II:DR");
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00004F90 File Offset: 0x00003190
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("II:I", this.c);
		info.AddValue("II:S", this.d);
		info.AddValue("II:DP", this.e);
		info.AddValue("II:L", this.f);
		info.AddValue("II:CP", this.g);
		info.AddValue("II:S1", this.h);
		info.AddValue("II:B", this.i);
		info.AddValue("II:MB", this.j);
		info.AddValue("II:D", this.k);
		info.AddValue("II:V", this.l);
		di7.WriteList<dbj>("II:F", this.m, info);
		info.AddValue("II:DR", this.n);
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000BB RID: 187 RVA: 0x00005070 File Offset: 0x00003270
	public static IEqualityComparer<coh> DistinctCodeComparer
	{
		get
		{
			return coh.a;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00005078 File Offset: 0x00003278
	public Guid Id
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000BD RID: 189 RVA: 0x00005080 File Offset: 0x00003280
	// (set) Token: 0x060000BE RID: 190 RVA: 0x00005088 File Offset: 0x00003288
	public int Stacks
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000BF RID: 191 RVA: 0x00005094 File Offset: 0x00003294
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000509C File Offset: 0x0000329C
	public bool Stealable
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x000050A8 File Offset: 0x000032A8
	[Browsable(false)]
	public bk3 Definition
	{
		get
		{
			bk3 result = this.e.wl();
			if (this.l < dm9.d && !this.o)
			{
				this.o = true;
				acj acj = coh.a();
				if (acj != null)
				{
					acj.aqo(this, this.l);
					this.l = dm9.d;
				}
				this.o = false;
			}
			return result;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005114 File Offset: 0x00003314
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000511C File Offset: 0x0000331C
	[Browsable(false)]
	public bit DefinitionProvider
	{
		get
		{
			return this.e;
		}
		set
		{
			if (value != null)
			{
				this.e = value;
			}
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000512C File Offset: 0x0000332C
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x00005134 File Offset: 0x00003334
	public bool Lootable
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005140 File Offset: 0x00003340
	public bool IsLibraryItem
	{
		get
		{
			return this.e is a67;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005154 File Offset: 0x00003354
	[XmlIgnore]
	public int ItemValue
	{
		get
		{
			if (this.Definition != null)
			{
				double num;
				if (this.Definition.bf() != null)
				{
					num = this.Definition.bf().Value;
				}
				else if (this.Definition.a6() != null)
				{
					num = this.Definition.a6().m1(this);
				}
				else
				{
					num = (double)this.Definition.tj(this);
				}
				if (!this.Definition.a9())
				{
					double num2 = this.afc();
					num = Math.Max(1.0, num * num2);
				}
				return (int)num * this.d;
			}
			return 0;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005208 File Offset: 0x00003408
	public int SingleItemValue
	{
		get
		{
			if (this.Definition != null)
			{
				double num;
				if (this.Definition.bf() != null)
				{
					num = this.Definition.bf().Value;
				}
				else if (this.Definition.a6() != null)
				{
					num = this.Definition.a6().m1(this);
				}
				else
				{
					num = (double)this.Definition.tj(this);
				}
				if (!this.Definition.a9())
				{
					double num2 = this.afc();
					num = Math.Max(1.0, num * num2);
				}
				return (int)num;
			}
			return 0;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x000052B4 File Offset: 0x000034B4
	public double Weight
	{
		get
		{
			if (this.Definition != null)
			{
				return this.Definition.a4() * (double)this.Stacks;
			}
			return 0.0;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000CA RID: 202 RVA: 0x000052EC File Offset: 0x000034EC
	public double SingleItemWeight
	{
		get
		{
			if (this.Definition != null)
			{
				return this.Definition.a4();
			}
			return 0.0;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000CB RID: 203 RVA: 0x00005310 File Offset: 0x00003510
	// (set) Token: 0x060000CC RID: 204 RVA: 0x00005318 File Offset: 0x00003518
	public double Battery
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000CD RID: 205 RVA: 0x00005324 File Offset: 0x00003524
	[ReadOnly(true)]
	public int MaxBattery
	{
		get
		{
			if (this.Definition != null && this.Definition.ba() != null)
			{
				return this.Definition.ba().Value;
			}
			return this.j;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000CE RID: 206 RVA: 0x00005370 File Offset: 0x00003570
	// (set) Token: 0x060000CF RID: 207 RVA: 0x00005378 File Offset: 0x00003578
	[ReadOnly(true)]
	public int MaxBatteryLegacy
	{
		get
		{
			return this.j;
		}
		set
		{
			this.j = value;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005384 File Offset: 0x00003584
	// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000538C File Offset: 0x0000358C
	public PropertyCollection CustomProperties
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005398 File Offset: 0x00003598
	// (set) Token: 0x060000D3 RID: 211 RVA: 0x000053A0 File Offset: 0x000035A0
	public double Durability
	{
		get
		{
			return this.k;
		}
		set
		{
			this.k = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x000053AC File Offset: 0x000035AC
	public int MaxDurability
	{
		get
		{
			if (this.Definition != null)
			{
				int num = Convert.ToInt32((double)this.Definition.yj() * (1.0 - this.n));
				if (num < 1)
				{
					num = 1;
				}
				return num;
			}
			return dwh.c;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x000053F8 File Offset: 0x000035F8
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x00005400 File Offset: 0x00003600
	public double MaxDurabilityReduction
	{
		get
		{
			return this.n;
		}
		set
		{
			this.n = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000540C File Offset: 0x0000360C
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x00005414 File Offset: 0x00003614
	public List<dbj> ItemEffects
	{
		get
		{
			return this.m;
		}
		set
		{
			this.m = value;
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00005420 File Offset: 0x00003620
	protected coh(bit A_0)
	{
		czh.a(A_0, "definitionProvider");
		this.e = A_0;
		this.c = Guid.NewGuid();
		if (this.e != null && this.e.wl() != null && !this.e.wl().a9())
		{
			this.Durability = (double)this.e.wl().yj();
		}
	}

	// Token: 0x060000DA RID: 218
	public abstract bool anx(efk A_0);

	// Token: 0x060000DB RID: 219
	public abstract coh fy();

	// Token: 0x060000DC RID: 220 RVA: 0x000054D0 File Offset: 0x000036D0
	public virtual bool fx(mp A_0)
	{
		return true;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000054D4 File Offset: 0x000036D4
	public override string ToString()
	{
		if (this.Definition != null)
		{
			return this.Definition.ToString();
		}
		return "Unknown";
	}

	// Token: 0x060000DE RID: 222 RVA: 0x000054F4 File Offset: 0x000036F4
	public void c()
	{
		if (this.e != null && this.e.wl() != null)
		{
			try
			{
				bk3 bk = this.e.wl().tw();
				bit bit = Activator.CreateInstance(typeof(IndependentItemDefinitionProvider<>).MakeGenericType(new Type[]
				{
					bk.GetType()
				}), new object[]
				{
					bk
				}) as bit;
				this.e = bit;
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "Failed to make an independent definition on item instance '{0}'", new object[]
				{
					this.ToString()
				});
			}
		}
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000055A0 File Offset: 0x000037A0
	public void agn(mp A_0)
	{
		if (A_0 != null)
		{
			this.h = (this.h && A_0.agi());
			this.f = (this.f || A_0.agk());
		}
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000055F0 File Offset: 0x000037F0
	public static coh a(bit A_0)
	{
		coh result;
		if (A_0 != null && A_0.wl() != null)
		{
			result = (Activator.CreateInstance(bk3.a(A_0.wl().GetType()), new object[]
			{
				A_0
			}) as coh);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000563C File Offset: 0x0000383C
	public void a(dbj A_0)
	{
		coh.b b = new coh.b();
		b.a = A_0;
		czh.a(b.a, "itemEffect");
		if (!string.IsNullOrEmpty(b.a.CategoryCode))
		{
			int num = b.a.abe(this);
			if (num > 0)
			{
				int num2 = 0;
				for (int i = this.m.Count - 1; i >= 0; i--)
				{
					if (this.m[i].CategoryCode == b.a.CategoryCode)
					{
						num2++;
					}
				}
				if (num2 >= num)
				{
					int num3 = num2 - num + 1;
					for (int j = 0; j < this.m.Count; j++)
					{
						if (this.m[j].CategoryCode == b.a.CategoryCode)
						{
							this.m.RemoveAt(j);
							j--;
							if (--num3 == 0)
							{
								break;
							}
						}
					}
				}
			}
		}
		if (b.a.Stacking == aa6.b || b.a.Stacking == aa6.a)
		{
			dbj dbj = Enumerable.FirstOrDefault<dbj>(Enumerable.Where<dbj>(this.m, new Func<dbj, bool>(b.a)));
			if (dbj != null)
			{
				if (b.a.Stacking == aa6.a)
				{
					dbj.RemainingTicks = b.a.RemainingTicks;
					return;
				}
				dbj.RemainingTicks += b.a.RemainingTicks;
				return;
			}
		}
		this.m.Add(b.a);
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x000057DC File Offset: 0x000039DC
	public bool a(double A_0, bool A_1 = true)
	{
		if (A_0 <= 0.0)
		{
			return false;
		}
		double num = Math.Min(this.Battery, A_0);
		if (num > 0.0 && (num >= A_0 || A_1))
		{
			this.Battery -= num;
			return true;
		}
		return false;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00005838 File Offset: 0x00003A38
	protected virtual void fz(coh A_0)
	{
		A_0.d = this.d;
		A_0.f = this.f;
		A_0.h = this.h;
		A_0.i = this.i;
		A_0.j = this.j;
		A_0.n = this.n;
		if (this.g == null)
		{
			A_0.g = new PropertyCollection();
		}
		else
		{
			foreach (Property property in this.g.Properties)
			{
				ICloneable cloneable = property.Value as ICloneable;
				object value;
				if (cloneable != null)
				{
					value = cloneable.Clone();
				}
				else
				{
					value = property.Value;
				}
				A_0.g[property.Name] = value;
			}
		}
		A_0.k = this.k;
		A_0.l = this.l;
		foreach (dbj dbj in this.m)
		{
			dbj item = dbj.b();
			A_0.m.Add(item);
		}
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00005998 File Offset: 0x00003B98
	protected virtual double afc()
	{
		return 0.15 + 0.85 * Math.Min(1.0, this.k / (double)Math.Max(1, this.Definition.yj()));
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000059E0 File Offset: 0x00003BE0
	private static acj a()
	{
		if (coh.b == null)
		{
			coh.b = bpo.GetService<acj>();
		}
		return coh.b;
	}

	// Token: 0x0400026D RID: 621
	private static IEqualityComparer<coh> a = new coh.a();

	// Token: 0x0400026E RID: 622
	private static acj b;

	// Token: 0x0400026F RID: 623
	public Guid c;

	// Token: 0x04000270 RID: 624
	private int d = 1;

	// Token: 0x04000271 RID: 625
	private bit e;

	// Token: 0x04000272 RID: 626
	private bool f = true;

	// Token: 0x04000273 RID: 627
	private PropertyCollection g = new PropertyCollection();

	// Token: 0x04000274 RID: 628
	private bool h = true;

	// Token: 0x04000275 RID: 629
	private double i;

	// Token: 0x04000276 RID: 630
	private int j;

	// Token: 0x04000277 RID: 631
	private double k;

	// Token: 0x04000278 RID: 632
	private Version l = dm9.d;

	// Token: 0x04000279 RID: 633
	private List<dbj> m = new List<dbj>();

	// Token: 0x0400027A RID: 634
	private double n;

	// Token: 0x0400027B RID: 635
	[NonSerialized]
	private bool o;

	// Token: 0x02001937 RID: 6455
	private class a : IEqualityComparer<coh>
	{
		// Token: 0x060088F8 RID: 35064 RVA: 0x00388B5C File Offset: 0x00386D5C
		public bool Equals(coh x, coh y)
		{
			return x.Definition.a5() == y.Definition.a5();
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x00388B84 File Offset: 0x00386D84
		public int GetHashCode(coh obj)
		{
			if (obj.Definition.a5() == null)
			{
				return 0;
			}
			return obj.Definition.a5().GetHashCode();
		}
	}

	// Token: 0x02001938 RID: 6456
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060088FC RID: 35068 RVA: 0x00388BC4 File Offset: 0x00386DC4
		internal bool a(dbj A_0)
		{
			return A_0.Code == this.a.Code;
		}

		// Token: 0x0400369C RID: 13980
		public dbj a;
	}
}
