using System;
using System.Runtime.Serialization;

// Token: 0x020011EB RID: 4587
[eiz("TT0")]
[Serializable]
public abstract class cos : ya, ISerializable, l2, d8a
{
	// Token: 0x06006283 RID: 25219 RVA: 0x002A9760 File Offset: 0x002A7960
	protected cos(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TT0:T", typeof(ar7)) as ar7);
		this.b = (A_0.GetValue("TT0:I", typeof(coh)) as coh);
		if (ell.a() >= 177)
		{
			this.c = (A_0.GetValue("TT0:D", typeof(double?)) as double?);
		}
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x002A97EC File Offset: 0x002A79EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TT0:T", this.a);
		info.AddValue("TT0:I", this.b);
		info.AddValue("TT0:D", this.c);
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06006285 RID: 25221 RVA: 0x002A983C File Offset: 0x002A7A3C
	public coh TrapItem
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06006286 RID: 25222 RVA: 0x002A9844 File Offset: 0x002A7A44
	public c5x TrapEntity
	{
		get
		{
			if (this.a != null)
			{
				return this.a.ao() as c5x;
			}
			return null;
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06006287 RID: 25223 RVA: 0x002A9864 File Offset: 0x002A7A64
	// (set) Token: 0x06006288 RID: 25224 RVA: 0x002A986C File Offset: 0x002A7A6C
	public double? TriggeringRadius
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

	// Token: 0x06006289 RID: 25225 RVA: 0x002A9878 File Offset: 0x002A7A78
	protected cos(c5x A_0, coh A_1)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
		base.Name = "TrapTrigger_" + Guid.NewGuid().ToString();
	}

	// Token: 0x0600628A RID: 25226 RVA: 0x002A98C4 File Offset: 0x002A7AC4
	public void b()
	{
		this.a(null, true);
	}

	// Token: 0x0600628B RID: 25227 RVA: 0x002A98D0 File Offset: 0x002A7AD0
	public void a(c5x A_0)
	{
		this.a(A_0, false);
	}

	// Token: 0x0600628C RID: 25228 RVA: 0x002A98E0 File Offset: 0x002A7AE0
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new ar7(this.a.afl().Value, A_0);
		}
	}

	// Token: 0x0600628D RID: 25229 RVA: 0x002A9930 File Offset: 0x002A7B30
	public Guid? ago()
	{
		if (this.a != null)
		{
			return this.a.afl();
		}
		return null;
	}

	// Token: 0x0600628E RID: 25230 RVA: 0x002A9960 File Offset: 0x002A7B60
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		if (this.a(A_0))
		{
			this.a(A_0, false);
		}
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x002A9980 File Offset: 0x002A7B80
	protected override void tk(b0b A_0)
	{
		base.tk(A_0);
		if (this.c != null && base.Area != null && this.a(A_0))
		{
			this.a(A_0, false);
		}
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x002A99BC File Offset: 0x002A7BBC
	protected amc f()
	{
		c5x c5x = this.TrapEntity;
		if (c5x != null)
		{
			ed2 ed = c5x.r.b as ed2;
			if (ed != null)
			{
				return ed.a();
			}
		}
		return null;
	}

	// Token: 0x06006291 RID: 25233
	protected abstract bool kr(c5x A_0, c5x A_1, bool A_2);

	// Token: 0x06006292 RID: 25234 RVA: 0x002A99F8 File Offset: 0x002A7BF8
	protected virtual bool yl(c5x A_0)
	{
		return A_0 == null || A_0.h.b == null || !A_0.h.b.aa().b(d8o.q);
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x002A9A34 File Offset: 0x002A7C34
	private void a(b0b A_0, bool A_1)
	{
		if (bpo.GetService<cnk>() == null)
		{
			return;
		}
		c5x c5x = A_0 as c5x;
		if (this.a != null && this.yl(c5x))
		{
			c5x c5x2 = this.a.ao() as c5x;
			if (c5x2 != null)
			{
				if (c5x != null && c5x.i.b != null && dz6.e())
				{
					c5x.i.b.a(m7.e, true, false);
				}
				if (this.kr(c5x, c5x2, A_1))
				{
					if (c5x2.r.b != null)
					{
						c5x2.r.b.a(true);
						ed2 ed = c5x2.r.b as ed2;
						if (ed != null)
						{
							ed.a(c5x);
						}
					}
					base.o();
					return;
				}
			}
			else
			{
				base.o();
			}
		}
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x002A9B10 File Offset: 0x002A7D10
	private bool a(b0b A_0)
	{
		if (this.c != null && base.Area != null)
		{
			ak1 ak = base.Area.a(base.Location);
			if (ak != null)
			{
				return aw1.a(A_0, ak) <= this.c.Value;
			}
		}
		return true;
	}

	// Token: 0x040029B4 RID: 10676
	private ar7 a;

	// Token: 0x040029B5 RID: 10677
	private coh b;

	// Token: 0x040029B6 RID: 10678
	private double? c;
}
