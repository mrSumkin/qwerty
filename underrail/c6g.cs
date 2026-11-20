using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Common.Events;

// Token: 0x02000234 RID: 564
[eiz("E3")]
[Serializable]
public sealed class c6g : u, IEventSubscriber<a8f>, ok, aue, ISerializable
{
	// Token: 0x06000FB9 RID: 4025 RVA: 0x00041094 File Offset: 0x0003F294
	private c6g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (TypedObjectReference<bag>)A_0.GetValue("E3:OR", typeof(TypedObjectReference<bag>));
			this.b = (ev2)A_0.GetValue("E3:D", typeof(ev2));
			this.c = (Point?)A_0.GetValue("E3:OSN", typeof(Point?));
			return;
		}
		if (base.GetType() == typeof(c6g))
		{
			this.a = (TypedObjectReference<bag>)A_0.GetValue("_ObserverReference", typeof(TypedObjectReference<bag>));
			this.b = (ev2)A_0.GetValue("_Definition", typeof(ev2));
			this.c = (Point?)A_0.GetValue("_OldSourceNode", typeof(Point?));
			return;
		}
		this.a = (TypedObjectReference<bag>)A_0.GetValue("Eye+_ObserverReference", typeof(TypedObjectReference<bag>));
		this.b = (ev2)A_0.GetValue("Eye+_Definition", typeof(ev2));
		this.c = (Point?)A_0.GetValue("Eye+_OldSourceNode", typeof(Point?));
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x000411F0 File Offset: 0x0003F3F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("E3:OR", this.a);
		info.AddValue("E3:D", this.b);
		info.AddValue("E3:OSN", this.c);
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00041240 File Offset: 0x0003F440
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

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0004125C File Offset: 0x0003F45C
	public ev2 Definition
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00041268 File Offset: 0x0003F468
	public override object SourceDefinition
	{
		get
		{
			if (this.a != null)
			{
				return "Observer: " + this.a.afl().ToString();
			}
			return null;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000412A8 File Offset: 0x0003F4A8
	public c1a Zone
	{
		get
		{
			if (base.Carrier != null)
			{
				return base.Carrier.Zone;
			}
			return null;
		}
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x000412C4 File Offset: 0x0003F4C4
	public c6g(TypedObjectReference<bag> A_0, ev2 A_1)
	{
		czh.a(A_0, "observerReference");
		czh.a(A_1, "definition");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x000412F0 File Offset: 0x0003F4F0
	public override void ig()
	{
		this.ij();
		this.e();
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00041304 File Offset: 0x0003F504
	public override void ih()
	{
		this.d = new dlx();
		this.d.a(a6h.a);
		if (this.Zone != null && this.Zone.Playfield != null)
		{
			this.d.a(this.Zone.Playfield.SightProcessor);
		}
		if (this.b.CustomSubscriber != null)
		{
			this.d.anu(this.b.CustomSubscriber);
		}
		else if (!this.b.DisableDefaultEventSubscriber)
		{
			this.d.anu(this);
		}
		this.d.a(new bbg());
		this.d.ag().c().AddRange(this.b.AdditionalImpactPredicates);
		this.d.ag().a().AddRange(this.b.AdditionalPenetrationPredicates);
		this.d.ag().a(this.b.Range);
		this.d.ag().a(false);
		if (!this.b.DisableDefaultPenetrationPredicate)
		{
			this.d.ag().a().Add(this);
		}
		if (!this.b.DisableDefaultImpactPredicate)
		{
			this.d.ag().c().Add(this);
		}
		this.ii(true);
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00041474 File Offset: 0x0003F674
	public override void ii(bool A_0)
	{
		Point point = new Point((int)base.Location.X, (int)base.Location.Y);
		if (A_0 || point != this.c)
		{
			this.d.aj(point);
			this.d.ag().a(this.b.Range);
			this.d.al();
			this.c = new Point?(point);
		}
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00041514 File Offset: 0x0003F714
	public override void ij()
	{
		if (this.d != null)
		{
			this.d.am();
			this.d = null;
		}
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00041534 File Offset: 0x0003F734
	void IEventSubscriber<a8f>.b(object A_0, EventHandler<a8f> A_1)
	{
		if (base.Carrier != null && base.Carrier.Area != null)
		{
			Point point = (Point)A_0;
			ak1 ak = base.Carrier.Area.b(point.X, point.Y);
			if (ak != null)
			{
				ak.c(A_1);
			}
		}
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00041590 File Offset: 0x0003F790
	void IEventSubscriber<a8f>.a(object A_0, EventHandler<a8f> A_1)
	{
		if (base.Carrier != null && base.Carrier.Area != null)
		{
			Point point = (Point)A_0;
			ak1 ak = base.Carrier.Area.b(point.X, point.Y);
			if (ak != null)
			{
				ak.a(A_1);
			}
		}
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x000415EC File Offset: 0x0003F7EC
	public bool q8(anl A_0)
	{
		return base.Carrier != null && base.Carrier.Area != null && this.Observer != null;
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00041618 File Offset: 0x0003F818
	public void q9(Point A_0, object A_1, float A_2)
	{
		if (A_2 != 1f)
		{
			return;
		}
		if (base.Carrier != null && base.Carrier.Area != null && this.Observer != null)
		{
			ak1 ak = base.Carrier.Area.b(A_0.X, A_0.Y);
			if (ak != null)
			{
				ak.b(this.Observer.c);
			}
		}
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0004168C File Offset: 0x0003F88C
	public bool ra(Point A_0, object A_1, float A_2)
	{
		return base.Carrier != null && base.Carrier.Area != null && this.Observer != null;
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x000416B8 File Offset: 0x0003F8B8
	public void rb(Point A_0, object A_1, float A_2)
	{
		if (A_2 != 1f)
		{
			return;
		}
		if (base.Carrier != null && base.Carrier.Area != null && this.Observer != null)
		{
			ak1 ak = base.Carrier.Area.b(A_0.X, A_0.Y);
			if (ak != null)
			{
				ak.c(this.Observer.c);
			}
		}
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0004172C File Offset: 0x0003F92C
	public object rc(anl A_0)
	{
		return A_0.a();
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0004173C File Offset: 0x0003F93C
	public bool g5(anl A_0)
	{
		if (base.Carrier != null && base.Carrier.Area != null)
		{
			ak1 ak = base.Carrier.Area.b(A_0.d().X, A_0.d().Y);
			return ak != null && !ak.Formation.c(1L);
		}
		return false;
	}

	// Token: 0x04000945 RID: 2373
	private new TypedObjectReference<bag> a;

	// Token: 0x04000946 RID: 2374
	private new ev2 b;

	// Token: 0x04000947 RID: 2375
	private Point? c;

	// Token: 0x04000948 RID: 2376
	[NonSerialized]
	private dlx d;
}
