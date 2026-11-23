using System;
using System.Runtime.Serialization;

// Token: 0x02001A3D RID: 6717
[eiz("AAE")]
[Serializable]
public sealed class vf : wq, ISerializable
{
	// Token: 0x060091A6 RID: 37286 RVA: 0x0039D70C File Offset: 0x0039B90C
	private vf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cwt)A_0.GetValue("AAE:A", typeof(cwt));
		this.b = (cwt)A_0.GetValue("AAE:T", typeof(cwt));
		if (ell.a() >= 295)
		{
			this.c = (A_0.GetValue("AAE:C", typeof(j5)) as j5);
		}
	}

	// Token: 0x060091A7 RID: 37287 RVA: 0x0039D790 File Offset: 0x0039B990
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AAE:A", this.a);
		info.AddValue("AAE:T", this.b);
		info.AddValue("AAE:C", this.c);
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x060091A8 RID: 37288 RVA: 0x0039D7D8 File Offset: 0x0039B9D8
	// (set) Token: 0x060091A9 RID: 37289 RVA: 0x0039D7E0 File Offset: 0x0039B9E0
	public cwt DynamicTickAttack
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060091AA RID: 37290 RVA: 0x0039D7EC File Offset: 0x0039B9EC
	// (set) Token: 0x060091AB RID: 37291 RVA: 0x0039D7F4 File Offset: 0x0039B9F4
	public cwt TurnTickAttack
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060091AC RID: 37292 RVA: 0x0039D800 File Offset: 0x0039BA00
	// (set) Token: 0x060091AD RID: 37293 RVA: 0x0039D808 File Offset: 0x0039BA08
	public j5 Callback
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x060091AE RID: 37294 RVA: 0x0039D814 File Offset: 0x0039BA14
	public vf()
	{
	}

	// Token: 0x060091AF RID: 37295 RVA: 0x0039D81C File Offset: 0x0039BA1C
	public vf(cwt A_0, cwt A_1, j5 A_2 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060091B0 RID: 37296 RVA: 0x0039D83C File Offset: 0x0039BA3C
	public override void dk(ll A_0, int A_1)
	{
		if (this.a != null)
		{
			this.a.j = new ap9(A_0.a());
			cru a_ = A_0.a().Defense.a(this.a);
			if (this.c != null)
			{
				this.c.aft(A_0.a(), this.a, a_);
			}
		}
	}

	// Token: 0x060091B1 RID: 37297 RVA: 0x0039D8A4 File Offset: 0x0039BAA4
	public override void dl(ll A_0, int A_1)
	{
		if (this.b != null)
		{
			this.b.j = new ap9(A_0.a());
			cru a_ = A_0.a().Defense.a(this.b);
			if (this.c != null)
			{
				this.c.aft(A_0.a(), this.b, a_);
			}
		}
	}

	// Token: 0x060091B2 RID: 37298 RVA: 0x0039D90C File Offset: 0x0039BB0C
	public override wq dn()
	{
		vf vf = new vf();
		this.@do(vf);
		return vf;
	}

	// Token: 0x060091B3 RID: 37299 RVA: 0x0039D928 File Offset: 0x0039BB28
	protected override void @do(wq A_0)
	{
		base.@do(A_0);
		vf vf = (vf)A_0;
		vf.a = ((this.a != null) ? this.a.a() : null);
		vf.b = ((this.b != null) ? this.b.a() : null);
		vf.c = ((this.c != null) ? (this.c.Clone() as j5) : null);
	}

	// Token: 0x04003835 RID: 14389
	private cwt a;

	// Token: 0x04003836 RID: 14390
	private cwt b;

	// Token: 0x04003837 RID: 14391
	private j5 c;
}
