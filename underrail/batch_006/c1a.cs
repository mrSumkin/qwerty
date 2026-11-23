using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Ouroboros.Common.Data;

// Token: 0x02000253 RID: 595
[eiz("Z")]
[Serializable]
public class c1a : cae, dcm, ISerializable
{
	// Token: 0x0600110E RID: 4366 RVA: 0x000467E8 File Offset: 0x000449E8
	protected c1a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.e = (PropertyCollection)A_0.GetValue("Z:CP", typeof(PropertyCollection));
			di7.ReadList<aud>("Z:A", ref this.g, A_0);
			di7.ReadList<ego>("Z:SLE", ref this.h, A_0);
			di7.ReadList<ah7>("Z:LD", ref this.i, A_0);
			di7.ReadList<ev2>("Z:ED", ref this.j, A_0);
			this.k = (TimeSpan)A_0.GetValue("Z:EZT", typeof(TimeSpan));
			this.l = (ix)A_0.GetValue("Z:AM", typeof(ix));
			di7.ReadList<csd>("Z:W", ref this.m, A_0);
			return;
		}
		if (base.GetType() == typeof(c1a))
		{
			this.e = (PropertyCollection)A_0.GetValue("_CustomProperties", typeof(PropertyCollection));
			this.g = (List<aud>)A_0.GetValue("_Areas", typeof(List<aud>));
			this.h = (List<ego>)A_0.GetValue("_SoftLightEmitters", typeof(List<ego>));
			this.i = (List<ah7>)A_0.GetValue("_LanternDefinitions", typeof(List<ah7>));
			this.j = (List<ev2>)A_0.GetValue("_EyeDefinitions", typeof(List<ev2>));
			this.k = (TimeSpan)A_0.GetValue("_ElapsedZoneTime", typeof(TimeSpan));
			this.l = (ix)A_0.GetValue("_ActionManager", typeof(ix));
			this.m = (List<csd>)A_0.GetValue("_Waypoints", typeof(List<csd>));
			return;
		}
		this.e = (PropertyCollection)A_0.GetValue("Zone+_CustomProperties", typeof(PropertyCollection));
		this.g = (List<aud>)A_0.GetValue("Zone+_Areas", typeof(List<aud>));
		this.h = (List<ego>)A_0.GetValue("Zone+_SoftLightEmitters", typeof(List<ego>));
		this.i = (List<ah7>)A_0.GetValue("Zone+_LanternDefinitions", typeof(List<ah7>));
		this.j = (List<ev2>)A_0.GetValue("Zone+_EyeDefinitions", typeof(List<ev2>));
		this.k = (TimeSpan)A_0.GetValue("Zone+_ElapsedZoneTime", typeof(TimeSpan));
		this.l = (ix)A_0.GetValue("Zone+_ActionManager", typeof(ix));
		this.m = (List<csd>)A_0.GetValue("Zone+_Waypoints", typeof(List<csd>));
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00046B28 File Offset: 0x00044D28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Z:CP", this.e);
		di7.WriteList<aud>("Z:A", this.g, info);
		di7.WriteList<ego>("Z:SLE", this.h, info);
		di7.WriteList<ah7>("Z:LD", this.i, info);
		di7.WriteList<ev2>("Z:ED", this.j, info);
		info.AddValue("Z:EZT", this.k);
		info.AddValue("Z:AM", this.l);
		di7.WriteList<csd>("Z:W", this.m, info);
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00046BCC File Offset: 0x00044DCC
	public c1a(string A_0) : this(A_0, true)
	{
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00046BD8 File Offset: 0x00044DD8
	public c1a(string A_0, bool A_1) : base(Guid.NewGuid(), A_0)
	{
		this.a(A_1);
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00046C48 File Offset: 0x00044E48
	internal c1a(Guid A_0, string A_1) : base(A_0, A_1)
	{
		this.a(true);
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06001113 RID: 4371 RVA: 0x00046CB4 File Offset: 0x00044EB4
	// (set) Token: 0x06001114 RID: 4372 RVA: 0x00046CBC File Offset: 0x00044EBC
	[Browsable(false)]
	public e3h Playfield
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

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x00046CC8 File Offset: 0x00044EC8
	[Browsable(false)]
	public List<aud> Areas
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06001116 RID: 4374 RVA: 0x00046CD0 File Offset: 0x00044ED0
	[Browsable(false)]
	public ReadOnlyCollection<ego> SoftLightEmitters
	{
		get
		{
			return this.h.AsReadOnly();
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06001117 RID: 4375 RVA: 0x00046CE0 File Offset: 0x00044EE0
	[Browsable(false)]
	public ReadOnlyCollection<ah7> LanternDefinitions
	{
		get
		{
			return this.i.AsReadOnly();
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06001118 RID: 4376 RVA: 0x00046CF0 File Offset: 0x00044EF0
	// (set) Token: 0x06001119 RID: 4377 RVA: 0x00046CF8 File Offset: 0x00044EF8
	[Browsable(false)]
	public epb State
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

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x0600111A RID: 4378 RVA: 0x00046D04 File Offset: 0x00044F04
	// (set) Token: 0x0600111B RID: 4379 RVA: 0x00046D0C File Offset: 0x00044F0C
	[Category("Meta")]
	public TimeSpan ElapsedZoneTime
	{
		get
		{
			return this.k;
		}
		set
		{
			this.k = value;
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x0600111C RID: 4380 RVA: 0x00046D18 File Offset: 0x00044F18
	[Browsable(false)]
	public cix ActionManager
	{
		get
		{
			return this.l;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x0600111D RID: 4381 RVA: 0x00046D20 File Offset: 0x00044F20
	[Browsable(false)]
	public ReadOnlyCollection<csd> Waypoints
	{
		get
		{
			return this.m.AsReadOnly();
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00046D30 File Offset: 0x00044F30
	// (set) Token: 0x0600111F RID: 4383 RVA: 0x00046D50 File Offset: 0x00044F50
	public PropertyCollection CustomProperties
	{
		get
		{
			if (this.e == null)
			{
				this.e = new PropertyCollection();
			}
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00046D5C File Offset: 0x00044F5C
	[CompilerGenerated]
	public new void a(EventHandler<c4i> A_0)
	{
		EventHandler<c4i> eventHandler = this.p;
		EventHandler<c4i> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c4i> value = (EventHandler<c4i>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c4i>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00046D94 File Offset: 0x00044F94
	[CompilerGenerated]
	public new void b(EventHandler<c4i> A_0)
	{
		EventHandler<c4i> eventHandler = this.p;
		EventHandler<c4i> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c4i> value = (EventHandler<c4i>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c4i>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00046DCC File Offset: 0x00044FCC
	public new aud a(string A_0, esj A_1, Guid? A_2 = null, bool A_3 = true)
	{
		aud aud = new aud(A_0, A_1);
		if (A_2 != null)
		{
			aud.h(A_2.Value);
		}
		if (A_3)
		{
			this.c(aud);
		}
		return aud;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00046E0C File Offset: 0x0004500C
	public aud n(string A_0)
	{
		c1a.c c = new c1a.c();
		c.a = A_0;
		czh.a(c.a, "name");
		return Enumerable.FirstOrDefault<aud>(Enumerable.Where<aud>(this.g, new Func<aud, bool>(c.a)));
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00046E54 File Offset: 0x00045054
	public aud e(string A_0)
	{
		aud result;
		this.f.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00046E74 File Offset: 0x00045074
	public aud d(Guid A_0)
	{
		c1a.d d = new c1a.d();
		d.a = A_0;
		return Enumerable.FirstOrDefault<aud>(Enumerable.Where<aud>(this.g, new Func<aud, bool>(d.a)));
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00046EAC File Offset: 0x000450AC
	public new int b(aud A_0)
	{
		return this.g.IndexOf(A_0);
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00046EBC File Offset: 0x000450BC
	public new aud b(int A_0)
	{
		if (A_0 >= 0 && this.g.Count > A_0)
		{
			return this.g[A_0];
		}
		return null;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00046EE4 File Offset: 0x000450E4
	public aud c(string A_0)
	{
		czh.a(A_0, "name");
		aud aud = this.n(A_0);
		if (aud != null)
		{
			this.a(aud);
		}
		return aud;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00046F14 File Offset: 0x00045114
	public new bool a(aud A_0)
	{
		if (this.g.Remove(A_0))
		{
			A_0.Zone = null;
			if (A_0.y8() != null)
			{
				this.f.Remove(A_0.y8());
			}
			this.l();
			return true;
		}
		return false;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00046F60 File Offset: 0x00045160
	public ego f(string A_0)
	{
		czh.a(A_0, "name");
		ego ego = new ego(A_0);
		this.h.Add(ego);
		return ego;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00046F8C File Offset: 0x0004518C
	public new void b(ego A_0)
	{
		czh.a(A_0, "emitter");
		this.h.Add(A_0);
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00046FA8 File Offset: 0x000451A8
	public ego c(Guid A_0)
	{
		c1a.g g = new c1a.g();
		g.a = A_0;
		return Enumerable.FirstOrDefault<ego>(Enumerable.Where<ego>(this.h, new Func<ego, bool>(g.a)));
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00046FE0 File Offset: 0x000451E0
	public ego m(string A_0)
	{
		c1a.h h = new c1a.h();
		h.a = A_0;
		czh.a(h.a, "name");
		return Enumerable.FirstOrDefault<ego>(Enumerable.Where<ego>(this.h, new Func<ego, bool>(h.a)));
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00047028 File Offset: 0x00045228
	public new bool a(ego A_0)
	{
		czh.a(A_0, "emitter");
		return this.h.Remove(A_0);
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00047044 File Offset: 0x00045244
	public bool o(string A_0)
	{
		ego ego = this.m(A_0);
		return ego != null && this.a(ego);
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00047068 File Offset: 0x00045268
	public bool g(Guid A_0)
	{
		ego ego = this.c(A_0);
		return ego != null && this.a(ego);
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x0004708C File Offset: 0x0004528C
	public ah7 k(string A_0)
	{
		ah7 ah = new ah7(A_0, this);
		this.i.Add(ah);
		return ah;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x000470B0 File Offset: 0x000452B0
	public new ah7 a(Guid A_0)
	{
		c1a.a a = new c1a.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<ah7>(Enumerable.Where<ah7>(this.i, new Func<ah7, bool>(a.a)));
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x000470E8 File Offset: 0x000452E8
	public new void a(ah7 A_0)
	{
		czh.a(A_0, "lanternDefinition");
		A_0.Zone = this;
		this.i.Add(A_0);
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x0004710C File Offset: 0x0004530C
	public ah7 i(string A_0)
	{
		c1a.f f = new c1a.f();
		f.a = A_0;
		czh.a(f.a, "name");
		return Enumerable.FirstOrDefault<ah7>(Enumerable.Where<ah7>(this.i, new Func<ah7, bool>(f.a)));
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00047154 File Offset: 0x00045354
	public new bool b(ah7 A_0)
	{
		czh.a(A_0, "lanternDefinition");
		A_0.Zone = null;
		return this.i.Remove(A_0);
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00047178 File Offset: 0x00045378
	public bool d(string A_0)
	{
		ah7 ah = this.i(A_0);
		if (ah != null)
		{
			this.b(ah);
			return true;
		}
		return false;
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x000471A0 File Offset: 0x000453A0
	public new bool b(Guid A_0)
	{
		ah7 ah = this.a(A_0);
		if (ah != null)
		{
			this.b(ah);
			return true;
		}
		return false;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x000471C8 File Offset: 0x000453C8
	public ev2 l(string A_0)
	{
		czh.a(A_0, "name");
		ev2 ev = new ev2(A_0);
		this.j.Add(ev);
		return ev;
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x000471F4 File Offset: 0x000453F4
	public new bool a(ev2 A_0)
	{
		if (!this.j.Contains(A_0))
		{
			this.j.Add(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00047218 File Offset: 0x00045418
	public ev2 f(Guid A_0)
	{
		c1a.b b = new c1a.b();
		b.a = A_0;
		return Enumerable.FirstOrDefault<ev2>(Enumerable.Where<ev2>(this.j, new Func<ev2, bool>(b.a)));
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00047250 File Offset: 0x00045450
	public new ev2 b(string A_0)
	{
		c1a.e e = new c1a.e();
		e.a = A_0;
		czh.a(e.a, "name");
		return Enumerable.FirstOrDefault<ev2>(Enumerable.Where<ev2>(this.j, new Func<ev2, bool>(e.a)));
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00047298 File Offset: 0x00045498
	public new bool b(ev2 A_0)
	{
		czh.a(A_0, "eyeDefinition");
		return this.j.Remove(A_0);
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x000472B4 File Offset: 0x000454B4
	public bool j(string A_0)
	{
		ev2 ev = this.b(A_0);
		return ev != null && this.b(ev);
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x000472D8 File Offset: 0x000454D8
	public bool e(Guid A_0)
	{
		ev2 ev = this.f(A_0);
		return ev != null && this.b(ev);
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x000472FC File Offset: 0x000454FC
	public void p()
	{
		this.State = epb.b;
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00047308 File Offset: 0x00045508
	public void n()
	{
		this.State = epb.a;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00047314 File Offset: 0x00045514
	public Collection<b76> c()
	{
		return nf.a(this);
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00047320 File Offset: 0x00045520
	public new void a(string A_0, string A_1, Dictionary<int, qi> A_2, bool A_3, bool A_4, Dictionary<int, string> A_5 = null)
	{
		nf.a(this.d(), A_0, A_1, A_2, A_3, A_4, A_5);
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00047344 File Offset: 0x00045544
	public new void a(doq A_0, int A_1, tm A_2 = null)
	{
		czh.a(A_0, "zoneLayer");
		acu.a(A_0);
		nf.a(this, A_0, A_1, A_2);
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00047360 File Offset: 0x00045560
	public new doq a(int A_0)
	{
		return doq.a(this, A_0, false);
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x0004736C File Offset: 0x0004556C
	public new void a(csd A_0)
	{
		czh.a(A_0, "waypoint");
		if (!this.m.Contains(A_0))
		{
			A_0.Zone = this;
			this.m.Add(A_0);
			if (this.Initialized)
			{
				A_0.bc(true);
			}
		}
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x000473BC File Offset: 0x000455BC
	public bool h(string A_0)
	{
		c1a.i i = new c1a.i();
		i.a = A_0;
		czh.a(i.a, "waypointName");
		csd csd = Enumerable.FirstOrDefault<csd>(Enumerable.Where<csd>(this.m, new Func<csd, bool>(i.a)));
		return csd != null && this.b(csd);
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00047414 File Offset: 0x00045614
	public void l()
	{
		foreach (csd csd in this.m)
		{
			csd.e();
		}
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x0004746C File Offset: 0x0004566C
	public new bool b(csd A_0)
	{
		czh.a(A_0, "waypoint");
		if (this.m.Remove(A_0))
		{
			A_0.Zone = null;
			return true;
		}
		return false;
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00047494 File Offset: 0x00045694
	public csd g(string A_0)
	{
		c1a.j j = new c1a.j();
		j.a = A_0;
		czh.a(j.a, "waypointName");
		return Enumerable.FirstOrDefault<csd>(Enumerable.Where<csd>(this.m, new Func<csd, bool>(j.a)));
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x000474DC File Offset: 0x000456DC
	public void AttachAddon<T>(T addon) where T : class
	{
		this.n[typeof(T)] = addon;
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x000474FC File Offset: 0x000456FC
	public T GetAddon<T>() where T : class
	{
		object obj;
		this.n.TryGetValue(typeof(T), out obj);
		return obj as T;
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x0004752C File Offset: 0x0004572C
	public bool RemoveAddon<T>()
	{
		return this.n.Remove(typeof(T));
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00047544 File Offset: 0x00045744
	public void f()
	{
		this.n.Clear();
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00047554 File Offset: 0x00045754
	public void c(aud A_0)
	{
		czh.a(A_0, "area");
		A_0.Zone = this;
		this.g.Add(A_0);
		if (A_0.y8() != null)
		{
			this.f[A_0.y8()] = A_0;
		}
		this.l();
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x000475A4 File Offset: 0x000457A4
	private new void a(bool A_0)
	{
		this.l = new ix(this);
		if (A_0)
		{
			this.bc(true);
		}
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x000475C4 File Offset: 0x000457C4
	private new void a()
	{
		foreach (aud aud in this.g)
		{
			aud.b();
		}
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x0004761C File Offset: 0x0004581C
	internal new void a(e6d A_0)
	{
		foreach (aud aud in this.g)
		{
			aud.g();
		}
		if (this.c == epb.b)
		{
			TimeSpan timeSpan = A_0.a().ElapsedGameTime;
			if (this.o != null)
			{
				timeSpan = TimeSpan.FromMilliseconds(this.o(timeSpan.TotalMilliseconds));
			}
			this.k += timeSpan;
			if (this.l != null)
			{
				this.l.a(this.k, timeSpan);
			}
			if (this.p != null)
			{
				this.p(this, new c4i(timeSpan));
			}
		}
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x000476FC File Offset: 0x000458FC
	public void p(string A_0)
	{
		czh.a(A_0, "filePath");
		this.k();
		bool flag = this.bd(true);
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			eoq.SerializeToBinaryFileCompressed<c1a>(A_0, this, dds.a(), eh9.c, true);
			stopwatch.Stop();
			Trace.WriteLine("Serialization time: " + stopwatch.Elapsed.ToString());
		}
		finally
		{
			if (flag)
			{
				this.bc(true);
			}
		}
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00047790 File Offset: 0x00045990
	public new static c1a a(string A_0)
	{
		czh.a(A_0, "filePath");
		c1a c1a = eoq.DeserializeFromBinaryFileCompressed<c1a>(A_0, dds.a(), true);
		if (c1a != null)
		{
			c1a.a();
		}
		return c1a;
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x000477C4 File Offset: 0x000459C4
	public void k()
	{
		if (this.Playfield != null)
		{
			if (this.Playfield.LightProcessor != null)
			{
				this.Playfield.LightProcessor.a();
			}
			if (this.Playfield.SightProcessor != null)
			{
				this.Playfield.SightProcessor.a();
			}
			if (this.Playfield.PathProcessor != null)
			{
				this.Playfield.PathProcessor.a();
			}
		}
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x0004783C File Offset: 0x00045A3C
	public c1a d()
	{
		this.k();
		bool flag = this.bd(true);
		Stream stream = eoq.SerializeToBinary<c1a>(this, dds.a(), null, eh9.c, true, true);
		c1a result = null;
		try
		{
			result = eoq.DeserializeFromBinary<c1a>(stream, dds.a(), true, true);
		}
		finally
		{
			if (flag)
			{
				this.bc(true);
			}
		}
		return result;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x000478A0 File Offset: 0x00045AA0
	[OnDeserialized]
	private new void a(StreamingContext A_0)
	{
		this.n = new Dictionary<Type, object>();
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06001157 RID: 4439 RVA: 0x000478B0 File Offset: 0x00045AB0
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000478BC File Offset: 0x00045ABC
	public bool bc(bool A_0)
	{
		if (this.d || this.Playfield == null)
		{
			return false;
		}
		if (A_0)
		{
			this.l.bc(true);
			foreach (ah7 ah in this.i)
			{
				ah.bc(A_0);
			}
			this.f = new Dictionary<string, aud>();
			foreach (aud aud in this.g)
			{
				if (aud.y8() != null)
				{
					this.f[aud.y8()] = aud;
				}
			}
			foreach (aud aud2 in this.g)
			{
				aud2.bc(true);
			}
			foreach (csd csd in this.m)
			{
				csd.bc(true);
			}
		}
		this.d = true;
		return true;
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00047A40 File Offset: 0x00045C40
	public bool bd(bool A_0)
	{
		if (!this.d)
		{
			return false;
		}
		if (A_0)
		{
			this.l.bd(true);
			foreach (aud aud in this.g)
			{
				aud.bd(true);
			}
			foreach (ah7 ah in this.i)
			{
				ah.bd(A_0);
			}
			foreach (csd csd in this.m)
			{
				csd.bd(true);
			}
		}
		this.d = false;
		return true;
	}

	// Token: 0x040009BD RID: 2493
	public new const string a = "uz";

	// Token: 0x040009BE RID: 2494
	[NonSerialized]
	private new e3h b;

	// Token: 0x040009BF RID: 2495
	[NonSerialized]
	private epb c;

	// Token: 0x040009C0 RID: 2496
	[NonSerialized]
	private bool d;

	// Token: 0x040009C1 RID: 2497
	private PropertyCollection e;

	// Token: 0x040009C2 RID: 2498
	[NonSerialized]
	private Dictionary<string, aud> f = new Dictionary<string, aud>();

	// Token: 0x040009C3 RID: 2499
	private List<aud> g = new List<aud>();

	// Token: 0x040009C4 RID: 2500
	private List<ego> h = new List<ego>();

	// Token: 0x040009C5 RID: 2501
	private new List<ah7> i = new List<ah7>();

	// Token: 0x040009C6 RID: 2502
	private List<ev2> j = new List<ev2>();

	// Token: 0x040009C7 RID: 2503
	private TimeSpan k;

	// Token: 0x040009C8 RID: 2504
	private ix l;

	// Token: 0x040009C9 RID: 2505
	private List<csd> m = new List<csd>();

	// Token: 0x040009CA RID: 2506
	[NonSerialized]
	private Dictionary<Type, object> n = new Dictionary<Type, object>();

	// Token: 0x040009CB RID: 2507
	[NonSerialized]
	public Func<double, double> o;

	// Token: 0x040009CC RID: 2508
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler<c4i> p;

	// Token: 0x02000254 RID: 596
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x00047B58 File Offset: 0x00045D58
		internal bool a(aud A_0)
		{
			return A_0.y8() == this.a;
		}

		// Token: 0x040009CD RID: 2509
		public string a;
	}

	// Token: 0x02000255 RID: 597
	[CompilerGenerated]
	private sealed class d
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x00047B74 File Offset: 0x00045D74
		internal bool a(aud A_0)
		{
			return A_0.qe() == this.a;
		}

		// Token: 0x040009CE RID: 2510
		public Guid a;
	}

	// Token: 0x02000256 RID: 598
	[CompilerGenerated]
	private sealed class g
	{
		// Token: 0x0600115F RID: 4447 RVA: 0x00047B90 File Offset: 0x00045D90
		internal bool a(ego A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x040009CF RID: 2511
		public Guid a;
	}

	// Token: 0x02000257 RID: 599
	[CompilerGenerated]
	private sealed class h
	{
		// Token: 0x06001161 RID: 4449 RVA: 0x00047BAC File Offset: 0x00045DAC
		internal bool a(ego A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x040009D0 RID: 2512
		public string a;
	}

	// Token: 0x02000258 RID: 600
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x00047BC8 File Offset: 0x00045DC8
		internal bool a(ah7 A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x040009D1 RID: 2513
		public Guid a;
	}

	// Token: 0x02000259 RID: 601
	[CompilerGenerated]
	private sealed class f
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x00047BE4 File Offset: 0x00045DE4
		internal bool a(ah7 A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x040009D2 RID: 2514
		public string a;
	}

	// Token: 0x0200025A RID: 602
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00047C00 File Offset: 0x00045E00
		internal bool a(ev2 A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x040009D3 RID: 2515
		public Guid a;
	}

	// Token: 0x0200025B RID: 603
	[CompilerGenerated]
	private sealed class e
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x00047C1C File Offset: 0x00045E1C
		internal bool a(ev2 A_0)
		{
			return A_0.Name == this.a;
		}

		// Token: 0x040009D4 RID: 2516
		public string a;
	}

	// Token: 0x0200025C RID: 604
	[CompilerGenerated]
	private new sealed class i
	{
		// Token: 0x0600116B RID: 4459 RVA: 0x00047C38 File Offset: 0x00045E38
		internal bool a(csd A_0)
		{
			return A_0.Name.Equals(this.a);
		}

		// Token: 0x040009D5 RID: 2517
		public string a;
	}

	// Token: 0x0200025D RID: 605
	[CompilerGenerated]
	private sealed class j
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x00047C54 File Offset: 0x00045E54
		internal bool a(csd A_0)
		{
			return A_0.Name.Equals(this.a);
		}

		// Token: 0x040009D6 RID: 2518
		public string a;
	}
}
