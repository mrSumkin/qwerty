using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A54 RID: 2644
[eiz("FOEJ")]
[Serializable]
public sealed class bp8 : cze, ISerializable
{
	// Token: 0x06003E88 RID: 16008 RVA: 0x00179AA8 File Offset: 0x00177CA8
	private bp8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("FOEJ:SFI");
		this.b = A_0.GetSingle("FOEJ:FIEA");
		this.c = A_0.GetBoolean("FOEJ:SDAE");
		this.d = A_0.GetString("FOEJ:RC");
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x00179B14 File Offset: 0x00177D14
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FOEJ:SFI", this.a);
		info.AddValue("FOEJ:FIEA", this.b);
		info.AddValue("FOEJ:SDAE", this.c);
		info.AddValue("FOEJ:RC", this.d);
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x00179B70 File Offset: 0x00177D70
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x00179B78 File Offset: 0x00177D78
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x00179B84 File Offset: 0x00177D84
	public float d()
	{
		return this.b;
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00179B8C File Offset: 0x00177D8C
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x00179B98 File Offset: 0x00177D98
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x00179BA0 File Offset: 0x00177DA0
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x00179BAC File Offset: 0x00177DAC
	public string c()
	{
		return this.d;
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x00179BB4 File Offset: 0x00177DB4
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x00179BC0 File Offset: 0x00177DC0
	public bp8()
	{
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x00179BDC File Offset: 0x00177DDC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					this.c()
				}))
				{
					c5x c5x = (c5x)b0b;
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					if (!this.a())
					{
						ad6 ad = new ad6(c5x);
						ad.b((double)c5x.o.b.d.GetValueOrDefault(1f));
						ad.c(0.0);
						ad.a(0.0005);
						ad6 item = ad;
						awx.ad().Add(item);
					}
					else
					{
						ad6 ad2 = new ad6(c5x);
						ad2.b((double)c5x.o.b.d.GetValueOrDefault());
						ad2.c((double)this.d());
						ad2.a(0.0005);
						ad6 item2 = ad2;
						awx.ad().Add(item2);
					}
					if (this.b())
					{
						c5x.TileFormationModifiers.c();
						c5x.z();
						List<auv> list = awx.ad();
						uk uk = new uk();
						uk.a(new Guid?(c5x.qe()));
						uk.a(bvl.e);
						list.Add(new a4s(uk, null, null, null));
					}
					serviceOrThrow.aqw().ActionManager.g9(awx, atp.a);
				}
			}
		}
	}

	// Token: 0x04001BBC RID: 7100
	private new bool a;

	// Token: 0x04001BBD RID: 7101
	private float b = 1f;

	// Token: 0x04001BBE RID: 7102
	private bool c = true;

	// Token: 0x04001BBF RID: 7103
	private string d;
}
