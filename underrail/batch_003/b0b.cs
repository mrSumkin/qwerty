using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Space;

// Token: 0x02000264 RID: 612
[eiz("E4")]
[Serializable]
public class b0b : cae, abi, dcm, bvq, cuw, ISerializable
{
	// Token: 0x06001194 RID: 4500 RVA: 0x0004878C File Offset: 0x0004698C
	protected b0b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("E4:L");
		this.h = A_0.GetInt32("E4:VP");
		this.d = (Vector3)A_0.GetValue("E4:L1", typeof(Vector3));
		this.e = (Vector3)A_0.GetValue("E4:S", typeof(Vector3));
		this.f = A_0.GetBoolean("E4:IF");
		this.g = A_0.GetBoolean("E4:IG");
		this.i = (HorizontalDirection)A_0.GetValue("E4:VD", typeof(HorizontalDirection));
		this.j = (cgy)A_0.GetValue("E4:S1", typeof(cgy));
		this.k = A_0.GetBoolean("E4:MFU");
		di7.ReadList<ak1>("E4:OT", ref this.l, A_0);
		this.m = (aud)A_0.GetValue("E4:A", typeof(aud));
		this.n = (bjp)A_0.GetValue("E4:TFM", typeof(bjp));
		di7.ReadList<ejt>("E4:RE", ref this.o, A_0);
		this.p = (Color)A_0.GetValue("E4:L2", typeof(Color));
		di7.ReadDictionary<byte, Color?>("E4:OHL", ref this.r, A_0);
		this.s = (ayb)A_0.GetValue("E4:O", typeof(ayb));
		this.t = (bjp)A_0.GetValue("E4:D", typeof(bjp));
		this.u = (bjp)A_0.GetValue("E4:GL", typeof(bjp));
		this.w = A_0.GetBoolean("E4:CT");
		if (ell.b() >= 5)
		{
			di7.ReadEvent<c1>("E4:LC", ref this.ae, A_0);
			di7.ReadEvent<c1>("E4:SC", ref this.af, A_0);
			di7.ReadEvent<c1>("E4:IFC", ref this.ag, A_0);
			di7.ReadEvent<c1>("E4:IGC", ref this.ah, A_0);
			di7.ReadEvent<EventArgs>("E4:D1", ref this.ai, A_0);
			di7.ReadEvent<EventArgs>("E4:D2", ref this.aj, A_0);
			di7.ReadEvent<EventArgs>("E4:U", ref this.ak, A_0);
			di7.ReadEvent<EventArgs>("E4:U1", ref this.al, A_0);
			di7.ReadEvent<EventArgs>("E4:D3", ref this.am, A_0);
			di7.ReadEvent<EventArgs>("E4:D4", ref this.an, A_0);
			di7.ReadEvent<c1>("E4:VDC", ref this.aq, A_0);
			if (ell.b() >= 18)
			{
				this.z = (A_0.GetValue("E4:F8", typeof(Vector2?)) as Vector2?);
				this.x = A_0.GetBoolean("E4:F9");
			}
			if (ell.b() >= 30)
			{
				this.y = A_0.GetBoolean("E4:AO");
			}
			if (ell.b() >= 31)
			{
				this.aa = A_0.GetBoolean("E4:X");
			}
		}
		else
		{
			this.ae = (EventHandler<c1>)A_0.GetValue("E4:LC", typeof(EventHandler<c1>));
			this.af = (EventHandler<c1>)A_0.GetValue("E4:SC", typeof(EventHandler<c1>));
			this.ag = (EventHandler<c1>)A_0.GetValue("E4:IFC", typeof(EventHandler<c1>));
			this.ah = (EventHandler<c1>)A_0.GetValue("E4:IGC", typeof(EventHandler<c1>));
			this.ai = (EventHandler<EventArgs>)A_0.GetValue("E4:D1", typeof(EventHandler<EventArgs>));
			this.aj = (EventHandler<EventArgs>)A_0.GetValue("E4:D2", typeof(EventHandler<EventArgs>));
			this.ak = (EventHandler<EventArgs>)A_0.GetValue("E4:U", typeof(EventHandler<EventArgs>));
			this.al = (EventHandler<EventArgs>)A_0.GetValue("E4:U1", typeof(EventHandler<EventArgs>));
			this.am = (EventHandler<EventArgs>)A_0.GetValue("E4:D3", typeof(EventHandler<EventArgs>));
			this.an = (EventHandler<EventArgs>)A_0.GetValue("E4:D4", typeof(EventHandler<EventArgs>));
			this.aq = (EventHandler<c1>)A_0.GetValue("E4:VDC", typeof(EventHandler<c1>));
		}
		if (ell.b() >= 2)
		{
			di7.ReadDataModelTypeKeyedDictionary<cn7>("E4:A1", ref this.v, A_0);
			return;
		}
		di7.ReadDictionary<Type, cn7>("E4:A1", ref this.v, A_0);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00048C9C File Offset: 0x00046E9C
	public virtual void ajo()
	{
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00048CA0 File Offset: 0x00046EA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("E4:L", this.b);
		info.AddValue("E4:L1", this.d);
		info.AddValue("E4:S", this.e);
		info.AddValue("E4:IF", this.f);
		info.AddValue("E4:IG", this.g);
		info.AddValue("E4:VP", this.h);
		info.AddValue("E4:VD", this.i);
		info.AddValue("E4:S1", this.j);
		info.AddValue("E4:MFU", this.k);
		di7.WriteList<ak1>("E4:OT", this.l, info);
		info.AddValue("E4:A", this.m);
		info.AddValue("E4:TFM", this.n);
		di7.WriteList<ejt>("E4:RE", this.o, info);
		info.AddValue("E4:L2", this.p);
		di7.WriteDictionary<byte, Color?>("E4:OHL", this.r, info);
		info.AddValue("E4:O", this.s);
		info.AddValue("E4:D", this.t);
		info.AddValue("E4:GL", this.u);
		info.AddValue("E4:CT", this.w);
		info.AddValue("E4:F8", this.z);
		info.AddValue("E4:F9", this.x);
		info.AddValue("E4:AO", this.y);
		di7.WriteEvent<c1>("E4:LC", this.ae, info);
		di7.WriteEvent<c1>("E4:SC", this.af, info);
		di7.WriteEvent<c1>("E4:IFC", this.ag, info);
		di7.WriteEvent<c1>("E4:IGC", this.ah, info);
		di7.WriteEvent<EventArgs>("E4:D1", this.ai, info);
		di7.WriteEvent<EventArgs>("E4:D2", this.aj, info);
		di7.WriteEvent<EventArgs>("E4:U", this.ak, info);
		di7.WriteEvent<EventArgs>("E4:U1", this.al, info);
		di7.WriteEvent<EventArgs>("E4:D3", this.am, info);
		di7.WriteEvent<EventArgs>("E4:D4", this.an, info);
		di7.WriteEvent<c1>("E4:VDC", this.aq, info);
		di7.WriteDataModelTypeKeyedDictionary<cn7>("E4:A1", this.v, info);
		info.AddValue("E4:X", this.aa);
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06001197 RID: 4503 RVA: 0x00048F28 File Offset: 0x00047128
	// (set) Token: 0x06001198 RID: 4504 RVA: 0x00048F30 File Offset: 0x00047130
	[Category("Meta")]
	public int Layer
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

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06001199 RID: 4505 RVA: 0x00048F3C File Offset: 0x0004713C
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x0600119A RID: 4506 RVA: 0x00048F44 File Offset: 0x00047144
	// (set) Token: 0x0600119B RID: 4507 RVA: 0x00048F50 File Offset: 0x00047150
	[Category("Spatial")]
	public Vector3 Location
	{
		get
		{
			return this.d;
		}
		set
		{
			Vector3 vector = this.d;
			this.d = value;
			if (vector != value && this.ae != null)
			{
				this.ae(this, new c1(vector, value));
			}
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x0600119C RID: 4508 RVA: 0x00048FA0 File Offset: 0x000471A0
	// (set) Token: 0x0600119D RID: 4509 RVA: 0x00048FAC File Offset: 0x000471AC
	[Category("Spatial")]
	public Vector3 Size
	{
		get
		{
			return this.e;
		}
		set
		{
			Vector3 vector = this.e;
			this.e = value;
			if (vector != value && this.af != null)
			{
				this.af(this, new c1(vector, value));
			}
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x0600119E RID: 4510 RVA: 0x00048FFC File Offset: 0x000471FC
	// (set) Token: 0x0600119F RID: 4511 RVA: 0x00049008 File Offset: 0x00047208
	[Category("Spatial")]
	public bool IsFloor
	{
		get
		{
			return this.f;
		}
		set
		{
			bool flag = this.f;
			this.f = value;
			if (flag != value && this.ag != null)
			{
				this.ag(this, new c1(flag, value));
			}
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00049054 File Offset: 0x00047254
	// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00049060 File Offset: 0x00047260
	[Category("Spatial")]
	public bool IsGround
	{
		get
		{
			return this.g;
		}
		set
		{
			bool flag = this.f;
			this.g = value;
			if (flag != value && this.ah != null)
			{
				this.ah(this, new c1(flag, value));
			}
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000490AC File Offset: 0x000472AC
	// (set) Token: 0x060011A3 RID: 4515 RVA: 0x000490B4 File Offset: 0x000472B4
	[Category("Spatial")]
	public int VisualPriority
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000490C0 File Offset: 0x000472C0
	// (set) Token: 0x060011A5 RID: 4517 RVA: 0x000490CC File Offset: 0x000472CC
	[Category("Spatial")]
	public HorizontalDirection VisualDirection
	{
		get
		{
			return this.i;
		}
		set
		{
			if (value != this.i)
			{
				object a_ = this.i;
				this.i = value;
				if (this.aq != null)
				{
					this.aq(this, new c1(a_, value));
				}
			}
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0004911C File Offset: 0x0004731C
	// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00049124 File Offset: 0x00047324
	[Browsable(false)]
	public aud Area
	{
		get
		{
			return this.m;
		}
		internal set
		{
			this.m = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00049130 File Offset: 0x00047330
	[Browsable(false)]
	public c1a Zone
	{
		get
		{
			if (this.m == null)
			{
				return null;
			}
			return this.m.Zone;
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0004914C File Offset: 0x0004734C
	[Browsable(false)]
	public e3h Playfield
	{
		get
		{
			if (this.Zone == null)
			{
				return null;
			}
			return this.Zone.Playfield;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060011AA RID: 4522 RVA: 0x00049168 File Offset: 0x00047368
	[Browsable(false)]
	public etb Schema
	{
		get
		{
			if (this.m != null && this.m.Zone != null && this.m.Zone.Playfield != null)
			{
				return this.m.Zone.Playfield.Schema;
			}
			return null;
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060011AB RID: 4523 RVA: 0x000491BC File Offset: 0x000473BC
	// (set) Token: 0x060011AC RID: 4524 RVA: 0x000491C4 File Offset: 0x000473C4
	[Category("Behavior")]
	public bjp TileFormationModifiers
	{
		get
		{
			return this.n;
		}
		set
		{
			this.n = value;
			this.z();
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060011AD RID: 4525 RVA: 0x000491D4 File Offset: 0x000473D4
	[Browsable(false)]
	public List<ejt> RaysEmitters
	{
		get
		{
			return this.o;
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060011AE RID: 4526 RVA: 0x000491DC File Offset: 0x000473DC
	[Category("Appearance")]
	[ReadOnly(true)]
	public Color Lightning
	{
		get
		{
			return this.ap();
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060011AF RID: 4527 RVA: 0x000491E4 File Offset: 0x000473E4
	[ReadOnly(true)]
	[Category("Meta")]
	public virtual bool Ghostable
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060011B0 RID: 4528 RVA: 0x000491E8 File Offset: 0x000473E8
	[Browsable(false)]
	public IEnumerable<cn7> Aspects
	{
		get
		{
			return this.v.Values;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000491F8 File Offset: 0x000473F8
	// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00049200 File Offset: 0x00047400
	[Category("Behavior")]
	public bool CanTrigger
	{
		get
		{
			return this.w;
		}
		set
		{
			this.w = value;
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0004920C File Offset: 0x0004740C
	public Dictionary<Type, cn7> AspectsWithFacade
	{
		get
		{
			return this.v;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00049214 File Offset: 0x00047414
	// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0004921C File Offset: 0x0004741C
	[DisplayName("DesignOnly")]
	public bool DesignOnlyEditable
	{
		get
		{
			return this.aa;
		}
		set
		{
			this.aa = value;
		}
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00049228 File Offset: 0x00047428
	public b0b(Guid A_0, string A_1) : base(A_0, A_1)
	{
		this.f();
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00049290 File Offset: 0x00047490
	public b0b(string A_0) : this(Guid.NewGuid(), A_0)
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x000492A0 File Offset: 0x000474A0
	public b0b() : this(null)
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x000492AC File Offset: 0x000474AC
	[CompilerGenerated]
	public void k(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ae;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x000492E4 File Offset: 0x000474E4
	[CompilerGenerated]
	public void f(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ae;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x0004931C File Offset: 0x0004751C
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.af;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00049354 File Offset: 0x00047554
	[CompilerGenerated]
	public void l(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.af;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x0004938C File Offset: 0x0004758C
	[CompilerGenerated]
	public void j(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ag;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x000493C4 File Offset: 0x000475C4
	[CompilerGenerated]
	public void e(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ag;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x000493FC File Offset: 0x000475FC
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00049434 File Offset: 0x00047634
	[CompilerGenerated]
	public void i(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x0004946C File Offset: 0x0004766C
	[CompilerGenerated]
	public void c(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ai;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x000494A4 File Offset: 0x000476A4
	[CompilerGenerated]
	public void d(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ai;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x000494DC File Offset: 0x000476DC
	[CompilerGenerated]
	public void g(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.aj;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00049514 File Offset: 0x00047714
	[CompilerGenerated]
	public void h(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.aj;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x0004954C File Offset: 0x0004774C
	[CompilerGenerated]
	public new void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ak;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00049584 File Offset: 0x00047784
	[CompilerGenerated]
	public void l(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.ak;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x000495BC File Offset: 0x000477BC
	[CompilerGenerated]
	public void e(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.al;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x000495F4 File Offset: 0x000477F4
	[CompilerGenerated]
	public void i(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.al;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x0004962C File Offset: 0x0004782C
	[CompilerGenerated]
	public new void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.am;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00049664 File Offset: 0x00047864
	[CompilerGenerated]
	public void k(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.am;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x0004969C File Offset: 0x0004789C
	[CompilerGenerated]
	public void f(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.an;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x000496D4 File Offset: 0x000478D4
	[CompilerGenerated]
	public void j(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.an;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x0004970C File Offset: 0x0004790C
	[CompilerGenerated]
	public void act(EventHandler<bdu> A_0)
	{
		EventHandler<bdu> eventHandler = this.ao;
		EventHandler<bdu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bdu> value = (EventHandler<bdu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<bdu>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00049744 File Offset: 0x00047944
	[CompilerGenerated]
	public void acu(EventHandler<bdu> A_0)
	{
		EventHandler<bdu> eventHandler = this.ao;
		EventHandler<bdu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bdu> value = (EventHandler<bdu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<bdu>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x0004977C File Offset: 0x0004797C
	[CompilerGenerated]
	public void acv(EventHandler<bdu> A_0)
	{
		EventHandler<bdu> eventHandler = this.ap;
		EventHandler<bdu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bdu> value = (EventHandler<bdu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<bdu>>(ref this.ap, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x000497B4 File Offset: 0x000479B4
	[CompilerGenerated]
	public void acw(EventHandler<bdu> A_0)
	{
		EventHandler<bdu> eventHandler = this.ap;
		EventHandler<bdu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<bdu> value = (EventHandler<bdu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<bdu>>(ref this.ap, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x000497EC File Offset: 0x000479EC
	[CompilerGenerated]
	public void g(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aq;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aq, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00049824 File Offset: 0x00047A24
	[CompilerGenerated]
	public void h(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aq;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aq, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x0004985C File Offset: 0x00047A5C
	[dcc("E4:mOD1")]
	protected virtual void ajb(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00049860 File Offset: 0x00047A60
	[dcc("E4:mOD2")]
	protected virtual void c(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00049864 File Offset: 0x00047A64
	[dcc("E4:mOU")]
	protected virtual void ajc(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00049868 File Offset: 0x00047A68
	[dcc("E4:mOU1")]
	protected virtual void ajd(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x0004986C File Offset: 0x00047A6C
	[dcc("E4:mOD3")]
	protected virtual void d(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00049870 File Offset: 0x00047A70
	[dcc("E4:mOD4")]
	protected new virtual void b(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00049874 File Offset: 0x00047A74
	[dcc("E4:mOVDC")]
	protected virtual void ajn(object A_0, c1 A_1)
	{
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00049878 File Offset: 0x00047A78
	public cgy an()
	{
		cgy result = this.j;
		aud a_ = this.Area;
		bool flag = this.j != cgy.c;
		if (flag)
		{
			this.b();
		}
		this.b(this.Area);
		this.bd(true);
		if (this.Area != null)
		{
			this.Area.c(this);
			this.Area = null;
		}
		this.j = cgy.a;
		this.a(false);
		if (flag)
		{
			this.a();
		}
		this.a(a_);
		return result;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x000498FC File Offset: 0x00047AFC
	public void al()
	{
		this.j = cgy.a;
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00049908 File Offset: 0x00047B08
	public virtual void ah()
	{
		if (this.j == cgy.b)
		{
			this.a(false);
			this.e();
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00049924 File Offset: 0x00047B24
	public virtual void t()
	{
		this.a(false);
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00049930 File Offset: 0x00047B30
	public Vector3 aj()
	{
		return this.Location + this.Size / 2f;
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00049950 File Offset: 0x00047B50
	public Vector2 s()
	{
		if (this.z != null)
		{
			return this.Location.b() + this.z.Value / 2f;
		}
		return this.aj().b();
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x000499A0 File Offset: 0x00047BA0
	public void z()
	{
		foreach (ak1 ak in this.l)
		{
			ak.i(this);
		}
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x000499F8 File Offset: 0x00047BF8
	public bjp ae()
	{
		if (this.j == cgy.b)
		{
			return this.n;
		}
		return bjp.a();
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00049A14 File Offset: 0x00047C14
	public new void a(e3h A_0, out Point A_1, out Point A_2)
	{
		float num = A_0.Schema.a().b();
		bool flag = this.Location.X % 1f > 1f - num;
		bool flag2 = this.Location.Y % 1f > 1f - num;
		A_1 = new Point(flag ? ((int)(this.Location.X + 1f)) : ((int)this.Location.X), flag2 ? ((int)(this.Location.Y + 1f)) : ((int)this.Location.Y));
		float num2 = this.Location.X + this.Size.X;
		float num3 = this.Location.Y + this.Size.Y;
		bool flag3 = num2 % 1f < num;
		bool flag4 = num3 % 1f < num;
		A_2 = new Point(flag3 ? ((int)num2 - 1) : ((int)num2), flag4 ? ((int)num3 - 1) : ((int)num3));
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00049B40 File Offset: 0x00047D40
	public new void a(out Point A_0, out Point A_1)
	{
		this.a(this.Playfield, out A_0, out A_1);
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00049B50 File Offset: 0x00047D50
	public new void b(out Point A_0, out Point A_1)
	{
		Vector2 vector;
		if (this.z != null)
		{
			vector = this.z.Value;
		}
		else
		{
			vector = this.Size.b();
		}
		A_0 = new Point((int)(this.d.X * 4f), (int)(this.d.Y * 4f));
		A_1 = new Point((int)Math.Ceiling((double)((this.d.X + vector.X) * 4f)) - 1, (int)Math.Ceiling((double)((this.d.Y + vector.Y) * 4f)) - 1);
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00049C08 File Offset: 0x00047E08
	public new void a(out Point A_0, out Point A_1, Vector3 A_2)
	{
		Vector2 vector;
		if (this.z != null)
		{
			vector = this.z.Value;
		}
		else
		{
			vector = this.Size.b();
		}
		A_0 = new Point((int)(A_2.X * 4f), (int)(A_2.Y * 4f));
		A_1 = new Point((int)Math.Ceiling((double)((A_2.X + vector.X) * 4f)) - 1, (int)Math.Ceiling((double)((A_2.Y + vector.Y) * 4f)) - 1);
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00049CAC File Offset: 0x00047EAC
	public virtual void aji()
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00049CB0 File Offset: 0x00047EB0
	public virtual void ajj()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00049CB4 File Offset: 0x00047EB4
	public virtual void ajm(b0b A_0)
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00049CB8 File Offset: 0x00047EB8
	public virtual void ajh()
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00049CBC File Offset: 0x00047EBC
	public virtual void ajk(float A_0)
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00049CC0 File Offset: 0x00047EC0
	public virtual float? ajl()
	{
		return null;
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00049CD8 File Offset: 0x00047ED8
	public new void b(ejt A_0)
	{
		if (!this.o.Contains(A_0))
		{
			this.ab = true;
			this.a(A_0);
			this.o.Add(A_0);
		}
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00049D08 File Offset: 0x00047F08
	public void c(ejt A_0)
	{
		if (this.o.Contains(A_0))
		{
			this.o.Remove(A_0);
		}
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00049D28 File Offset: 0x00047F28
	public bool c(long A_0)
	{
		return this.s.b(A_0);
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00049D38 File Offset: 0x00047F38
	public new bool b(long A_0)
	{
		return this.t.b(A_0);
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00049D48 File Offset: 0x00047F48
	public new bool a(long A_0)
	{
		return this.u.b(A_0);
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00049D5C File Offset: 0x00047F5C
	public new Color a(bag A_0)
	{
		Color? color;
		this.r.TryGetValue(A_0.c, out color);
		if (color != null)
		{
			return color.Value;
		}
		return this.Lightning;
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00049D98 File Offset: 0x00047F98
	public bool bc(bool A_0)
	{
		if (this.c)
		{
			return false;
		}
		this.ab = false;
		int num = 0;
		if (A_0)
		{
			this.g();
			num = this.o.Count;
		}
		this.ai9(A_0);
		if ((A_0 && num != this.o.Count) || this.ab)
		{
			this.g();
		}
		this.c = true;
		return true;
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00049E0C File Offset: 0x0004800C
	public bool bd(bool A_0)
	{
		if (!this.c)
		{
			return false;
		}
		this.aja(A_0);
		if (A_0)
		{
			foreach (u u in Enumerable.OfType<u>(this.o))
			{
				u.bd(true);
			}
		}
		this.c = false;
		return true;
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00049E88 File Offset: 0x00048088
	public T GetAspect<T>() where T : cn7
	{
		cn7 cn;
		this.v.TryGetValue(typeof(T), out cn);
		return cn as T;
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00049EB8 File Offset: 0x000480B8
	public cn7 acx(Type A_0)
	{
		czh.a(A_0, "aspectType");
		cn7 result;
		this.v.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00049EE0 File Offset: 0x000480E0
	public new cn7 b(string A_0)
	{
		foreach (KeyValuePair<Type, cn7> keyValuePair in this.v)
		{
			if (keyValuePair.Key.Name == A_0)
			{
				return keyValuePair.Value;
			}
		}
		return null;
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00049F5C File Offset: 0x0004815C
	public void SetAspect<T>(T aspect) where T : cn7
	{
		czh.a(aspect, "aspect");
		this.v[typeof(T)] = aspect;
		this.a(aspect);
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00049F98 File Offset: 0x00048198
	public void acy(cn7 A_0)
	{
		czh.a(A_0, "aspect");
		this.v[A_0.GetType()] = A_0;
		this.a(A_0);
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00049FC0 File Offset: 0x000481C0
	public void acz(cn7 A_0, Type A_1)
	{
		czh.a(A_0, "aspect");
		czh.a(A_1, "aspectType");
		this.v[A_1] = A_0;
		this.a(A_0);
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00049FEC File Offset: 0x000481EC
	public bool RemoveAspect<T>()
	{
		return this.ac0(typeof(T));
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x0004A004 File Offset: 0x00048204
	public bool ac0(Type A_0)
	{
		czh.a(A_0, "aspectType");
		cn7 cn = this.acx(A_0);
		if (cn != null)
		{
			this.v.Remove(A_0);
			this.b(cn);
			return true;
		}
		return false;
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x0004A044 File Offset: 0x00048244
	public void ac1()
	{
		foreach (Type key in Enumerable.ToList<Type>(this.v.Keys))
		{
			cn7 a_ = this.v[key];
			this.v.Remove(key);
			this.b(a_);
		}
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x0004A0C4 File Offset: 0x000482C4
	public override string ToString()
	{
		return string.Format("Id: {0}. Name: '{1}'.", base.qe(), base.y8());
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x0004A0E4 File Offset: 0x000482E4
	public void aq()
	{
		this.m = null;
		this.l.Clear();
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x0004A0F8 File Offset: 0x000482F8
	public void y()
	{
		this.ai8();
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x0004A100 File Offset: 0x00048300
	public new void a(byte A_0)
	{
		this.t.s3(A_0);
		if (this.j == cgy.c)
		{
			this.u.s4(A_0);
			this.c();
		}
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x0004A130 File Offset: 0x00048330
	public void @as()
	{
		if (this.l != null)
		{
			foreach (ak1 ak in this.l)
			{
				ak.k(this);
			}
		}
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x0004A194 File Offset: 0x00048394
	public void v()
	{
		foreach (cn7 cn in this.v.Values)
		{
			dqh dqh = cn as dqh;
			if (dqh != null)
			{
				dqh.aip();
			}
		}
		foreach (ejt ejt in this.o)
		{
			ejt.a(Guid.NewGuid());
		}
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x0004A248 File Offset: 0x00048448
	internal new void a(aud A_0, bool A_1)
	{
		if (!A_1)
		{
			this.j = cgy.b;
		}
		this.d(A_0);
		this.m = A_0;
		this.k = false;
		this.a(true);
		if (A_0.Initialized)
		{
			this.bc(true);
		}
		this.c(A_0);
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x0004A298 File Offset: 0x00048498
	internal void f(aud A_0)
	{
		this.ac = -1f;
		this.ad = -1f;
		this.a(A_0, false);
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0004A2B8 File Offset: 0x000484B8
	internal new void b(byte A_0)
	{
		this.s.s3(A_0);
		this.a(A_0);
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x0004A2D0 File Offset: 0x000484D0
	internal new void a(IEnumerable<byte> A_0)
	{
		this.s.c(A_0);
		this.t.c(A_0);
		if (this.j == cgy.c)
		{
			this.u.b(A_0);
			this.c();
		}
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x0004A308 File Offset: 0x00048508
	internal void c(byte A_0)
	{
		this.s.s4(A_0);
		this.r[A_0] = new Color?(this.Lightning);
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x0004A330 File Offset: 0x00048530
	internal new void b(IEnumerable<byte> A_0)
	{
		foreach (byte a_ in A_0)
		{
			this.c(a_);
		}
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x0004A384 File Offset: 0x00048584
	protected virtual void ai8()
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x0004A388 File Offset: 0x00048588
	protected virtual void ai9(bool A_0)
	{
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x0004A38C File Offset: 0x0004858C
	protected virtual void aja(bool A_0)
	{
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x0004A390 File Offset: 0x00048590
	protected virtual void aje(cn7 A_0)
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x0004A394 File Offset: 0x00048594
	protected virtual void ajf(cn7 A_0)
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x0004A398 File Offset: 0x00048598
	protected new virtual void a(Color A_0)
	{
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x0004A39C File Offset: 0x0004859C
	private void g()
	{
		if (this.o.Count > 0)
		{
			Vector3 a_ = this.aj();
			foreach (u u in Enumerable.OfType<u>(this.o))
			{
				u.Location = a_;
				u.bc(true);
			}
		}
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x0004A418 File Offset: 0x00048618
	private void f()
	{
		this.c(new EventHandler<EventArgs>(this.c));
		this.g(new EventHandler<EventArgs>(this.ajb));
		this.a(new EventHandler<EventArgs>(this.ajd));
		this.e(new EventHandler<EventArgs>(this.ajc));
		this.b(new EventHandler<EventArgs>(this.d));
		this.f(new EventHandler<EventArgs>(this.b));
		this.g(new EventHandler<c1>(this.ajn));
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x0004A4AC File Offset: 0x000486AC
	private new void a(ejt A_0)
	{
		A_0.Location = this.aj();
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x0004A4BC File Offset: 0x000486BC
	private void e()
	{
		Vector3 a_ = this.aj();
		foreach (ejt ejt in this.o)
		{
			ejt.Location = a_;
			ejt.ii(false);
		}
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x0004A524 File Offset: 0x00048724
	public void w()
	{
		for (int i = this.o.Count - 1; i >= 0; i--)
		{
			this.o[i].ig();
		}
		this.o.Clear();
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x0004A568 File Offset: 0x00048768
	public Color ap()
	{
		if (this.aa)
		{
			return Color.White;
		}
		if (!this.q)
		{
			this.p = this.ajg();
			this.q = true;
			this.a(this.p);
		}
		return this.p;
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x0004A5B8 File Offset: 0x000487B8
	protected virtual Color ajg()
	{
		etd a_ = default(etd);
		foreach (ak1 ak in this.l)
		{
			a_ = etd.a(a_, ak.Lightning);
		}
		return etd.a(a_, (double)((this.l.Count == 0) ? 1 : this.l.Count)).c();
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x0004A650 File Offset: 0x00048850
	[dcc("E4:mOTLC")]
	private new void a(object A_0, EventArgs A_1)
	{
		this.d();
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x0004A658 File Offset: 0x00048858
	private void d()
	{
		this.q = false;
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x0004A664 File Offset: 0x00048864
	private new void a(bool A_0 = false)
	{
		this.a(null, A_0);
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x0004A670 File Offset: 0x00048870
	private new void a(CollectionDelta<ak1> A_0, bool A_1 = false)
	{
		HashSet<ak1> hashSet = new HashSet<ak1>();
		foreach (ak1 ak in this.l)
		{
			hashSet.Add(ak);
		}
		CollectionDelta<ak1> collectionDelta = A_0;
		if (collectionDelta == null)
		{
			collectionDelta = bnx.a(this, this.Schema, this.Area, this.l, this.Location, this.Size);
		}
		if (!collectionDelta.a())
		{
			foreach (ak1 ak2 in collectionDelta.b)
			{
				ak2.j(this);
				ak2.b(new EventHandler<EventArgs>(this.a));
				this.l.Add(ak2);
				if (A_1)
				{
					if (this.Zone == null || !this.CanTrigger || ak2.TriggerProxies == null)
					{
						continue;
					}
					using (List<bqt>.Enumerator enumerator2 = Enumerable.ToList<bqt>(ak2.TriggerProxies).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							bqt bqt = enumerator2.Current;
							this.Zone.ActionManager.g9(new np(this, ak2), atp.a);
						}
						continue;
					}
				}
				if (this.CanTrigger && ak2.TriggerProxies != null)
				{
					foreach (bqt bqt2 in Enumerable.ToList<bqt>(ak2.TriggerProxies))
					{
						bqt2.b(ak2, this);
					}
				}
			}
			foreach (ak1 ak3 in collectionDelta.a)
			{
				ak3.g(this);
				ak3.a(new EventHandler<EventArgs>(this.a));
				this.l.Remove(ak3);
			}
			this.d();
		}
		if (this.z != null)
		{
			foreach (ak1 ak4 in Enumerable.Union<ak1>(this.l, collectionDelta.a))
			{
				ak4.a(this, true);
			}
		}
		foreach (ak1 ak5 in this.l)
		{
			hashSet.Add(ak5);
		}
		foreach (ak1 ak6 in hashSet)
		{
			if (A_1)
			{
				if (this.Zone == null || !this.CanTrigger || ak6.TriggerProxies == null)
				{
					continue;
				}
				using (List<bqt>.Enumerator enumerator2 = Enumerable.ToList<bqt>(ak6.TriggerProxies).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						bqt bqt3 = enumerator2.Current;
						this.Zone.ActionManager.g9(new em5(this, ak6), atp.a);
					}
					continue;
				}
			}
			if (this.Area != null)
			{
				ak6.h(this);
			}
		}
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x0004AAD0 File Offset: 0x00048CD0
	private void d(aud A_0)
	{
		if (this.ai != null)
		{
			this.ai(A_0, new EventArgs());
		}
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0004AAF0 File Offset: 0x00048CF0
	private void c(aud A_0)
	{
		if (this.aj != null)
		{
			this.aj(A_0, new EventArgs());
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x0004AB10 File Offset: 0x00048D10
	private new void b(aud A_0)
	{
		if (this.ak != null)
		{
			this.ak(A_0, new EventArgs());
		}
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x0004AB30 File Offset: 0x00048D30
	private new void a(aud A_0)
	{
		if (this.al != null)
		{
			this.al(A_0, new EventArgs());
		}
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x0004AB50 File Offset: 0x00048D50
	private void c()
	{
		if (!this.k && this.u.b() == 0L)
		{
			if (this.Area != null)
			{
				this.Area.b(this);
			}
			this.k = true;
		}
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x0004AB8C File Offset: 0x00048D8C
	private new void b()
	{
		if (this.am != null)
		{
			this.am(this, new EventArgs());
		}
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x0004ABAC File Offset: 0x00048DAC
	private new void a()
	{
		if (this.an != null)
		{
			this.an(this, new EventArgs());
		}
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0004ABCC File Offset: 0x00048DCC
	private new void b(cn7 A_0)
	{
		if (this.ap != null)
		{
			this.ap(this, new bdu(A_0));
		}
		this.ajf(A_0);
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0004ABF4 File Offset: 0x00048DF4
	private new void a(cn7 A_0)
	{
		if (this.ao != null)
		{
			this.ao(this, new bdu(A_0));
		}
		this.aje(A_0);
	}

	// Token: 0x040009E5 RID: 2533
	public new static readonly string a = "ue";

	// Token: 0x040009E6 RID: 2534
	private new int b;

	// Token: 0x040009E7 RID: 2535
	[NonSerialized]
	private bool c;

	// Token: 0x040009E8 RID: 2536
	public Vector3 d;

	// Token: 0x040009E9 RID: 2537
	public Vector3 e;

	// Token: 0x040009EA RID: 2538
	public bool f;

	// Token: 0x040009EB RID: 2539
	public bool g;

	// Token: 0x040009EC RID: 2540
	public int h;

	// Token: 0x040009ED RID: 2541
	private new HorizontalDirection i;

	// Token: 0x040009EE RID: 2542
	public cgy j;

	// Token: 0x040009EF RID: 2543
	private bool k;

	// Token: 0x040009F0 RID: 2544
	public List<ak1> l = new List<ak1>();

	// Token: 0x040009F1 RID: 2545
	public aud m;

	// Token: 0x040009F2 RID: 2546
	private bjp n = new bjp();

	// Token: 0x040009F3 RID: 2547
	private List<ejt> o = new List<ejt>();

	// Token: 0x040009F4 RID: 2548
	private Color p;

	// Token: 0x040009F5 RID: 2549
	[NonSerialized]
	private bool q;

	// Token: 0x040009F6 RID: 2550
	public new Dictionary<byte, Color?> r = new Dictionary<byte, Color?>();

	// Token: 0x040009F7 RID: 2551
	private ayb s = new ayb();

	// Token: 0x040009F8 RID: 2552
	internal bjp t = new bjp();

	// Token: 0x040009F9 RID: 2553
	internal bjp u;

	// Token: 0x040009FA RID: 2554
	private Dictionary<Type, cn7> v = new Dictionary<Type, cn7>();

	// Token: 0x040009FB RID: 2555
	private bool w;

	// Token: 0x040009FC RID: 2556
	public bool x;

	// Token: 0x040009FD RID: 2557
	public bool y;

	// Token: 0x040009FE RID: 2558
	public Vector2? z;

	// Token: 0x040009FF RID: 2559
	public bool aa;

	// Token: 0x04000A00 RID: 2560
	[NonSerialized]
	private bool ab;

	// Token: 0x04000A01 RID: 2561
	[NonSerialized]
	public float ac;

	// Token: 0x04000A02 RID: 2562
	[NonSerialized]
	public float ad;

	// Token: 0x04000A03 RID: 2563
	[CompilerGenerated]
	private EventHandler<c1> ae;

	// Token: 0x04000A04 RID: 2564
	[CompilerGenerated]
	private EventHandler<c1> af;

	// Token: 0x04000A05 RID: 2565
	[CompilerGenerated]
	private EventHandler<c1> ag;

	// Token: 0x04000A06 RID: 2566
	[CompilerGenerated]
	private EventHandler<c1> ah;

	// Token: 0x04000A07 RID: 2567
	[CompilerGenerated]
	private EventHandler<EventArgs> ai;

	// Token: 0x04000A08 RID: 2568
	[CompilerGenerated]
	private EventHandler<EventArgs> aj;

	// Token: 0x04000A09 RID: 2569
	[CompilerGenerated]
	private EventHandler<EventArgs> ak;

	// Token: 0x04000A0A RID: 2570
	[CompilerGenerated]
	private EventHandler<EventArgs> al;

	// Token: 0x04000A0B RID: 2571
	[CompilerGenerated]
	private EventHandler<EventArgs> am;

	// Token: 0x04000A0C RID: 2572
	[CompilerGenerated]
	private EventHandler<EventArgs> an;

	// Token: 0x04000A0D RID: 2573
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler<bdu> ao;

	// Token: 0x04000A0E RID: 2574
	[CompilerGenerated]
	[NonSerialized]
	private EventHandler<bdu> ap;

	// Token: 0x04000A0F RID: 2575
	[CompilerGenerated]
	private EventHandler<c1> aq;
}
