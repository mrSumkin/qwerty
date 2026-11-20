using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006F4 RID: 1780
[eiz("CGG")]
[Serializable]
public sealed class a1a : d1k, ISerializable
{
	// Token: 0x06002DF8 RID: 11768 RVA: 0x001052F0 File Offset: 0x001034F0
	private a1a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CGG:L");
		this.b = A_0.GetBoolean("CGG:M");
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x0010531C File Offset: 0x0010351C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CGG:L", this.a);
		info.AddValue("CGG:M", this.b);
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x00105348 File Offset: 0x00103548
	public a1a()
	{
	}

	// Token: 0x06002DFB RID: 11771 RVA: 0x00105350 File Offset: 0x00103550
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06002DFC RID: 11772 RVA: 0x00105358 File Offset: 0x00103558
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DFD RID: 11773 RVA: 0x00105364 File Offset: 0x00103564
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x0010536C File Offset: 0x0010356C
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x00105378 File Offset: 0x00103578
	public override aw4 a1()
	{
		a1a a1a = new a1a();
		this.rg(a1a);
		return a1a;
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x00105394 File Offset: 0x00103594
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		a1a a1a = (a1a)A_0;
		a1a.a = this.a;
		a1a.b = this.b;
	}

	// Token: 0x06002E01 RID: 11777 RVA: 0x001053C0 File Offset: 0x001035C0
	protected override cd1 rf(int A_0)
	{
		nj nj = d79.Get<nj>();
		if (nj != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.b(a_);
			if (fv != null && fv.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv fv2 = this.a(A_0);
				fv fv3 = null;
				if (fv2 != null)
				{
					fv2.QualityLevel = y8.a(A_0);
					int a_2 = y8.a(A_0);
					fv3 = zp.b(a_2);
					fv3.QualityLevel = a_2;
				}
				int a_3 = y8.a(A_0);
				fv fv4 = zp.a(a_3, 0.3);
				if (fv4 != null)
				{
					fv4.QualityLevel = a_3;
				}
				return nj.a(null, new Dictionary<string, coh>
				{
					{
						global::nj.a,
						fv
					},
					{
						global::nj.b,
						fv4
					},
					{
						global::nj.c,
						fv2
					},
					{
						global::nj.d,
						fv3
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x001054B4 File Offset: 0x001036B4
	private fv b(int A_0)
	{
		if (this.a)
		{
			return zp.c(A_0, null);
		}
		if (this.b)
		{
			return zp.d(A_0, null);
		}
		if (zp.a.NextDouble() < 0.25)
		{
			return zp.d(A_0, null);
		}
		return zp.c(A_0, null);
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x00105510 File Offset: 0x00103710
	private fv a(int A_0)
	{
		if (A_0 >= 3 && zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("ElectroshockGenerator", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("PneumaticHammer", int.MinValue, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x040019D4 RID: 6612
	private new bool a;

	// Token: 0x040019D5 RID: 6613
	private bool b;
}
