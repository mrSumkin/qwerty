using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006EA RID: 1770
[eiz("L51")]
[Serializable]
public sealed class bb4 : cpr, ISerializable
{
	// Token: 0x06002D98 RID: 11672 RVA: 0x00103994 File Offset: 0x00101B94
	private bb4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("L51:P", typeof(bool?)) as bool?);
		this.b = (A_0.GetValue("L51:O", typeof(bool?)) as bool?);
		this.c = A_0.GetString("L51:L");
		this.d = A_0.GetString("L51:B");
		if (ell.a() >= 129)
		{
			this.e = (A_0.GetValue("L51:T", typeof(th?)) as th?);
		}
	}

	// Token: 0x06002D99 RID: 11673 RVA: 0x00103A4C File Offset: 0x00101C4C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L51:P", this.a);
		info.AddValue("L51:O", this.b);
		info.AddValue("L51:L", this.c);
		info.AddValue("L51:B", this.d);
		info.AddValue("L51:T", this.e);
	}

	// Token: 0x06002D9A RID: 11674 RVA: 0x00103AC8 File Offset: 0x00101CC8
	public bool? b()
	{
		return this.a;
	}

	// Token: 0x06002D9B RID: 11675 RVA: 0x00103AD0 File Offset: 0x00101CD0
	public void b(bool? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D9C RID: 11676 RVA: 0x00103ADC File Offset: 0x00101CDC
	public bool? c()
	{
		return this.b;
	}

	// Token: 0x06002D9D RID: 11677 RVA: 0x00103AE4 File Offset: 0x00101CE4
	public void a(bool? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x00103AF0 File Offset: 0x00101CF0
	public string d()
	{
		return this.c;
	}

	// Token: 0x06002D9F RID: 11679 RVA: 0x00103AF8 File Offset: 0x00101CF8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002DA0 RID: 11680 RVA: 0x00103B04 File Offset: 0x00101D04
	public string a()
	{
		return this.d;
	}

	// Token: 0x06002DA1 RID: 11681 RVA: 0x00103B0C File Offset: 0x00101D0C
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002DA2 RID: 11682 RVA: 0x00103B18 File Offset: 0x00101D18
	public th? e()
	{
		return this.e;
	}

	// Token: 0x06002DA3 RID: 11683 RVA: 0x00103B20 File Offset: 0x00101D20
	public void a(th? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x00103B2C File Offset: 0x00101D2C
	public bb4()
	{
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x00103B38 File Offset: 0x00101D38
	public override aw4 a1()
	{
		bb4 bb = new bb4();
		this.rg(bb);
		return bb;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x00103B54 File Offset: 0x00101D54
	protected override c8d wx(int A_0)
	{
		dn8 dn = d79.Get<dn8>();
		if (dn != null)
		{
			int num = y8.a(A_0);
			int a_ = y8.a(A_0);
			fv fv = base.a(this.c, num);
			fv fv2 = zp.a(y8.a(A_0), this.d);
			if (fv != null && fv2 != null)
			{
				fv.QualityLevel = num;
				fv2.QualityLevel = a_;
				bool flag = this.a.GetValueOrDefault() || zp.a.NextDouble() < 0.1;
				bool flag2 = this.b.GetValueOrDefault() || zp.a.NextDouble() < 0.2;
				fv fv3 = null;
				fv fv4 = null;
				if (flag)
				{
					fv3 = this.b(num);
					if (fv3 != null)
					{
						fv3.QualityLevel = y8.a(A_0);
					}
				}
				if (flag2)
				{
					fv4 = this.a(num);
					if (fv4 != null)
					{
						fv4.QualityLevel = y8.a(A_0);
					}
				}
				return dn.a(null, new Dictionary<string, coh>
				{
					{
						dn8.a,
						fv
					},
					{
						dn8.b,
						fv2
					},
					{
						dn8.c,
						fv3
					},
					{
						dn8.d,
						fv4
					}
				}).a() as c8d;
			}
		}
		return null;
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x00103CB0 File Offset: 0x00101EB0
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		bb4 bb = A_0 as bb4;
		bb.c = this.c;
		bb.d = this.d;
		bb.b = this.b;
		bb.a = this.a;
		bb.e = this.e;
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x00103D08 File Offset: 0x00101F08
	private fv b(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("CeramicPlate", int.MinValue, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("BallisticArmorPlates\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x00103D58 File Offset: 0x00101F58
	private fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (this.e == null || this.e.Value == th.a)
		{
			itemPoolForQuality.a("BlackCloth", int.MinValue, int.MaxValue, 5);
		}
		if (this.e == null || this.e.Value == th.b)
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

	// Token: 0x040019C1 RID: 6593
	private new bool? a;

	// Token: 0x040019C2 RID: 6594
	private bool? b;

	// Token: 0x040019C3 RID: 6595
	private string c;

	// Token: 0x040019C4 RID: 6596
	private string d;

	// Token: 0x040019C5 RID: 6597
	private th? e;
}
