using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02001A47 RID: 6727
[eiz("MASE")]
[Serializable]
public sealed class bjo : d3e, ISerializable
{
	// Token: 0x060091F8 RID: 37368 RVA: 0x0039E2CC File Offset: 0x0039C4CC
	private bjo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MASE:A");
		this.b = (HashSet<btz>)A_0.GetValue("MASE:AFW", typeof(HashSet<btz>));
		if (ell.a() >= 61)
		{
			this.c = A_0.GetInt32("MASE:C");
		}
		if (ell.a() >= 691)
		{
			this.d = (A_0.GetValue("MASE:S", typeof(Guid?)) as Guid?);
		}
	}

	// Token: 0x060091F9 RID: 37369 RVA: 0x0039E370 File Offset: 0x0039C570
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MASE:A", this.a);
		info.AddValue("MASE:AFW", this.b);
		info.AddValue("MASE:C", this.c);
		info.AddValue("MASE:S", this.d);
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x060091FA RID: 37370 RVA: 0x0039E3D0 File Offset: 0x0039C5D0
	public override bool Negative
	{
		get
		{
			return this.c > 0;
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x060091FB RID: 37371 RVA: 0x0039E3DC File Offset: 0x0039C5DC
	// (set) Token: 0x060091FC RID: 37372 RVA: 0x0039E3E4 File Offset: 0x0039C5E4
	public float WeaponSpeedModification
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x060091FD RID: 37373 RVA: 0x0039E3F0 File Offset: 0x0039C5F0
	// (set) Token: 0x060091FE RID: 37374 RVA: 0x0039E3F8 File Offset: 0x0039C5F8
	[TypeConverter(typeof(EnumHashSetTypeConverter<btz>))]
	public HashSet<btz> ApplicableForWeapons
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x060091FF RID: 37375 RVA: 0x0039E404 File Offset: 0x0039C604
	// (set) Token: 0x06009200 RID: 37376 RVA: 0x0039E40C File Offset: 0x0039C60C
	public int ActionPointCostModification
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x06009201 RID: 37377 RVA: 0x0039E418 File Offset: 0x0039C618
	public bjo()
	{
	}

	// Token: 0x06009202 RID: 37378 RVA: 0x0039E42C File Offset: 0x0039C62C
	public bjo(float A_0, int A_1, IEnumerable<btz> A_2 = null)
	{
		this.a = A_0;
		this.c = A_1;
		if (A_2 != null)
		{
			foreach (btz btz in A_2)
			{
				this.b.Add(btz);
			}
		}
	}

	// Token: 0x06009203 RID: 37379 RVA: 0x0039E4A8 File Offset: 0x0039C6A8
	public override d3e b3()
	{
		bjo bjo = new bjo();
		this.xx(bjo);
		return bjo;
	}

	// Token: 0x06009204 RID: 37380 RVA: 0x0039E4C4 File Offset: 0x0039C6C4
	public override string b2()
	{
		string arg;
		if (this.b == null || this.b.Count == 0)
		{
			arg = "всего оружия";
		}
		else
		{
			arg = dh9.a(Enumerable.ToList<string>(Enumerable.Select<btz, string>(this.b, new Func<btz, string>(bjo.a.a.a))));
		}
		if (this.c >= 0)
		{
			return string.Format("Стоимость в очках действия атак {0} увеличена на {1}.", arg, this.c);
		}
		return string.Format("Стоимость в очках действия атак {0} уменьшена на {1}.", arg, Math.Abs(this.c));
	}

	// Token: 0x06009205 RID: 37381 RVA: 0x0039E570 File Offset: 0x0039C770
	protected override void @in(ll A_0)
	{
		cd1 cd = A_0.a().Offense.u();
		if (this.b == null || this.b.Count == 0 || (cd.TypedDefinition != null && this.b.Contains(cd.TypedDefinition.e())))
		{
			if (this.d != null && cd.Id != this.d.Value)
			{
				return;
			}
			dcu dcu = A_0.a().Offense;
			dcu.a(dcu.ax() + this.a);
			dcu dcu2 = A_0.a().Offense;
			dcu2.e(dcu2.j() + this.c);
		}
	}

	// Token: 0x06009206 RID: 37382 RVA: 0x0039E638 File Offset: 0x0039C838
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		bjo bjo = (bjo)A_0;
		bjo.c = this.c;
		bjo.a = this.a;
		bjo.b = new HashSet<btz>(this.b);
		bjo.d = this.d;
	}

	// Token: 0x0400383C RID: 14396
	private new float a;

	// Token: 0x0400383D RID: 14397
	private HashSet<btz> b = new HashSet<btz>();

	// Token: 0x0400383E RID: 14398
	private int c;

	// Token: 0x0400383F RID: 14399
	public Guid? d;

	// Token: 0x02001A48 RID: 6728
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06009209 RID: 37385 RVA: 0x0039E69C File Offset: 0x0039C89C
		internal string a(btz A_0)
		{
			return as3.aj[A_0].ToLowerInvariant();
		}

		// Token: 0x04003840 RID: 14400
		public static readonly bjo.a a = new bjo.a();

		// Token: 0x04003841 RID: 14401
		public static Func<btz, string> b;
	}
}
