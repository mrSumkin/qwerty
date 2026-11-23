using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006F3 RID: 1779
[eiz("ZX0")]
[Serializable]
public sealed class esy : d1k, ISerializable
{
	// Token: 0x06002DEC RID: 11756 RVA: 0x00105068 File Offset: 0x00103268
	private esy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("ZX0:C");
		this.b = A_0.GetString("ZX0:D");
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x00105094 File Offset: 0x00103294
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZX0:C", this.a);
		info.AddValue("ZX0:D", this.b);
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x001050C0 File Offset: 0x001032C0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x001050C8 File Offset: 0x001032C8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x001050D4 File Offset: 0x001032D4
	public string b()
	{
		return this.b;
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x001050DC File Offset: 0x001032DC
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x001050E8 File Offset: 0x001032E8
	public esy()
	{
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x001050F4 File Offset: 0x001032F4
	public override aw4 a1()
	{
		esy esy = new esy();
		this.rg(esy);
		return esy;
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x00105110 File Offset: 0x00103310
	protected override cd1 rf(int A_0)
	{
		dgl dgl = d79.Get<dgl>();
		if (dgl != null)
		{
			int a_ = y8.a(A_0);
			int a_2 = y8.a(A_0);
			fv fv = y8.a("Weapons\\chemicalPistolFrame", null);
			fv fv2 = this.b(a_);
			fv fv3 = this.a(a_2);
			if (fv2 != null && fv2.TypedDefinition != null && fv != null && fv.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				fv2.QualityLevel = a_;
				fv3.QualityLevel = a_2;
				return dgl.a(null, new Dictionary<string, coh>
				{
					{
						dgl.a,
						fv
					},
					{
						dgl.c,
						fv2
					},
					{
						dgl.b,
						fv3
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x001051F0 File Offset: 0x001033F0
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		esy esy = (esy)A_0;
		esy.a = this.a;
		esy.b = this.b;
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x00105218 File Offset: 0x00103418
	private fv b(int A_0)
	{
		string text;
		if (this.a != null)
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("AcidCollector", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x00105284 File Offset: 0x00103484
	private fv a(int A_0)
	{
		string text;
		if (this.b != null)
		{
			text = this.b;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("BlobDispenser", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019D2 RID: 6610
	private new string a;

	// Token: 0x040019D3 RID: 6611
	private string b;
}
