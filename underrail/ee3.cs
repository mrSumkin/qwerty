using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006EB RID: 1771
[eiz("L50")]
[Serializable]
public sealed class ee3 : cpr, ISerializable
{
	// Token: 0x06002DAA RID: 11690 RVA: 0x00103E04 File Offset: 0x00102004
	private ee3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("L50:P", typeof(bool?)) as bool?);
		this.b = (A_0.GetValue("L50:O", typeof(bool?)) as bool?);
		this.c = A_0.GetString("L50:L");
		if (ell.a() >= 129)
		{
			this.d = (A_0.GetValue("L50:T", typeof(ebg?)) as ebg?);
		}
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x00103EA8 File Offset: 0x001020A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L50:P", this.a);
		info.AddValue("L50:O", this.b);
		info.AddValue("L50:L", this.c);
		info.AddValue("L50:T", this.d);
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x00103F10 File Offset: 0x00102110
	public bool? b()
	{
		return this.a;
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x00103F18 File Offset: 0x00102118
	public void b(bool? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x00103F24 File Offset: 0x00102124
	public bool? a()
	{
		return this.b;
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x00103F2C File Offset: 0x0010212C
	public void a(bool? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x00103F38 File Offset: 0x00102138
	public string d()
	{
		return this.c;
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x00103F40 File Offset: 0x00102140
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x00103F4C File Offset: 0x0010214C
	public ebg? c()
	{
		return this.d;
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x00103F54 File Offset: 0x00102154
	public void a(ebg? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x00103F60 File Offset: 0x00102160
	public ee3()
	{
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x00103F68 File Offset: 0x00102168
	public override aw4 a1()
	{
		ee3 ee = new ee3();
		this.rg(ee);
		return ee;
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x00103F84 File Offset: 0x00102184
	protected override c8d wx(int A_0)
	{
		d82 d = d79.Get<d82>();
		if (d != null)
		{
			int num = y8.a(A_0);
			int a_ = d05.a(1, num, 40);
			fv fv = zp.c(num, this.c);
			if (fv != null)
			{
				fv.QualityLevel = a_;
				bool flag = this.a.GetValueOrDefault() || zp.a.NextDouble() < 0.15;
				bool flag2 = this.b.GetValueOrDefault() || zp.a.NextDouble() < 0.15;
				fv fv2 = null;
				fv fv3 = null;
				if (flag)
				{
					fv2 = zp.a(num);
					fv2.QualityLevel = y8.a(A_0);
				}
				if (flag2)
				{
					fv3 = this.a(num);
					fv3.QualityLevel = y8.a(A_0);
				}
				return d.a(null, new Dictionary<string, coh>
				{
					{
						d82.a,
						fv
					},
					{
						d82.c,
						fv3
					},
					{
						d82.b,
						fv2
					}
				}).a() as c8d;
			}
		}
		return null;
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x001040A4 File Offset: 0x001022A4
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		ee3 ee = A_0 as ee3;
		ee.c = this.c;
		ee.b = this.b;
		ee.a = this.a;
		ee.d = this.d;
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x001040E4 File Offset: 0x001022E4
	private fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (this.d == null || this.d.Value == ebg.a)
		{
			itemPoolForQuality.a("BlackCloth", int.MinValue, int.MaxValue, 1);
		}
		if (this.d == null || this.d.Value == ebg.b)
		{
			itemPoolForQuality.a("AluminizedCloth", int.MinValue, int.MaxValue, 1);
		}
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Fabric\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019C6 RID: 6598
	private new bool? a;

	// Token: 0x040019C7 RID: 6599
	private bool? b;

	// Token: 0x040019C8 RID: 6600
	private string c;

	// Token: 0x040019C9 RID: 6601
	private ebg? d;
}
