using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020019BD RID: 6589
[eiz("MWAACE")]
[Serializable]
public sealed class ee8 : d3e, ISerializable
{
	// Token: 0x06008D09 RID: 36105 RVA: 0x00392638 File Offset: 0x00390838
	private ee8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MWAACE:M");
		this.b = (A_0.GetValue("MWAACE:W", typeof(HashSet<btz>)) as HashSet<btz>);
	}

	// Token: 0x06008D0A RID: 36106 RVA: 0x0039268C File Offset: 0x0039088C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MWAACE:M", this.a);
		info.AddValue("MWAACE:W", this.b);
	}

	// Token: 0x06008D0B RID: 36107 RVA: 0x003926B8 File Offset: 0x003908B8
	public override bool ae5()
	{
		return this.a > 0f;
	}

	// Token: 0x06008D0C RID: 36108 RVA: 0x003926C8 File Offset: 0x003908C8
	public float a()
	{
		return this.a;
	}

	// Token: 0x06008D0D RID: 36109 RVA: 0x003926D0 File Offset: 0x003908D0
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008D0E RID: 36110 RVA: 0x003926DC File Offset: 0x003908DC
	public HashSet<btz> b()
	{
		return this.b;
	}

	// Token: 0x06008D0F RID: 36111 RVA: 0x003926E4 File Offset: 0x003908E4
	public void a(HashSet<btz> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008D10 RID: 36112 RVA: 0x003926F0 File Offset: 0x003908F0
	public ee8()
	{
	}

	// Token: 0x06008D11 RID: 36113 RVA: 0x00392708 File Offset: 0x00390908
	public ee8(float A_0, IEnumerable<btz> A_1 = null)
	{
		this.a = A_0;
		if (A_1 != null)
		{
			foreach (btz btz in A_1)
			{
				this.b.Add(btz);
			}
		}
	}

	// Token: 0x06008D12 RID: 36114 RVA: 0x00392780 File Offset: 0x00390980
	public override string b2()
	{
		string arg;
		if (this.b == null || this.b.Count == 0)
		{
			arg = "всего оружия";
		}
		else
		{
			arg = dh9.a(Enumerable.ToList<string>(Enumerable.Select<btz, string>(this.b, new Func<btz, string>(ee8.a.a.a))));
		}
		if (this.a >= 0f)
		{
			return string.Format("Стоимость в очках действия атак {0} увеличена на {1}.", arg, this.a.ToString("P0"));
		}
		return string.Format("Стоимость в очках действия атак {0} уменьшена на {1}.", arg, Math.Abs(this.a).ToString("P0"));
	}

	// Token: 0x06008D13 RID: 36115 RVA: 0x0039283C File Offset: 0x00390A3C
	protected override void @in(ll A_0)
	{
		if (this.b == null || this.b.Count == 0 || (A_0.a().Offense.u().TypedDefinition != null && this.b.Contains(A_0.a().Offense.u().TypedDefinition.e())))
		{
			dcu dcu = A_0.a().Offense;
			dcu.k(dcu.ak() + (double)this.a);
		}
	}

	// Token: 0x06008D14 RID: 36116 RVA: 0x003928C8 File Offset: 0x00390AC8
	public override d3e b3()
	{
		ee8 ee = new ee8();
		this.xx(ee);
		return ee;
	}

	// Token: 0x06008D15 RID: 36117 RVA: 0x003928E4 File Offset: 0x00390AE4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ee8 ee = (ee8)A_0;
		ee.a = this.a;
		ee.b = new HashSet<btz>(this.b);
	}

	// Token: 0x040037AF RID: 14255
	private new float a;

	// Token: 0x040037B0 RID: 14256
	private HashSet<btz> b = new HashSet<btz>();

	// Token: 0x020019BE RID: 6590
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008D18 RID: 36120 RVA: 0x00392924 File Offset: 0x00390B24
		internal string a(btz A_0)
		{
			return as3.aj[A_0].ToLowerInvariant();
		}

		// Token: 0x040037B1 RID: 14257
		public static readonly ee8.a a = new ee8.a();

		// Token: 0x040037B2 RID: 14258
		public static Func<btz, string> b;
	}
}
