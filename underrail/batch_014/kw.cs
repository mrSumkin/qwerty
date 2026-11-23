using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020018A2 RID: 6306
[eiz("MCA")]
[Serializable]
public sealed class kw : c1s, ISerializable
{
	// Token: 0x060085F0 RID: 34288 RVA: 0x00377D70 File Offset: 0x00375F70
	private kw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Guid?)A_0.GetValue("MCA:TEI", typeof(Guid?));
			this.b = A_0.GetString("MCA:TEN");
			this.c = (bt4)A_0.GetValue("MCA:D", typeof(bt4));
			this.d = (float?)A_0.GetValue("MCA:CCS", typeof(float?));
			this.e = A_0.GetBoolean("MCA:I");
			this.f = (Guid?)A_0.GetValue("MCA:CMI", typeof(Guid?));
			if (ell.a() >= 686)
			{
				this.g = A_0.GetBoolean("MCA:P");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(kw))
			{
				this.a = (Guid?)A_0.GetValue("_TargetEntityId", typeof(Guid?));
				this.b = A_0.GetString("_TargetEntityName");
				this.c = (bt4)A_0.GetValue("_Destination", typeof(bt4));
				this.d = (float?)A_0.GetValue("_CustomCameraSpeed", typeof(float?));
				this.e = A_0.GetBoolean("_Instant");
				this.f = (Guid?)A_0.GetValue("_CameraMovementId", typeof(Guid?));
				return;
			}
			this.a = (Guid?)A_0.GetValue("MoveCameraActivity+_TargetEntityId", typeof(Guid?));
			this.b = A_0.GetString("MoveCameraActivity+_TargetEntityName");
			this.c = (bt4)A_0.GetValue("MoveCameraActivity+_Destination", typeof(bt4));
			this.d = (float?)A_0.GetValue("MoveCameraActivity+_CustomCameraSpeed", typeof(float?));
			this.e = A_0.GetBoolean("MoveCameraActivity+_Instant");
			this.f = (Guid?)A_0.GetValue("MoveCameraActivity+_CameraMovementId", typeof(Guid?));
		}
	}

	// Token: 0x060085F1 RID: 34289 RVA: 0x00377FBC File Offset: 0x003761BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCA:TEI", this.a);
		info.AddValue("MCA:TEN", this.b);
		info.AddValue("MCA:D", this.c);
		info.AddValue("MCA:CCS", this.d);
		info.AddValue("MCA:I", this.e);
		info.AddValue("MCA:CMI", this.f);
		info.AddValue("MCA:P", this.g);
	}

	// Token: 0x060085F2 RID: 34290 RVA: 0x00378058 File Offset: 0x00376258
	public bt4 c()
	{
		return this.c;
	}

	// Token: 0x060085F3 RID: 34291 RVA: 0x00378060 File Offset: 0x00376260
	public void a(bt4 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060085F4 RID: 34292 RVA: 0x0037806C File Offset: 0x0037626C
	public string d()
	{
		return this.b;
	}

	// Token: 0x060085F5 RID: 34293 RVA: 0x00378074 File Offset: 0x00376274
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060085F6 RID: 34294 RVA: 0x00378080 File Offset: 0x00376280
	public bool f()
	{
		return this.e;
	}

	// Token: 0x060085F7 RID: 34295 RVA: 0x00378088 File Offset: 0x00376288
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060085F8 RID: 34296 RVA: 0x00378094 File Offset: 0x00376294
	public float? a()
	{
		return this.d;
	}

	// Token: 0x060085F9 RID: 34297 RVA: 0x0037809C File Offset: 0x0037629C
	public void a(float? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060085FA RID: 34298 RVA: 0x003780A8 File Offset: 0x003762A8
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060085FB RID: 34299 RVA: 0x003780B0 File Offset: 0x003762B0
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060085FC RID: 34300 RVA: 0x003780BC File Offset: 0x003762BC
	public bool e()
	{
		return this.g;
	}

	// Token: 0x060085FD RID: 34301 RVA: 0x003780C4 File Offset: 0x003762C4
	public void b(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060085FE RID: 34302 RVA: 0x003780D0 File Offset: 0x003762D0
	public kw()
	{
	}

	// Token: 0x060085FF RID: 34303 RVA: 0x003780E4 File Offset: 0x003762E4
	protected override bool b4(e6d A_0)
	{
		if (this.c == null)
		{
			return true;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
		if (serviceOrThrow.aqw() == null)
		{
			return true;
		}
		if (this.a != null)
		{
			foreach (aud aud in serviceOrThrow.aqw().Areas)
			{
				b0b b0b = aud.a(this.a.Value);
				if (b0b != null)
				{
					this.f = serviceOrThrow2.ams(b0b, this.e, this.d);
					break;
				}
			}
			return true;
		}
		if (!string.IsNullOrWhiteSpace(this.b))
		{
			foreach (aud aud2 in serviceOrThrow.aqw().Areas)
			{
				b0b b0b2 = aud2.a(this.b);
				if (b0b2 != null)
				{
					this.f = serviceOrThrow2.ams(b0b2, this.e, this.d);
					break;
				}
			}
			return true;
		}
		if (!this.c.c())
		{
			return true;
		}
		aud aud3;
		Vector3 a_;
		this.c.a(serviceOrThrow.aqw(), out aud3, out a_);
		if (aud3 != null)
		{
			this.f = serviceOrThrow2.amt(aud3, a_, this.e, this.d);
			return base.b4(A_0);
		}
		return true;
	}

	// Token: 0x06008600 RID: 34304 RVA: 0x0037828C File Offset: 0x0037648C
	protected override bool aen(e6d A_0)
	{
		if (base.aen(A_0))
		{
			return true;
		}
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		if (this.g)
		{
			cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow2.aqu() != null && serviceOrThrow2.aqu().v() != null && serviceOrThrow2.aqu().v().b() != null)
			{
				serviceOrThrow2.aqu().v().b().Location = serviceOrThrow.akx().aew();
				serviceOrThrow2.aqu().v().b().ah();
			}
		}
		return this.f == null || serviceOrThrow.akx().aeu() != this.f;
	}

	// Token: 0x04003344 RID: 13124
	private Guid? a;

	// Token: 0x04003345 RID: 13125
	private string b;

	// Token: 0x04003346 RID: 13126
	private bt4 c = new bt4();

	// Token: 0x04003347 RID: 13127
	private new float? d;

	// Token: 0x04003348 RID: 13128
	private new bool e;

	// Token: 0x04003349 RID: 13129
	private new Guid? f;

	// Token: 0x0400334A RID: 13130
	private new bool g;
}
