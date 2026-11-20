using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000081 RID: 129
[eiz("E")]
[Serializable]
public abstract class k2 : u, ISerializable
{
	// Token: 0x060002F9 RID: 761 RVA: 0x0000DB40 File Offset: 0x0000BD40
	protected k2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (TypedObjectReference<bag>)A_0.GetValue("E:OR", typeof(TypedObjectReference<bag>));
			return;
		}
		if (base.GetType() == typeof(k2))
		{
			this.a = (TypedObjectReference<bag>)A_0.GetValue("_ObserverReference", typeof(TypedObjectReference<bag>));
			return;
		}
		this.a = (TypedObjectReference<bag>)A_0.GetValue("Ear+_ObserverReference", typeof(TypedObjectReference<bag>));
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0000DBDC File Offset: 0x0000BDDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("E:OR", this.a);
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060002FB RID: 763
	public abstract int HearingRange { get; }

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060002FC RID: 764 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
	public bag Observer
	{
		get
		{
			if (this.a != null)
			{
				return this.a.ao();
			}
			return null;
		}
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0000DC14 File Offset: 0x0000BE14
	protected k2(TypedObjectReference<bag> A_0)
	{
		czh.a(A_0, "observerReference");
		this.a = A_0;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0000DC30 File Offset: 0x0000BE30
	public override void ig()
	{
		this.ij();
		this.e();
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000DC40 File Offset: 0x0000BE40
	public override void ih()
	{
		ax1 ax = e3s.a(base.Carrier);
		if (ax != null)
		{
			ax.app(this);
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0000DC68 File Offset: 0x0000BE68
	public override void ii(bool A_0)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0000DC6C File Offset: 0x0000BE6C
	public override void ij()
	{
		ax1 ax = e3s.a(base.Carrier);
		if (ax != null)
		{
			ax.apq(this);
		}
	}

	// Token: 0x040003DA RID: 986
	private new TypedObjectReference<bag> a;
}
