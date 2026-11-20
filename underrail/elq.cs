using System;
using System.Runtime.Serialization;

// Token: 0x020018A0 RID: 6304
[eiz("CFEA")]
[Serializable]
public sealed class elq : btm, ISerializable
{
	// Token: 0x060085E2 RID: 34274 RVA: 0x00377AB8 File Offset: 0x00375CB8
	private elq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("CFEA:ERS", typeof(ar7));
			this.b = (bhp)A_0.GetValue("CFEA:ERB", typeof(bhp));
			return;
		}
		if (base.GetType() == typeof(elq))
		{
			this.a = (ar7)A_0.GetValue("_EntityRefStorage", typeof(ar7));
			this.b = (bhp)A_0.GetValue("_EntityRefBinding", typeof(bhp));
			return;
		}
		this.a = (ar7)A_0.GetValue("CameraFollowEntityActivity+_EntityRefStorage", typeof(ar7));
		this.b = (bhp)A_0.GetValue("CameraFollowEntityActivity+_EntityRefBinding", typeof(bhp));
	}

	// Token: 0x060085E3 RID: 34275 RVA: 0x00377BC0 File Offset: 0x00375DC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CFEA:ERS", this.a);
		info.AddValue("CFEA:ERB", this.b);
	}

	// Token: 0x060085E4 RID: 34276 RVA: 0x00377BEC File Offset: 0x00375DEC
	public bhp b()
	{
		return this.b;
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x00377BF4 File Offset: 0x00375DF4
	public void a(bhp A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x00377C00 File Offset: 0x00375E00
	public ar7 a()
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			return this.b.GetValue<ar7>(this);
		}
		return this.a;
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x00377C3C File Offset: 0x00375E3C
	public void a(ar7 A_0)
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			this.b.SetValue<ar7>(this, A_0);
		}
		this.a = A_0;
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x00377C78 File Offset: 0x00375E78
	public elq() : base(null)
	{
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x00377C8C File Offset: 0x00375E8C
	public elq(ar7 A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x00377CA8 File Offset: 0x00375EA8
	public elq(b0b A_0) : base(null)
	{
		if (A_0 != null)
		{
			this.a = new ar7(A_0);
		}
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x00377CD4 File Offset: 0x00375ED4
	protected override bool b4(e6d A_0)
	{
		if (this.a() != null && this.a().ao() != null)
		{
			bpo.GetServiceOrThrow<ps>().akx().aez(this.a().ao(), true);
		}
		return true;
	}

	// Token: 0x04003342 RID: 13122
	private ar7 a;

	// Token: 0x04003343 RID: 13123
	private bhp b = new bhp();
}
