using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x02001899 RID: 6297
[eiz("ETA")]
[Serializable]
public sealed class s5 : c1s, ISerializable
{
	// Token: 0x060085B3 RID: 34227 RVA: 0x003770F0 File Offset: 0x003752F0
	private s5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("ETA:TS", typeof(ar7));
		this.b = (bhp)A_0.GetValue("ETA:TB", typeof(bhp));
		this.c = (bt4)A_0.GetValue("ETA:DS", typeof(bt4));
		this.d = (bhp)A_0.GetValue("ETA:DB", typeof(bhp));
		this.f = (ActionReference<djk>)A_0.GetValue("ETA:TAR", typeof(ActionReference<djk>));
		this.e = A_0.GetBoolean("ETA:F");
	}

	// Token: 0x060085B4 RID: 34228 RVA: 0x003771CC File Offset: 0x003753CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ETA:TS", this.a);
		info.AddValue("ETA:TB", this.b);
		info.AddValue("ETA:DS", this.c);
		info.AddValue("ETA:DB", this.d);
		info.AddValue("ETA:TAR", this.f);
		info.AddValue("ETA:F", this.e);
	}

	// Token: 0x060085B5 RID: 34229 RVA: 0x00377248 File Offset: 0x00375448
	public bhp e()
	{
		return this.b;
	}

	// Token: 0x060085B6 RID: 34230 RVA: 0x00377250 File Offset: 0x00375450
	public void a(bhp A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060085B7 RID: 34231 RVA: 0x0037725C File Offset: 0x0037545C
	public ar7 g()
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			return this.b.GetValue<ar7>(this);
		}
		return this.a;
	}

	// Token: 0x060085B8 RID: 34232 RVA: 0x00377298 File Offset: 0x00375498
	public void a(ar7 A_0)
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			this.b.SetValue<ar7>(this, A_0);
		}
		this.a = A_0;
	}

	// Token: 0x060085B9 RID: 34233 RVA: 0x003772D4 File Offset: 0x003754D4
	public bhp h()
	{
		return this.d;
	}

	// Token: 0x060085BA RID: 34234 RVA: 0x003772DC File Offset: 0x003754DC
	public void b(bhp A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060085BB RID: 34235 RVA: 0x003772E8 File Offset: 0x003754E8
	public bt4 f()
	{
		if (!ai.b() && this.d != null && this.d.ao7())
		{
			return this.d.GetValue<bt4>(this);
		}
		return this.c;
	}

	// Token: 0x060085BC RID: 34236 RVA: 0x00377324 File Offset: 0x00375524
	public void a(bt4 A_0)
	{
		if (!ai.b() && this.d != null && this.d.ao7())
		{
			this.d.SetValue<bt4>(this, A_0);
		}
		this.c = A_0;
	}

	// Token: 0x060085BD RID: 34237 RVA: 0x00377360 File Offset: 0x00375560
	public override TimeSpan ks()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x060085BE RID: 34238 RVA: 0x00377370 File Offset: 0x00375570
	public bool d()
	{
		return this.e;
	}

	// Token: 0x060085BF RID: 34239 RVA: 0x00377378 File Offset: 0x00375578
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060085C0 RID: 34240 RVA: 0x00377384 File Offset: 0x00375584
	public s5()
	{
	}

	// Token: 0x060085C1 RID: 34241 RVA: 0x003773A4 File Offset: 0x003755A4
	protected override bool b4(e6d A_0)
	{
		base.b4(A_0);
		this.c();
		return false;
	}

	// Token: 0x060085C2 RID: 34242 RVA: 0x003773B8 File Offset: 0x003755B8
	protected override bool aen(e6d A_0)
	{
		if (base.aen(A_0))
		{
			return true;
		}
		if (this.f == null || this.f.ao() == null)
		{
			this.c();
			return false;
		}
		dc4 dc = this.f.ao().x();
		if (dc == dc4.e)
		{
			this.b();
			return true;
		}
		return dc == dc4.c || dc == dc4.d;
	}

	// Token: 0x060085C3 RID: 34243 RVA: 0x0037742C File Offset: 0x0037562C
	protected override void kt(TimeSpan A_0)
	{
		base.kt(A_0);
	}

	// Token: 0x060085C4 RID: 34244 RVA: 0x00377438 File Offset: 0x00375638
	protected override void aep(e6d A_0)
	{
		if (this.f != null && this.f.ao() != null && this.f.ao().x() == dc4.b)
		{
			this.f.ao().j();
		}
		this.f = null;
	}

	// Token: 0x060085C5 RID: 34245 RVA: 0x00377490 File Offset: 0x00375690
	private void c()
	{
		this.f = null;
		if (this.g() == null || this.g().ao() == null || this.g().ao().j != cgy.b)
		{
			throw new Exception("Trekker entity was not found or was not alive.");
		}
		ale aspect = this.g().ao().GetAspect<ale>();
		if (aspect == null)
		{
			throw new Exception("Trekker entity did not have trekker aspect.");
		}
		if (this.f() == null)
		{
			throw new Exception("Destination was not set.");
		}
		aud aud;
		Vector3 vector;
		HorizontalDirection horizontalDirection;
		this.f().a(this.g().ao().Zone, out aud, out vector, out horizontalDirection);
		if (aud == null)
		{
			throw new Exception(string.Format("Area targeted by the spatial pointer not found ({0}).", this.f()));
		}
		ak1 ak = aud.b((int)vector.X, (int)vector.Y);
		if (ak == null)
		{
			throw new Exception(string.Format("Spatial pointer could not be mapped to a tile ({0}).", this.f()));
		}
		djk djk = aspect.a(ak, 0.0, 5, 500, true);
		djk.q(new EventHandler<EventArgs>(this.a));
		if (djk == null)
		{
			throw new Exception("Failed to create TrekToTileAction.");
		}
		this.f = new ActionReference<djk>(djk);
	}

	// Token: 0x060085C6 RID: 34246 RVA: 0x003775D0 File Offset: 0x003757D0
	private void a(object A_0, EventArgs A_1)
	{
		this.a();
	}

	// Token: 0x060085C7 RID: 34247 RVA: 0x003775DC File Offset: 0x003757DC
	private void b()
	{
		if (this.g() != null && this.g().ao() != null && this.g().ao().j == cgy.b)
		{
			aud aud;
			Vector3 a_;
			HorizontalDirection horizontalDirection;
			this.f().a(this.g().ao().Zone, out aud, out a_, out horizontalDirection);
			if (aud != null && aud != this.g().ao().Area)
			{
				this.g().ao().an();
				aud.a(this.g().ao());
				this.a(new ar7(this.g().ao()));
			}
			this.g().ao().Location = a_;
		}
	}

	// Token: 0x060085C8 RID: 34248 RVA: 0x003776A0 File Offset: 0x003758A0
	private void a()
	{
		if (this.e && this.g() != null && this.g().ao() != null)
		{
			aud aud;
			Vector3 vector;
			HorizontalDirection a_;
			this.f().a(this.g().ao().Zone, out aud, out vector, out a_);
			this.g().ao().VisualDirection = a_;
		}
	}

	// Token: 0x04003334 RID: 13108
	private ar7 a;

	// Token: 0x04003335 RID: 13109
	private bhp b = new bhp();

	// Token: 0x04003336 RID: 13110
	private bt4 c;

	// Token: 0x04003337 RID: 13111
	private new bhp d = new bhp();

	// Token: 0x04003338 RID: 13112
	private new bool e;

	// Token: 0x04003339 RID: 13113
	private new ActionReference<djk> f;
}
