using System;
using System.Runtime.Serialization;

// Token: 0x0200010C RID: 268
[eiz("SCA")]
[Serializable]
public class b8q : di6, ISerializable
{
	// Token: 0x06000667 RID: 1639 RVA: 0x0001B640 File Offset: 0x00019840
	protected b8q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetInt32("SCA:C");
			return;
		}
		if (base.GetType() == typeof(b8q))
		{
			this.a = A_0.GetInt32("_Current");
			return;
		}
		this.a = A_0.GetInt32("SequentialCompositeActivity+_Current");
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0001B6B0 File Offset: 0x000198B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCA:C", this.a);
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0001B6CC File Offset: 0x000198CC
	public b8q() : base(new btm[0])
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0001B6DC File Offset: 0x000198DC
	public b8q(params btm[] A_0) : base(A_0)
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0001B6E8 File Offset: 0x000198E8
	public b8q(string A_0, params btm[] A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0001B6F4 File Offset: 0x000198F4
	public virtual btm ev(Exception A_0, btm A_1)
	{
		return null;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0001B6F8 File Offset: 0x000198F8
	protected override bool b4(e6d A_0)
	{
		base.b4(A_0);
		return this.b(A_0);
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0001B70C File Offset: 0x0001990C
	protected override bool aen(e6d A_0)
	{
		if (this.a >= base.f().Count)
		{
			return base.aen(A_0);
		}
		if (base.f()[this.a].f(A_0) == cdv.b)
		{
			base.a(base.f()[this.a]);
			this.a++;
			return this.b(A_0) && base.aen(A_0);
		}
		return false;
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0001B790 File Offset: 0x00019990
	protected sealed override btm aeo(Exception A_0)
	{
		btm a_ = null;
		if (this.a < base.f().Count)
		{
			a_ = base.f()[this.a];
		}
		return this.ev(A_0, a_);
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0001B7D0 File Offset: 0x000199D0
	protected override void aep(e6d A_0)
	{
		base.aep(A_0);
		if (this.a < base.f().Count)
		{
			base.f()[this.a].g(A_0);
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0001B814 File Offset: 0x00019A14
	protected override void aeq(e6d A_0)
	{
		base.aeq(A_0);
		if (this.a < base.f().Count)
		{
			base.f()[this.a].e(A_0);
		}
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0001B858 File Offset: 0x00019A58
	private bool b(e6d A_0)
	{
		return this.a == base.f().Count || this.a(A_0);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x0001B87C File Offset: 0x00019A7C
	private bool a(e6d A_0)
	{
		int num;
		do
		{
			cdv cdv = base.f()[this.a].d(A_0);
			if (base.f()[this.a].IsAsync)
			{
				base.b(base.f()[this.a]);
			}
			else if (cdv == cdv.a)
			{
				return false;
			}
			base.a(base.f()[this.a]);
			num = this.a + 1;
			this.a = num;
		}
		while (num != base.f().Count);
		return true;
	}

	// Token: 0x04000514 RID: 1300
	private new int a;
}
