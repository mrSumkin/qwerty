using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x0200146D RID: 5229
[eiz("TRV")]
[Serializable]
public sealed class e71 : evd, ISerializable
{
	// Token: 0x0600760F RID: 30223 RVA: 0x0031DDB4 File Offset: 0x0031BFB4
	private e71(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (bool?)A_0.GetValue("TRV:V", typeof(bool?));
			this.b = (Point)A_0.GetValue("TRV:IN", typeof(Point));
			di7.ReadList<byte>("TRV:AO", ref this.c, A_0);
			if (ell.b() >= 5)
			{
				di7.ReadEvent<EventArgs>("TRV:V1", ref this.g, A_0);
			}
			else
			{
				this.g = (EventHandler<EventArgs>)A_0.GetValue("TRV:V1", typeof(EventHandler<EventArgs>));
			}
			di7.ReadList<Point>("TRV:L", ref this.d, A_0);
			if (ell.a() >= 425)
			{
				this.e = (A_0.GetValue("TRV:RO", typeof(float?)) as float?);
			}
			if (ell.a() >= 508)
			{
				this.f = A_0.GetInt32("TRV:RTN");
				return;
			}
			this.f = ((this.a == null) ? 1 : 0);
			return;
		}
		else
		{
			if (base.GetType() == typeof(e71))
			{
				this.a = (bool?)A_0.GetValue("_Valid", typeof(bool?));
				this.b = (Point)A_0.GetValue("_InvokerNode", typeof(Point));
				this.c = (List<byte>)A_0.GetValue("_AdditionalObstructors", typeof(List<byte>));
				this.g = (EventHandler<EventArgs>)A_0.GetValue("Validated", typeof(EventHandler<EventArgs>));
				return;
			}
			this.a = (bool?)A_0.GetValue("TargetReachabilityValidator+_Valid", typeof(bool?));
			this.b = (Point)A_0.GetValue("TargetReachabilityValidator+_InvokerNode", typeof(Point));
			this.c = (List<byte>)A_0.GetValue("TargetReachabilityValidator+_AdditionalObstructors", typeof(List<byte>));
			this.g = (EventHandler<EventArgs>)A_0.GetValue("TargetReachabilityValidator+Validated", typeof(EventHandler<EventArgs>));
			return;
		}
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x0031E004 File Offset: 0x0031C204
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TRV:V", this.a);
		info.AddValue("TRV:IN", this.b);
		di7.WriteList<byte>("TRV:AO", this.c, info);
		di7.WriteEvent<EventArgs>("TRV:V1", this.g, info);
		di7.WriteList<Point>("TRV:L", this.d, info);
		info.AddValue("TRV:RO", this.e);
		info.AddValue("TRV:RTN", this.f);
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06007611 RID: 30225 RVA: 0x0031E098 File Offset: 0x0031C298
	public bool? Valid
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06007612 RID: 30226 RVA: 0x0031E0A0 File Offset: 0x0031C2A0
	public List<byte> AdditionalObstructors
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06007613 RID: 30227 RVA: 0x0031E0A8 File Offset: 0x0031C2A8
	public List<Point> LastImprintedNodes
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06007614 RID: 30228 RVA: 0x0031E0B0 File Offset: 0x0031C2B0
	public float? RangeOverride
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x06007615 RID: 30229 RVA: 0x0031E0B8 File Offset: 0x0031C2B8
	public e71()
	{
	}

	// Token: 0x06007616 RID: 30230 RVA: 0x0031E0CC File Offset: 0x0031C2CC
	public e71(float? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007617 RID: 30231 RVA: 0x0031E0E8 File Offset: 0x0031C2E8
	[CompilerGenerated]
	public void gm(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.g;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06007618 RID: 30232 RVA: 0x0031E120 File Offset: 0x0031C320
	[CompilerGenerated]
	public void gn(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.g;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06007619 RID: 30233 RVA: 0x0031E158 File Offset: 0x0031C358
	public void go(ad5 A_0)
	{
		czh.a(A_0, "spellInvocation");
		this.a(A_0.q(), A_0.h(), A_0.e().c(A_0.h()), true);
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x0031E194 File Offset: 0x0031C394
	public void a(c5x A_0, object A_1, float A_2, bool A_3)
	{
		czh.a(A_0, "invoker");
		this.a = null;
		this.b = Point.Zero;
		List<Point> list = new List<Point>();
		aud aud = null;
		ak1 ak = A_1 as ak1;
		if (ak != null)
		{
			aud = ak.Area;
			list.Add(ak.Location);
		}
		else
		{
			b0b b0b = A_1 as b0b;
			if (b0b != null)
			{
				if (b0b.j != cgy.b)
				{
					this.a = new bool?(false);
					this.a();
					return;
				}
				aud = b0b.Area;
				if ((b0b.Size.X > 1f || b0b.Size.Y > 1f) && b0b.l.Count > 1)
				{
					using (List<ak1>.Enumerator enumerator = b0b.l.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ak1 ak2 = enumerator.Current;
							list.Add(ak2.Location);
						}
						goto IL_112;
					}
				}
				list.Add(b0b.aj().a());
			}
		}
		IL_112:
		if (aud == null || aud != A_0.Area)
		{
			this.a = new bool?(false);
			this.a();
			return;
		}
		this.b = A_0.aj().a();
		float valueOrDefault = this.e.GetValueOrDefault(A_2);
		for (int i = list.Count - 1; i >= 0; i--)
		{
			Point a_ = list[i];
			if (!aw1.a(bnx.a(this.b, a_), valueOrDefault))
			{
				list.RemoveAt(i);
			}
		}
		if (list.Count == 0)
		{
			this.a = new bool?(false);
			this.a();
			return;
		}
		this.f = list.Count;
		foreach (Point a_2 in list)
		{
			anp anp = aw1.b(a_2, aud, valueOrDefault, bcj.a(this.c), 0L);
			anp.a(new EventHandler<EventArgs>(this.a));
			if (A_3)
			{
				anp.k();
			}
			else
			{
				anp.j();
			}
		}
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x0031E3F8 File Offset: 0x0031C5F8
	[dcc("TRV:mIF")]
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		if (this.d == null)
		{
			this.d = anp.f();
		}
		else
		{
			foreach (Point item in anp.f())
			{
				if (!this.d.Contains(item))
				{
					this.d.Add(item);
				}
			}
		}
		bool flag = anp.f().Contains(this.b);
		if (this.a == null || (!this.a.Value && flag))
		{
			this.a = new bool?(flag);
		}
		int num = this.f - 1;
		this.f = num;
		if (num == 0)
		{
			this.a();
		}
	}

	// Token: 0x0600761C RID: 30236 RVA: 0x0031E4EC File Offset: 0x0031C6EC
	private void a()
	{
		if (this.g != null)
		{
			this.g(this, new EventArgs());
		}
	}

	// Token: 0x04003030 RID: 12336
	private bool? a;

	// Token: 0x04003031 RID: 12337
	private Point b;

	// Token: 0x04003032 RID: 12338
	private List<byte> c = new List<byte>();

	// Token: 0x04003033 RID: 12339
	private List<Point> d;

	// Token: 0x04003034 RID: 12340
	private float? e;

	// Token: 0x04003035 RID: 12341
	private int f;

	// Token: 0x04003036 RID: 12342
	[CompilerGenerated]
	private EventHandler<EventArgs> g;
}
