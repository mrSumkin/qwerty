using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006F0 RID: 1776
[eiz("CKG")]
[Serializable]
public sealed class an5 : d1k, ISerializable
{
	// Token: 0x06002DC9 RID: 11721 RVA: 0x00104484 File Offset: 0x00102684
	private an5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 224)
		{
			this.a = A_0.GetString("CKG:M");
			this.b = A_0.GetString("CKG:O");
		}
		if (ell.a() >= 690)
		{
			this.c = A_0.GetString("CKG:MOD");
		}
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x001044EC File Offset: 0x001026EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CKG:M", this.a);
		info.AddValue("CKG:O", this.b);
		info.AddValue("CKG:MOD", this.c);
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x00104534 File Offset: 0x00102734
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002DCC RID: 11724 RVA: 0x0010453C File Offset: 0x0010273C
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x00104548 File Offset: 0x00102748
	public string b()
	{
		return this.b;
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x00104550 File Offset: 0x00102750
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x0010455C File Offset: 0x0010275C
	public string d()
	{
		return this.c;
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x00104564 File Offset: 0x00102764
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x00104570 File Offset: 0x00102770
	public an5()
	{
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x0010457C File Offset: 0x0010277C
	public override aw4 a1()
	{
		an5 an = new an5();
		this.rg(an);
		return an;
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x00104598 File Offset: 0x00102798
	protected override cd1 rf(int A_0)
	{
		dqx dqx = d79.Get<dqx>();
		if (dqx != null)
		{
			int a_ = y8.a(A_0);
			fv fv = zp.d(a_, this.a);
			fv fv2 = y8.a("Weapons\\KnifeHandle", null);
			fv fv3 = this.a();
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv fv4 = this.a(A_0);
				fv fv5 = null;
				if (fv4 != null)
				{
					fv4.QualityLevel = y8.a(A_0);
					int a_2 = y8.a(A_0);
					fv5 = zp.b(a_2);
					fv5.QualityLevel = a_2;
				}
				return dqx.a(null, new Dictionary<string, coh>
				{
					{
						dqx.a,
						fv
					},
					{
						dqx.b,
						fv2
					},
					{
						dqx.c,
						fv3
					},
					{
						dqx.d,
						fv4
					},
					{
						dqx.e,
						fv5
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x001046BC File Offset: 0x001028BC
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		an5 an = (an5)A_0;
		an.a = this.a;
		an.b = this.b;
		an.c = this.c;
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x001046F4 File Offset: 0x001028F4
	private fv a()
	{
		string text;
		if (!string.IsNullOrWhiteSpace(this.b))
		{
			text = this.b;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(0);
			itemPoolForQuality.a("KnifeMold", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("KnifeMold", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("KnifeMold", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("SerratedKnifeMold", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("DaggerMold", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x001047BC File Offset: 0x001029BC
	private fv a(int A_0)
	{
		string text = null;
		if (!string.IsNullOrEmpty(this.c))
		{
			text = this.c;
		}
		else if (A_0 >= 3 && zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("ElectroshockGenerator", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019CC RID: 6604
	private new string a;

	// Token: 0x040019CD RID: 6605
	private string b;

	// Token: 0x040019CE RID: 6606
	private string c;
}
