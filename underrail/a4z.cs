using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020011FF RID: 4607
[eiz("RBT")]
[Serializable]
public sealed class a4z : ya, ISerializable
{
	// Token: 0x060062F5 RID: 25333 RVA: 0x002AC2B0 File Offset: 0x002AA4B0
	private a4z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RBT:T", typeof(ar7)) as ar7);
	}

	// Token: 0x060062F6 RID: 25334 RVA: 0x002AC2DC File Offset: 0x002AA4DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RBT:T", this.a);
	}

	// Token: 0x060062F7 RID: 25335 RVA: 0x002AC2F8 File Offset: 0x002AA4F8
	public c5x b()
	{
		if (this.a != null)
		{
			return this.a.ao() as c5x;
		}
		return null;
	}

	// Token: 0x060062F8 RID: 25336 RVA: 0x002AC318 File Offset: 0x002AA518
	public a4z(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x060062F9 RID: 25337 RVA: 0x002AC32C File Offset: 0x002AA52C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		if (this.a(A_0))
		{
			this.c(A_0);
		}
	}

	// Token: 0x060062FA RID: 25338 RVA: 0x002AC348 File Offset: 0x002AA548
	protected override void tk(b0b A_0)
	{
		base.tk(A_0);
		if (this.a(A_0))
		{
			this.c(A_0);
			return;
		}
		this.b(A_0);
	}

	// Token: 0x060062FB RID: 25339 RVA: 0x002AC36C File Offset: 0x002AA56C
	protected override void tl(b0b A_0)
	{
		base.tl(A_0);
		if (this.a(A_0))
		{
			this.c(A_0);
			return;
		}
		this.b(A_0);
	}

	// Token: 0x060062FC RID: 25340 RVA: 0x002AC390 File Offset: 0x002AA590
	protected override void pq(b0b A_0)
	{
		base.pq(A_0);
		this.b(A_0);
	}

	// Token: 0x060062FD RID: 25341 RVA: 0x002AC3A4 File Offset: 0x002AA5A4
	protected amc a()
	{
		c5x c5x = this.b();
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

	// Token: 0x060062FE RID: 25342 RVA: 0x002AC3E0 File Offset: 0x002AA5E0
	private void c(b0b A_0)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && Enumerable.FirstOrDefault<avm>(aspect.aa().StatusEffects.Get<avm>()) == null)
			{
				aspect.aa().StatusEffects.a(new avm(150, 0), false, false, false);
			}
		}
	}

	// Token: 0x060062FF RID: 25343 RVA: 0x002AC43C File Offset: 0x002AA63C
	private void b(b0b A_0)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				avm avm = Enumerable.FirstOrDefault<avm>(aspect.aa().StatusEffects.Get<avm>());
				if (avm != null)
				{
					aspect.aa().StatusEffects.d(avm);
				}
			}
		}
	}

	// Token: 0x06006300 RID: 25344 RVA: 0x002AC48C File Offset: 0x002AA68C
	private bool a(b0b A_0)
	{
		if (A_0 != null && base.Area != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null && aspect.aa().c(d8o.e) && aspect.aa().Gear.h().Item != null)
			{
				c5x c5x = this.b();
				if (c5x != null && c5x.a())
				{
					ak1 ak = base.Area.a(base.Location);
					if (ak != null)
					{
						return aw1.a(A_0, ak) <= 0.55;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x040029C7 RID: 10695
	private ar7 a;
}
