using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x020001BA RID: 442
public abstract class dnn : euz, bkx, al8
{
	// Token: 0x06000CF8 RID: 3320 RVA: 0x00037EDC File Offset: 0x000360DC
	public float any()
	{
		return this.y;
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00037EE4 File Offset: 0x000360E4
	public aud anz()
	{
		return this.b;
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00037EF0 File Offset: 0x000360F0
	public void an0(aud A_0)
	{
		if (this.b != A_0)
		{
			object a_ = this.b;
			this.b = A_0;
			if (this.aa != null)
			{
				this.aa(this, new c1(a_, this.b));
			}
		}
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00037F3C File Offset: 0x0003613C
	public ak1 an1()
	{
		return this.t;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00037F48 File Offset: 0x00036148
	protected void c(ak1 A_0)
	{
		if (this.t != A_0)
		{
			if (this.t != null && this.ah != null)
			{
				this.ah(this, new afm(this.t));
			}
			if (A_0 != null && this.ag != null)
			{
				this.ag(this, new afm(A_0));
			}
		}
		this.t = A_0;
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00037FB8 File Offset: 0x000361B8
	public b0b an2()
	{
		return this.s;
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00037FC0 File Offset: 0x000361C0
	protected void b(b0b A_0)
	{
		if (this.s != A_0)
		{
			if (this.s != null && this.ac != null)
			{
				this.ac(this, new a3x(this.s));
			}
			if (A_0 != null && this.ab != null)
			{
				this.ab(this, new a3x(A_0));
			}
		}
		this.s = A_0;
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00038030 File Offset: 0x00036230
	public Vector2 an3()
	{
		return this.u;
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00038038 File Offset: 0x00036238
	public d33 m()
	{
		return this.a;
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00038040 File Offset: 0x00036240
	public void a(d33 A_0)
	{
		if (this.a != A_0)
		{
			object a_ = this.a;
			this.a = A_0;
			if (this.z != null)
			{
				this.z(this, new c1(a_, this.a));
			}
		}
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0003808C File Offset: 0x0003628C
	public bu7 n()
	{
		return this.k;
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00038094 File Offset: 0x00036294
	public void a(bu7 A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x000380A0 File Offset: 0x000362A0
	public Collection<dzt> an4()
	{
		return this.l;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x000380A8 File Offset: 0x000362A8
	public Collection<dzt> an5()
	{
		return this.m;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x000380B0 File Offset: 0x000362B0
	public Collection<dzt> an6()
	{
		return this.n;
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x000380B8 File Offset: 0x000362B8
	public Collection<dzt> k()
	{
		return this.o;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x000380C0 File Offset: 0x000362C0
	public Collection<cgr> an7()
	{
		return this.p;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x000380C8 File Offset: 0x000362C8
	public Collection<d6l> an8()
	{
		return this.q;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x000380D0 File Offset: 0x000362D0
	public Collection<azw> l()
	{
		return this.r;
	}

	// Token: 0x06000D0B RID: 3339
	public abstract bool vl();

	// Token: 0x06000D0C RID: 3340
	public abstract bool vm();

	// Token: 0x06000D0D RID: 3341
	public abstract bool vn();

	// Token: 0x06000D0E RID: 3342 RVA: 0x000380D8 File Offset: 0x000362D8
	public c5m an9()
	{
		return this.j;
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x000380E0 File Offset: 0x000362E0
	public void aoa(c5m A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x000380EC File Offset: 0x000362EC
	protected dnn(dbn A_0)
	{
		this.x = A_0;
		this.a();
		this.b();
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x000381A4 File Offset: 0x000363A4
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.z;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x000381DC File Offset: 0x000363DC
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.z;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00038214 File Offset: 0x00036414
	[CompilerGenerated]
	public void aob(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aa;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0003824C File Offset: 0x0003644C
	[CompilerGenerated]
	public void aoc(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aa;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00038284 File Offset: 0x00036484
	[CompilerGenerated]
	public void aod(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ab;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x000382BC File Offset: 0x000364BC
	[CompilerGenerated]
	public void aoe(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ab;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x000382F4 File Offset: 0x000364F4
	[CompilerGenerated]
	public void aof(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ac;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ac, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0003832C File Offset: 0x0003652C
	[CompilerGenerated]
	public void aog(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ac;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ac, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00038364 File Offset: 0x00036564
	[CompilerGenerated]
	public void aoh(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ad;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0003839C File Offset: 0x0003659C
	[CompilerGenerated]
	public void aoi(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ad;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x000383D4 File Offset: 0x000365D4
	[CompilerGenerated]
	public void aoj(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ae;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0003840C File Offset: 0x0003660C
	[CompilerGenerated]
	public void aok(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.ae;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00038444 File Offset: 0x00036644
	[CompilerGenerated]
	public void aol(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.af;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0003847C File Offset: 0x0003667C
	[CompilerGenerated]
	public void aom(EventHandler<a3x> A_0)
	{
		EventHandler<a3x> eventHandler = this.af;
		EventHandler<a3x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a3x> value = (EventHandler<a3x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a3x>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x000384B4 File Offset: 0x000366B4
	[CompilerGenerated]
	public void aon(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ag;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x000384EC File Offset: 0x000366EC
	[CompilerGenerated]
	public void aoo(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ag;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00038524 File Offset: 0x00036724
	[CompilerGenerated]
	public void aop(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ah;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0003855C File Offset: 0x0003675C
	[CompilerGenerated]
	public void aoq(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ah;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00038594 File Offset: 0x00036794
	[CompilerGenerated]
	public void aor(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ai;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x000385CC File Offset: 0x000367CC
	[CompilerGenerated]
	public void aos(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ai;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00038604 File Offset: 0x00036804
	[CompilerGenerated]
	public void aot(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.aj;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x0003863C File Offset: 0x0003683C
	[CompilerGenerated]
	public void aou(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.aj;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00038674 File Offset: 0x00036874
	[CompilerGenerated]
	public void aov(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ak;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x000386AC File Offset: 0x000368AC
	[CompilerGenerated]
	public void aow(EventHandler<afm> A_0)
	{
		EventHandler<afm> eventHandler = this.ak;
		EventHandler<afm> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<afm> value = (EventHandler<afm>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<afm>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x000386E4 File Offset: 0x000368E4
	protected virtual void vw(object A_0, c1 A_1)
	{
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x000386E8 File Offset: 0x000368E8
	protected virtual void vv(object A_0, c1 A_1)
	{
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x000386F0 File Offset: 0x000368F0
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		this.w[A_1.b()] = this.t;
		this.v[A_1.b()] = this.s;
		if (this.t != null && this.ai != null)
		{
			this.ai(this, new afm(this.t, A_1.b()));
		}
		if (this.s != null && this.ad != null)
		{
			this.ad(this, new a3x(this.s, A_1.b()));
		}
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x0003879C File Offset: 0x0003699C
	protected override void vu(object A_0, b25 A_1)
	{
		base.vu(A_0, A_1);
		if (this.t != null && this.aj != null)
		{
			this.aj(this, new afm(this.t, A_1.b()));
		}
		if (this.s != null && this.ae != null)
		{
			this.ae(this, new a3x(this.s, A_1.b()));
		}
		if (this.t != null && this.w[A_1.b()] == this.t && this.ak != null)
		{
			this.ak(this, new afm(this.t, A_1.b()));
		}
		if (this.s != null && this.v[A_1.b()] == this.s && this.af != null)
		{
			this.af(this, new a3x(this.s, A_1.b()));
		}
		this.w[A_1.b()] = null;
		this.v[A_1.b()] = null;
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000388DC File Offset: 0x00036ADC
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.vs();
		if (!euz.DesignMode)
		{
			this.d(A_0, A_1);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00038900 File Offset: 0x00036B00
	public virtual void d(e6d A_0, cp9 A_1)
	{
		if (this.i.a || this.c != null || this.h.a == edg.a)
		{
			this.a(A_0, A_1);
			if (this.k != null)
			{
				this.vo(A_0, A_1);
			}
			this.c(A_0, A_1);
			this.b(A_0, A_1);
		}
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00038964 File Offset: 0x00036B64
	public virtual void a(e6d A_0, cp9 A_1)
	{
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00038968 File Offset: 0x00036B68
	public virtual void vo(e6d A_0, cp9 A_1)
	{
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x0003896C File Offset: 0x00036B6C
	public virtual void c(e6d A_0, cp9 A_1)
	{
		foreach (azw azw in this.r)
		{
			azw.a(A_0, A_1, this);
		}
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x000389C4 File Offset: 0x00036BC4
	public virtual void b(e6d A_0, cp9 A_1)
	{
	}

	// Token: 0x06000D33 RID: 3379
	public abstract ICollection<b0b> vr(Point A_0);

	// Token: 0x06000D34 RID: 3380
	public abstract void vp(b0b A_0, e6d A_1, cp9 A_2, bool A_3);

	// Token: 0x06000D35 RID: 3381
	public abstract Vector2 vq(float A_0, float A_1, float A_2);

	// Token: 0x06000D36 RID: 3382 RVA: 0x000389C8 File Offset: 0x00036BC8
	public virtual void vs()
	{
		if (this.an9() != null)
		{
			this.y = this.an9().ua();
			return;
		}
		this.y = 1f;
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x000389F4 File Offset: 0x00036BF4
	private void b()
	{
		this.aob(new EventHandler<c1>(this.vv));
		this.a(new EventHandler<c1>(this.vw));
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00038A1C File Offset: 0x00036C1C
	private void a()
	{
		this.w = new Dictionary<eoo, ak1>();
		this.v = new Dictionary<eoo, b0b>();
		foreach (object obj in Enum.GetValues(typeof(eoo)))
		{
			eoo key = (eoo)obj;
			this.w[key] = null;
			this.v[key] = null;
		}
	}

	// Token: 0x040007AB RID: 1963
	private new d33 a;

	// Token: 0x040007AC RID: 1964
	private new aud b;

	// Token: 0x040007AD RID: 1965
	public new bag c;

	// Token: 0x040007AE RID: 1966
	public new dnx d = new dnx();

	// Token: 0x040007AF RID: 1967
	public new dwe e = new dwe();

	// Token: 0x040007B0 RID: 1968
	public new box f = new box();

	// Token: 0x040007B1 RID: 1969
	public new bof g = new bof();

	// Token: 0x040007B2 RID: 1970
	public bnd h = new bnd();

	// Token: 0x040007B3 RID: 1971
	public eqj i = new eqj();

	// Token: 0x040007B4 RID: 1972
	private new c5m j;

	// Token: 0x040007B5 RID: 1973
	protected new bu7 k;

	// Token: 0x040007B6 RID: 1974
	protected new Collection<dzt> l = new Collection<dzt>();

	// Token: 0x040007B7 RID: 1975
	protected new Collection<dzt> m = new Collection<dzt>();

	// Token: 0x040007B8 RID: 1976
	protected Collection<dzt> n = new Collection<dzt>();

	// Token: 0x040007B9 RID: 1977
	protected Collection<dzt> o = new Collection<dzt>();

	// Token: 0x040007BA RID: 1978
	protected Collection<cgr> p = new Collection<cgr>();

	// Token: 0x040007BB RID: 1979
	protected Collection<d6l> q = new Collection<d6l>();

	// Token: 0x040007BC RID: 1980
	protected Collection<azw> r = new Collection<azw>();

	// Token: 0x040007BD RID: 1981
	private b0b s;

	// Token: 0x040007BE RID: 1982
	private ak1 t;

	// Token: 0x040007BF RID: 1983
	protected Vector2 u;

	// Token: 0x040007C0 RID: 1984
	private Dictionary<eoo, b0b> v;

	// Token: 0x040007C1 RID: 1985
	private Dictionary<eoo, ak1> w;

	// Token: 0x040007C2 RID: 1986
	public dbn x;

	// Token: 0x040007C3 RID: 1987
	public float y;

	// Token: 0x040007C4 RID: 1988
	[CompilerGenerated]
	private EventHandler<c1> z;

	// Token: 0x040007C5 RID: 1989
	[CompilerGenerated]
	private EventHandler<c1> aa;

	// Token: 0x040007C6 RID: 1990
	[CompilerGenerated]
	private EventHandler<a3x> ab;

	// Token: 0x040007C7 RID: 1991
	[CompilerGenerated]
	private EventHandler<a3x> ac;

	// Token: 0x040007C8 RID: 1992
	[CompilerGenerated]
	private EventHandler<a3x> ad;

	// Token: 0x040007C9 RID: 1993
	[CompilerGenerated]
	private EventHandler<a3x> ae;

	// Token: 0x040007CA RID: 1994
	[CompilerGenerated]
	private new EventHandler<a3x> af;

	// Token: 0x040007CB RID: 1995
	[CompilerGenerated]
	private EventHandler<afm> ag;

	// Token: 0x040007CC RID: 1996
	[CompilerGenerated]
	private EventHandler<afm> ah;

	// Token: 0x040007CD RID: 1997
	[CompilerGenerated]
	private EventHandler<afm> ai;

	// Token: 0x040007CE RID: 1998
	[CompilerGenerated]
	private EventHandler<afm> aj;

	// Token: 0x040007CF RID: 1999
	[CompilerGenerated]
	private EventHandler<afm> ak;
}
