using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x02001006 RID: 4102
[eiz("PPFI")]
[Serializable]
public class anp : ok, aue, ISerializable
{
	// Token: 0x06005455 RID: 21589 RVA: 0x002548C0 File Offset: 0x00252AC0
	protected anp(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Point)A_0.GetValue("PPFI:TN", typeof(Point));
			this.b = (aud)A_0.GetValue("PPFI:A", typeof(aud));
			this.c = A_0.GetSingle("PPFI:R");
			this.d = (float?)A_0.GetValue("PPFI:GI", typeof(float?));
			di7.ReadList<Point>("PPFI:IN", ref this.e, A_0);
			this.g = A_0.GetBoolean("PPFI:ATNP");
			this.h = A_0.GetInt64("PPFI:BTFM");
			this.j = A_0.GetInt64("PPFI:AV");
			if (ell.b() < 5)
			{
				this.m = (EventHandler<EventArgs>)A_0.GetValue("PPFI:F1", typeof(EventHandler<EventArgs>));
				return;
			}
			di7.ReadEvent<EventArgs>("PPFI:F1", ref this.m, A_0);
			if (ell.b() >= 10)
			{
				this.k = A_0.GetBoolean("PPFI:I");
			}
			if (ell.b() >= 12)
			{
				this.i = A_0.GetInt64("PPFI:BNM");
			}
			if (ell.b() >= 20)
			{
				this.l = A_0.GetValue("PPFI:T", typeof(object));
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(anp))
			{
				this.a = (Point)A_0.GetValue("_TargetNode", typeof(Point));
				this.b = (aud)A_0.GetValue("_Area", typeof(aud));
				this.c = A_0.GetSingle("_Range");
				this.d = (float?)A_0.GetValue("_GreaterIntersection", typeof(float?));
				this.e = (List<Point>)A_0.GetValue("_ImprintedNodes", typeof(List<Point>));
				this.g = A_0.GetBoolean("_ApplyToNonPenetrable");
				this.h = A_0.GetInt64("_BlockerTileFormationMask");
				this.j = A_0.GetInt64("_AdditionalVulnerables");
				this.m = (EventHandler<EventArgs>)A_0.GetValue("Finished", typeof(EventHandler<EventArgs>));
				return;
			}
			this.a = (Point)A_0.GetValue("PrecisePermissiveFieldImprint+_TargetNode", typeof(Point));
			this.b = (aud)A_0.GetValue("PrecisePermissiveFieldImprint+_Area", typeof(aud));
			this.c = A_0.GetSingle("PrecisePermissiveFieldImprint+_Range");
			this.d = (float?)A_0.GetValue("PrecisePermissiveFieldImprint+_GreaterIntersection", typeof(float?));
			this.e = (List<Point>)A_0.GetValue("PrecisePermissiveFieldImprint+_ImprintedNodes", typeof(List<Point>));
			this.g = A_0.GetBoolean("PrecisePermissiveFieldImprint+_ApplyToNonPenetrable");
			this.h = A_0.GetInt64("PrecisePermissiveFieldImprint+_BlockerTileFormationMask");
			this.j = A_0.GetInt64("PrecisePermissiveFieldImprint+_AdditionalVulnerables");
			this.m = (EventHandler<EventArgs>)A_0.GetValue("PrecisePermissiveFieldImprint+Finished", typeof(EventHandler<EventArgs>));
		}
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x00254C1C File Offset: 0x00252E1C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PPFI:TN", this.a);
		info.AddValue("PPFI:A", this.b);
		info.AddValue("PPFI:R", this.c);
		info.AddValue("PPFI:GI", this.d);
		di7.WriteList<Point>("PPFI:IN", this.e, info);
		info.AddValue("PPFI:ATNP", this.g);
		info.AddValue("PPFI:BTFM", this.h);
		info.AddValue("PPFI:AV", this.j);
		info.AddValue("PPFI:I", this.k);
		info.AddValue("PPFI:BNM", this.i);
		info.AddValue("PPFI:T", this.l);
		di7.WriteEvent<EventArgs>("PPFI:F1", this.m, info);
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x00254D00 File Offset: 0x00252F00
	public Point h()
	{
		return this.a;
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x00254D08 File Offset: 0x00252F08
	public float l()
	{
		return this.c;
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x00254D10 File Offset: 0x00252F10
	public List<Point> f()
	{
		return this.e;
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x00254D18 File Offset: 0x00252F18
	public float? b()
	{
		return this.d;
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x00254D20 File Offset: 0x00252F20
	public void a(float? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x00254D2C File Offset: 0x00252F2C
	public aud d()
	{
		return this.b;
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x00254D34 File Offset: 0x00252F34
	public void a(aud A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x00254D40 File Offset: 0x00252F40
	public bool c()
	{
		return this.g;
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x00254D48 File Offset: 0x00252F48
	public void c(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x00254D54 File Offset: 0x00252F54
	public long g()
	{
		return this.j;
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x00254D5C File Offset: 0x00252F5C
	public void a(long A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005462 RID: 21602 RVA: 0x00254D68 File Offset: 0x00252F68
	public bool e()
	{
		return this.k;
	}

	// Token: 0x06005463 RID: 21603 RVA: 0x00254D70 File Offset: 0x00252F70
	public void b(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06005464 RID: 21604 RVA: 0x00254D7C File Offset: 0x00252F7C
	public object a()
	{
		return this.l;
	}

	// Token: 0x06005465 RID: 21605 RVA: 0x00254D84 File Offset: 0x00252F84
	public void a(object A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06005466 RID: 21606 RVA: 0x00254D90 File Offset: 0x00252F90
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.m;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06005467 RID: 21607 RVA: 0x00254DC8 File Offset: 0x00252FC8
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.m;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06005468 RID: 21608 RVA: 0x00254E00 File Offset: 0x00253000
	public anp(Point A_0, aud A_1, float A_2, long A_3, bool A_4 = false, long A_5 = 0L)
	{
		czh.a(A_1, "area");
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.h = A_3;
		this.i = A_5;
		this.k = A_4;
		if (this.b.Zone == null || this.b.Zone.Playfield == null)
		{
			dux.a(LogSeverity.Error, "Eye imprint requires an area that has been deployed into a zone and the playfield.", new object[0]);
		}
	}

	// Token: 0x06005469 RID: 21609 RVA: 0x00254E88 File Offset: 0x00253088
	public void k()
	{
		this.a(true);
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x00254E94 File Offset: 0x00253094
	public void j()
	{
		this.a(false);
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x00254EA0 File Offset: 0x002530A0
	private void a(bool A_0)
	{
		this.e = new List<Point>();
		this.f = new dlx();
		this.f.a(a6h.a);
		this.f.a(this.b.Zone.Playfield.SightProcessor);
		this.f.a(new bbg());
		this.f.ag().a(this.c);
		this.f.ag().a(false);
		this.f.ag().a().Add(this);
		this.f.ag().c().Add(this);
		if (this.d != null)
		{
			this.f.a(this.d.Value);
		}
		this.f.aj(this.a);
		this.f.b(new EventHandler<EventArgs>(this.a));
		if (A_0)
		{
			this.f.al();
			return;
		}
		this.f.ak();
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x00254FC0 File Offset: 0x002531C0
	public void i()
	{
		if (this.f != null)
		{
			this.f.am();
		}
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x00254FD8 File Offset: 0x002531D8
	private void a(object A_0, EventArgs A_1)
	{
		if (this.m != null)
		{
			this.m(this, new EventArgs());
		}
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x00254FF8 File Offset: 0x002531F8
	public bool q8(anl A_0)
	{
		return this.g || this.a(A_0, true, false);
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x00255010 File Offset: 0x00253210
	public void q9(Point A_0, object A_1, float A_2)
	{
		if (A_2 == 1f)
		{
			this.e.Add(A_0);
		}
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x0025502C File Offset: 0x0025322C
	public bool ra(Point A_0, object A_1, float A_2)
	{
		return false;
	}

	// Token: 0x06005471 RID: 21617 RVA: 0x00255030 File Offset: 0x00253230
	public void rb(Point A_0, object A_1, float A_2)
	{
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x00255034 File Offset: 0x00253234
	public object rc(anl A_0)
	{
		return A_0.a();
	}

	// Token: 0x06005473 RID: 21619 RVA: 0x00255044 File Offset: 0x00253244
	public bool g5(anl A_0)
	{
		return this.a(A_0, true, true);
	}

	// Token: 0x06005474 RID: 21620 RVA: 0x00255054 File Offset: 0x00253254
	private bool a(anl A_0, bool A_1, bool A_2)
	{
		ak1 ak = this.b.b(A_0.d().X, A_0.d().Y);
		return ak != null && (((!ak.Formation.c(this.h) || ak.Formation.c(this.i)) ^ this.k) || (A_1 && ak.Formation.c(this.j) && (!A_2 || !ak.Formation.c(67108864L))));
	}

	// Token: 0x04002270 RID: 8816
	private Point a;

	// Token: 0x04002271 RID: 8817
	private aud b;

	// Token: 0x04002272 RID: 8818
	private float c;

	// Token: 0x04002273 RID: 8819
	private float? d;

	// Token: 0x04002274 RID: 8820
	private List<Point> e;

	// Token: 0x04002275 RID: 8821
	[NonSerialized]
	private dlx f;

	// Token: 0x04002276 RID: 8822
	private bool g = true;

	// Token: 0x04002277 RID: 8823
	private long h;

	// Token: 0x04002278 RID: 8824
	private long i;

	// Token: 0x04002279 RID: 8825
	private long j;

	// Token: 0x0400227A RID: 8826
	private bool k;

	// Token: 0x0400227B RID: 8827
	private object l;

	// Token: 0x0400227C RID: 8828
	[CompilerGenerated]
	private EventHandler<EventArgs> m;
}
