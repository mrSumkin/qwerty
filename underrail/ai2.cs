using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000B66 RID: 2918
[eiz("CCSFE")]
[Serializable]
public sealed class ai2 : cze, ISerializable
{
	// Token: 0x060042C2 RID: 17090 RVA: 0x0019F6C8 File Offset: 0x0019D8C8
	private ai2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CCSFE:I");
		this.b = A_0.GetInt32("CCSFE:B");
		this.c = A_0.GetInt32("CCSFE:E");
		di7.ReadList<a1q>("CCSFE:D", ref this.d, A_0);
	}

	// Token: 0x060042C3 RID: 17091 RVA: 0x0019F72C File Offset: 0x0019D92C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCSFE:I", this.a);
		info.AddValue("CCSFE:E", this.c);
		info.AddValue("CCSFE:B", this.b);
		di7.WriteList<a1q>("CCSFE:D", this.d, info);
	}

	// Token: 0x060042C4 RID: 17092 RVA: 0x0019F788 File Offset: 0x0019D988
	public int d()
	{
		return this.a;
	}

	// Token: 0x060042C5 RID: 17093 RVA: 0x0019F790 File Offset: 0x0019D990
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060042C6 RID: 17094 RVA: 0x0019F79C File Offset: 0x0019D99C
	public int c()
	{
		return this.b;
	}

	// Token: 0x060042C7 RID: 17095 RVA: 0x0019F7A4 File Offset: 0x0019D9A4
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060042C8 RID: 17096 RVA: 0x0019F7B0 File Offset: 0x0019D9B0
	public int a()
	{
		return this.c;
	}

	// Token: 0x060042C9 RID: 17097 RVA: 0x0019F7B8 File Offset: 0x0019D9B8
	public void c(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060042CA RID: 17098 RVA: 0x0019F7C4 File Offset: 0x0019D9C4
	public List<a1q> b()
	{
		return this.d;
	}

	// Token: 0x060042CB RID: 17099 RVA: 0x0019F7CC File Offset: 0x0019D9CC
	public void a(List<a1q> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060042CC RID: 17100 RVA: 0x0019F7D8 File Offset: 0x0019D9D8
	public ai2()
	{
	}

	// Token: 0x060042CD RID: 17101 RVA: 0x0019F7EC File Offset: 0x0019D9EC
	public ai2(List<a1q> A_0, int A_1 = 1, int A_2 = 1000)
	{
		this.a(A_0);
		this.c(A_1);
		this.a(A_2);
	}

	// Token: 0x060042CE RID: 17102 RVA: 0x0019F820 File Offset: 0x0019DA20
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			dm5 dm = new dm5();
			dm.a(new AmmoType?(AmmoType.HighExplosives));
			dm.a("*");
			dm.d("Flame Blast");
			dm.a(0.0);
			dm.a(this.d);
			dm.b(650);
			dm.c("ScorchGround");
			dm.d(true);
			dm.a(26);
			dm.b("HeGrenadeExplode");
			dm.b(false);
			dm.c(false);
			dm.a(true);
			dtb dtb = new dtb();
			dtb.ad().Add(new bm3(this.d()));
			if (this.a() > 0)
			{
				for (int i = 0; i < this.a(); i++)
				{
					dtb.ad().Add(new a4s(dm, null, new ar7(A_1), null));
					dtb.ad().Add(new bm3(this.c()));
				}
			}
			aud.Zone.ActionManager.g9(dtb, atp.a);
		}
	}

	// Token: 0x04001C2B RID: 7211
	private new int a;

	// Token: 0x04001C2C RID: 7212
	private int b;

	// Token: 0x04001C2D RID: 7213
	private int c;

	// Token: 0x04001C2E RID: 7214
	private List<a1q> d = new List<a1q>();
}
