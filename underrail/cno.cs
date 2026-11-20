using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000231 RID: 561
[eiz("D")]
[Serializable]
public class cno : axv, a9q, bvq, ISerializable
{
	// Token: 0x06000FA2 RID: 4002 RVA: 0x00040D7C File Offset: 0x0003EF7C
	protected cno(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetBoolean("D:A");
			this.b = (TypedObjectReference<bag>)A_0.GetValue("D:OR", typeof(TypedObjectReference<bag>));
			this.c = A_0.GetInt32("D:L");
			return;
		}
		if (base.GetType() == typeof(cno))
		{
			this.a = A_0.GetBoolean("_Attached");
			this.b = (TypedObjectReference<bag>)A_0.GetValue("_ObserverReference", typeof(TypedObjectReference<bag>));
			this.c = A_0.GetInt32("_Layer");
			return;
		}
		this.a = A_0.GetBoolean("Divination+_Attached");
		this.b = (TypedObjectReference<bag>)A_0.GetValue("Divination+_ObserverReference", typeof(TypedObjectReference<bag>));
		this.c = A_0.GetInt32("Divination+_Layer");
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00040E80 File Offset: 0x0003F080
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("D:A", this.a);
		info.AddValue("D:OR", this.b);
		info.AddValue("D:L", this.c);
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00040EC8 File Offset: 0x0003F0C8
	public int m4()
	{
		return this.c;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00040ED0 File Offset: 0x0003F0D0
	public void m5(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00040EDC File Offset: 0x0003F0DC
	private bag a()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00040EF8 File Offset: 0x0003F0F8
	public override bool af7()
	{
		return this.b != null && this.b.ao() != null && this.b.ao().a();
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00040F28 File Offset: 0x0003F128
	internal cno(aud A_0, string A_1) : base(A_1, A_0)
	{
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00040F34 File Offset: 0x0003F134
	internal cno(aud A_0, Guid A_1, string A_2) : base(A_1, A_2, A_0)
	{
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00040F40 File Offset: 0x0003F140
	public void a(TypedObjectReference<bag> A_0)
	{
		czh.a(A_0, "observerReference");
		if (this.a)
		{
			this.b();
		}
		this.b = A_0;
		this.a = true;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00040F6C File Offset: 0x0003F16C
	public void b()
	{
		this.f();
		this.c();
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00040F80 File Offset: 0x0003F180
	public override void af8()
	{
		base.af8();
		this.b();
		base.h().Divinations.c(this);
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00040FAC File Offset: 0x0003F1AC
	public void b(TypedObjectReference<bag> A_0)
	{
		if (A_0 != null)
		{
			TypedObjectReference<bag> typedObjectReference = this.b;
			this.b = A_0;
			this.g();
			this.f();
			this.b = typedObjectReference;
			this.g();
		}
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00040FE8 File Offset: 0x0003F1E8
	internal void c()
	{
		this.a = false;
		this.b = null;
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00040FF8 File Offset: 0x0003F1F8
	protected override void af9(ak1 A_0)
	{
		czh.a(A_0, "tile");
		if (this.a() != null)
		{
			A_0.b(this.a().c);
		}
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00041024 File Offset: 0x0003F224
	protected override void aga(ak1 A_0)
	{
		czh.a(A_0, "tile");
		if (this.a() != null)
		{
			A_0.c(this.a().c);
		}
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00041050 File Offset: 0x0003F250
	protected override void agb(ak1 A_0)
	{
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00041054 File Offset: 0x0003F254
	protected override bool agc()
	{
		return false;
	}

	// Token: 0x04000942 RID: 2370
	private new bool a;

	// Token: 0x04000943 RID: 2371
	private TypedObjectReference<bag> b;

	// Token: 0x04000944 RID: 2372
	private int c;
}
