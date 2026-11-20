using System;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02001213 RID: 4627
[eiz("DTR")]
[Serializable]
public sealed class aiv : ya, ISerializable
{
	// Token: 0x06006387 RID: 25479 RVA: 0x002AE944 File Offset: 0x002ACB44
	private aiv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("DTR:R");
		this.b = A_0.GetBoolean("DTR:U");
		this.c = (A_0.GetValue("DTR:C", typeof(dth)) as dth);
		this.d = (A_0.GetValue("DTR:DI", typeof(Guid?)) as Guid?);
		this.e = (A_0.GetValue("DTR:DIF", typeof(IFunction<object, Guid>)) as IFunction<object, Guid>);
	}

	// Token: 0x06006388 RID: 25480 RVA: 0x002AE9E0 File Offset: 0x002ACBE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DTR:R", this.a);
		info.AddValue("DTR:U", this.b);
		info.AddValue("DTR:C", this.c);
		info.AddValue("DTR:DI", this.d);
		info.AddValue("DTR:DIF", this.e);
	}

	// Token: 0x06006389 RID: 25481 RVA: 0x002AEA50 File Offset: 0x002ACC50
	public bool b()
	{
		return this.a;
	}

	// Token: 0x0600638A RID: 25482 RVA: 0x002AEA58 File Offset: 0x002ACC58
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600638B RID: 25483 RVA: 0x002AEA64 File Offset: 0x002ACC64
	public bool a()
	{
		return this.b;
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x002AEA6C File Offset: 0x002ACC6C
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600638D RID: 25485 RVA: 0x002AEA78 File Offset: 0x002ACC78
	public dth c()
	{
		return this.c;
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x002AEA80 File Offset: 0x002ACC80
	public void a(dth A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x002AEA8C File Offset: 0x002ACC8C
	public Guid? d()
	{
		return this.d;
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x002AEA94 File Offset: 0x002ACC94
	public void a(Guid? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006391 RID: 25489 RVA: 0x002AEAA0 File Offset: 0x002ACCA0
	public aiv()
	{
	}

	// Token: 0x06006392 RID: 25490 RVA: 0x002AEAAC File Offset: 0x002ACCAC
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if ((c5x != null && c5x.c(e2b.d)) || (c5x.h.b != null && c5x.h.b.aa() is e3q))
		{
			if (this.c != null && !this.c.jh(this))
			{
				if (this.b)
				{
					base.o();
				}
				return;
			}
			if (this.a(c5x) && !this.a)
			{
				base.o();
			}
		}
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x002AEB50 File Offset: 0x002ACD50
	private bool a(c5x A_0)
	{
		if (A_0.Area == null || A_0.Zone == null)
		{
			return false;
		}
		Guid a_;
		if (this.d != null)
		{
			a_ = this.d.Value;
		}
		else
		{
			if (this.e == null)
			{
				return true;
			}
			a_ = this.e.a(this);
		}
		c5x c5x = A_0.Area.a(a_) as c5x;
		if (c5x != null)
		{
			if (A_0.i != null)
			{
				A_0.i.b.a(m7.e, true, false);
			}
			c9m a_2 = new c9m(c5x.GetAspect<j7>(), A_0.GetAspect<j7>(), true, null, true);
			A_0.Zone.ActionManager.g9(a_2, atp.a);
			return true;
		}
		return false;
	}

	// Token: 0x040029E8 RID: 10728
	private bool a;

	// Token: 0x040029E9 RID: 10729
	private bool b;

	// Token: 0x040029EA RID: 10730
	private dth c;

	// Token: 0x040029EB RID: 10731
	private new Guid? d;

	// Token: 0x040029EC RID: 10732
	private new IFunction<object, Guid> e;
}
