using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x020001B4 RID: 436
[eiz("T1")]
[Serializable]
public class ak1 : ISerializable
{
	// Token: 0x06000C74 RID: 3188 RVA: 0x00032F54 File Offset: 0x00031154
	protected ak1(SerializationInfo A_0, StreamingContext A_1)
	{
		this.c = (SortedList<b0b, b0b>)A_0.GetValue("T1:E", typeof(SortedList<b0b, b0b>));
		di7.ReadDictionary<Guid, c3y>("T1:LS", ref this.d, A_0);
		this.e = A_0.GetBoolean("T1:LIV");
		this.f = (Color)A_0.GetValue("T1:CL", typeof(Color));
		this.g = (ayb)A_0.GetValue("T1:O", typeof(ayb));
		this.h = (bjp)A_0.GetValue("T1:D", typeof(bjp));
		di7.ReadDictionary<Guid, long>("T1:EFM", ref this.i, A_0);
		this.j = A_0.GetBoolean("T1:FIV");
		this.k = (bjp)A_0.GetValue("T1:CF", typeof(bjp));
		if (ell.b() >= 5)
		{
			di7.ReadEvent<a8f>("T1:FC", ref this.p, A_0);
			di7.ReadEvent<a8f>("T1:LCC", ref this.q, A_0);
			di7.ReadEvent<EventArgs>("T1:LC", ref this.r, A_0);
		}
		else
		{
			this.p = (EventHandler<a8f>)A_0.GetValue("T1:FC", typeof(EventHandler<a8f>));
			this.q = (EventHandler<a8f>)A_0.GetValue("T1:LCC", typeof(EventHandler<a8f>));
			this.r = (EventHandler<EventArgs>)A_0.GetValue("T1:LC", typeof(EventHandler<EventArgs>));
		}
		if (ell.b() >= 16)
		{
			this.l = (A_0.GetValue("T1:FO", typeof(Dictionary<Guid, bjp>)) as Dictionary<Guid, bjp>);
			return;
		}
		this.l = new Dictionary<Guid, bjp>();
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0003319C File Offset: 0x0003139C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("T1:E", this.c);
		di7.WriteDictionary<Guid, c3y>("T1:LS", this.d, info);
		info.AddValue("T1:LIV", this.e);
		info.AddValue("T1:CL", this.f);
		info.AddValue("T1:O", this.g);
		info.AddValue("T1:D", this.h);
		di7.WriteDictionary<Guid, long>("T1:EFM", this.i, info);
		info.AddValue("T1:FIV", this.j);
		info.AddValue("T1:CF", this.k);
		info.AddValue("T1:FO", this.l);
		di7.WriteEvent<a8f>("T1:FC", this.p, info);
		di7.WriteEvent<a8f>("T1:LCC", this.q, info);
		di7.WriteEvent<EventArgs>("T1:LC", this.r, info);
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003328C File Offset: 0x0003148C
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00033294 File Offset: 0x00031494
	public Point Location
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

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000332A0 File Offset: 0x000314A0
	public aud Area
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000332A8 File Offset: 0x000314A8
	public c1a Zone
	{
		get
		{
			if (this.Area == null)
			{
				return null;
			}
			return this.Area.Zone;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000C7A RID: 3194 RVA: 0x000332C4 File Offset: 0x000314C4
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

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000332E0 File Offset: 0x000314E0
	public IList<b0b> Entities
	{
		get
		{
			return this.c.Values;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x000332F0 File Offset: 0x000314F0
	public Color Lightning
	{
		get
		{
			return this.c();
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000332F8 File Offset: 0x000314F8
	public bjp Formation
	{
		get
		{
			return this.b();
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00033300 File Offset: 0x00031500
	public ICollection<bqt> TriggerProxies
	{
		get
		{
			return this.m;
		}
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0003330C File Offset: 0x0003150C
	public ak1(aud A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0003339C File Offset: 0x0003159C
	[CompilerGenerated]
	public void d(EventHandler<a8f> A_0)
	{
		EventHandler<a8f> eventHandler = this.p;
		EventHandler<a8f> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8f> value = (EventHandler<a8f>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8f>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x000333D4 File Offset: 0x000315D4
	[CompilerGenerated]
	public void b(EventHandler<a8f> A_0)
	{
		EventHandler<a8f> eventHandler = this.p;
		EventHandler<a8f> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8f> value = (EventHandler<a8f>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8f>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0003340C File Offset: 0x0003160C
	[CompilerGenerated]
	public void c(EventHandler<a8f> A_0)
	{
		EventHandler<a8f> eventHandler = this.q;
		EventHandler<a8f> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8f> value = (EventHandler<a8f>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8f>>(ref this.q, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00033444 File Offset: 0x00031644
	[CompilerGenerated]
	public void a(EventHandler<a8f> A_0)
	{
		EventHandler<a8f> eventHandler = this.q;
		EventHandler<a8f> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<a8f> value = (EventHandler<a8f>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<a8f>>(ref this.q, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0003347C File Offset: 0x0003167C
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.r;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.r, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x000334B4 File Offset: 0x000316B4
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.r;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.r, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x000334EC File Offset: 0x000316EC
	public void p()
	{
		this.d.Clear();
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000334FC File Offset: 0x000316FC
	public void a(Guid A_0)
	{
		if (this.d.ContainsKey(A_0))
		{
			this.d.Remove(A_0);
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0003351C File Offset: 0x0003171C
	public void a(c3y A_0)
	{
		this.d[A_0.c()] = A_0;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00033530 File Offset: 0x00031730
	public void e()
	{
		this.e = false;
		if (this.r != null)
		{
			this.r(this, new EventArgs());
		}
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x00033558 File Offset: 0x00031758
	public void b(byte A_0)
	{
		this.g.s3(A_0);
		this.h.s3(A_0);
		foreach (b0b b0b in this.c.Values)
		{
			b0b.b(A_0);
		}
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x000335CC File Offset: 0x000317CC
	public void a(byte A_0)
	{
		this.h.s3(A_0);
		foreach (b0b b0b in this.c.Values)
		{
			b0b.a(A_0);
		}
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00033634 File Offset: 0x00031834
	public void a(byte A_0, b0b A_1)
	{
		this.h.s3(A_0);
		if (A_1 != null)
		{
			A_1.a(A_0);
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00033650 File Offset: 0x00031850
	public void c(byte A_0)
	{
		this.g.s4(A_0);
		foreach (b0b b0b in this.c.Values)
		{
			b0b.c(A_0);
		}
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x000336B8 File Offset: 0x000318B8
	public bool b(long A_0)
	{
		return this.g.b(A_0);
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x000336C8 File Offset: 0x000318C8
	public bool a(long A_0)
	{
		return this.h.b(A_0);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x000336D8 File Offset: 0x000318D8
	public void i(b0b A_0)
	{
		this.d(A_0);
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x000336E4 File Offset: 0x000318E4
	internal void a(b0b A_0, bool A_1 = true)
	{
		if (A_0.z != null)
		{
			if (this.Entities.Contains(A_0))
			{
				this.l[A_0.qe()] = this.b(A_0);
				return;
			}
			if (A_1)
			{
				this.l.Remove(A_0.qe());
			}
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00033744 File Offset: 0x00031944
	internal void j()
	{
		this.l.Clear();
		foreach (b0b a_ in this.Entities)
		{
			this.a(a_, false);
		}
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x000337A8 File Offset: 0x000319A8
	public long f(b0b A_0)
	{
		long num = 0L;
		if (this.l.Count > 0)
		{
			foreach (KeyValuePair<Guid, bjp> keyValuePair in this.l)
			{
				if (A_0 == null || keyValuePair.Key != A_0.qe())
				{
					num |= keyValuePair.Value.b();
				}
			}
		}
		return num;
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0003383C File Offset: 0x00031A3C
	public long a(HashSet<Guid> A_0)
	{
		long num = 0L;
		if (this.l.Count > 0)
		{
			foreach (KeyValuePair<Guid, bjp> keyValuePair in this.l)
			{
				if (!A_0.Contains(keyValuePair.Key))
				{
					num |= keyValuePair.Value.b();
				}
			}
		}
		return num;
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x000338C4 File Offset: 0x00031AC4
	public ya a(string A_0)
	{
		if (A_0 != null && this.n != null)
		{
			ya result;
			this.n.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x000338F4 File Offset: 0x00031AF4
	public List<ya> a(Type A_0)
	{
		if (this.o != null)
		{
			List<ya> result;
			this.o.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00033920 File Offset: 0x00031B20
	public void h(b0b A_0)
	{
		if (A_0.CanTrigger && this.m != null)
		{
			foreach (bqt bqt in Enumerable.ToList<bqt>(this.m))
			{
				bqt.a(this, A_0);
			}
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00033994 File Offset: 0x00031B94
	internal void j(b0b A_0)
	{
		if (!this.c.ContainsValue(A_0))
		{
			this.c.Add(A_0, A_0);
		}
		this.a(A_0);
		this.e(A_0);
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x000339C4 File Offset: 0x00031BC4
	internal void g(b0b A_0)
	{
		int num = this.c.Values.IndexOf(A_0);
		if (num != -1)
		{
			this.c.RemoveAt(num);
		}
		this.c(A_0);
		A_0.b(this.g.b);
		if (A_0.CanTrigger && this.m != null)
		{
			foreach (bqt bqt in Enumerable.ToList<bqt>(this.m))
			{
				bqt.c(this, A_0);
			}
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00033A74 File Offset: 0x00031C74
	internal void a(bqt A_0)
	{
		if (this.m == null)
		{
			this.m = new HashSet<bqt>();
		}
		this.m.Add(A_0);
		this.a();
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00033AA0 File Offset: 0x00031CA0
	internal void b(bqt A_0)
	{
		if (this.m != null)
		{
			this.m.Remove(A_0);
		}
		this.a();
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00033AC4 File Offset: 0x00031CC4
	internal void k(b0b A_0)
	{
		IList<b0b> values = this.c.Values;
		for (int i = 0; i < this.c.Count; i++)
		{
			if (values[i] == A_0)
			{
				this.c.RemoveAt(i);
				this.c.Add(A_0, A_0);
				return;
			}
		}
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00033B20 File Offset: 0x00031D20
	private Color c()
	{
		if (!this.e)
		{
			this.f = aac.a(this.Area, this.d.Values);
			this.e = true;
		}
		return this.f;
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00033B58 File Offset: 0x00031D58
	private bjp b()
	{
		if (!this.j)
		{
			this.k = new bjp(bcj.a(this.i.Values));
			this.j = true;
		}
		return this.k;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00033B90 File Offset: 0x00031D90
	private void e(b0b A_0)
	{
		czh.a(A_0, "entity");
		bjp bjp = A_0.ae();
		long num = (bjp != null) ? bjp.b() : 0L;
		this.i[A_0.qe()] = num;
		long num2 = this.Formation.b();
		this.j = false;
		if (num != 0L)
		{
			if (this.p != null)
			{
				this.p(this, new a8f(this.Location));
			}
			if (this.q != null)
			{
				long num3 = 1L;
				if ((num3 & num) != 0L && (num3 & num) != (num2 & num3))
				{
					this.q(this, new a8f(this.Location));
				}
			}
		}
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00033C48 File Offset: 0x00031E48
	private void d(b0b A_0)
	{
		czh.a(A_0, "entity");
		bjp bjp = A_0.ae();
		long num = 0L;
		this.i.TryGetValue(A_0.qe(), out num);
		long num2 = (bjp != null) ? bjp.b() : 0L;
		this.i[A_0.qe()] = num2;
		this.j = false;
		if (num != num2)
		{
			if (this.p != null)
			{
				this.p(this, new a8f(this.Location));
			}
			if (this.q != null)
			{
				long num3 = 1L;
				if ((num3 & num2) != (num3 & num))
				{
					this.q(this, new a8f(this.Location));
				}
			}
		}
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00033D04 File Offset: 0x00031F04
	private void c(b0b A_0)
	{
		czh.a(A_0, "entity");
		long num = 0L;
		this.i.TryGetValue(A_0.qe(), out num);
		this.i.Remove(A_0.qe());
		this.j = false;
		if (num != 0L)
		{
			if (this.p != null)
			{
				this.p(this, new a8f(this.Location));
			}
			if (this.q != null && (1L & num) != 0L)
			{
				this.q(this, new a8f(this.Location));
			}
		}
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00033DA0 File Offset: 0x00031FA0
	private bjp b(b0b A_0)
	{
		bjp bjp = new bjp();
		Point point = new Point(this.Location.X * 4, this.Location.Y * 4);
		Point point2;
		Point point3;
		A_0.b(out point2, out point3);
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				Point point4 = new Point(point.X + j, point.Y + i);
				if (point4.X >= point2.X && point4.X <= point3.X && point4.Y >= point2.Y && point4.Y <= point3.Y)
				{
					byte a_ = (byte)(i * 4 + j);
					bjp.s3(a_);
				}
			}
		}
		return bjp;
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00033E7C File Offset: 0x0003207C
	public void d()
	{
		this.i.Clear();
		foreach (b0b a_ in this.c.Values)
		{
			this.e(a_);
		}
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00033EE4 File Offset: 0x000320E4
	private void a(b0b A_0)
	{
		A_0.a(this.g.b);
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00033EF8 File Offset: 0x000320F8
	private void a()
	{
		this.n = new Dictionary<string, ya>();
		this.o = new Dictionary<Type, List<ya>>();
		if (this.m != null)
		{
			foreach (bqt bqt in this.m)
			{
				if (bqt.Trigger != null)
				{
					if (bqt.Trigger.Name != null)
					{
						this.n[bqt.Trigger.Name] = bqt.Trigger;
					}
					Type type = bqt.Trigger.GetType();
					do
					{
						List<ya> list;
						this.o.TryGetValue(type, out list);
						if (list == null)
						{
							list = new List<ya>();
							this.o.Add(type, list);
						}
						list.Add(bqt.Trigger);
						type = type.BaseType;
					}
					while (type != typeof(ya) && type != typeof(object));
				}
			}
		}
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00034014 File Offset: 0x00032214
	public override string ToString()
	{
		return string.Format("[{0}, {1}] Type: {2}. Entity count: {3}", new object[]
		{
			this.Location.X,
			this.Location.Y,
			base.GetType().Name,
			this.Entities.Count
		});
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00034078 File Offset: 0x00032278
	public Vector3 h()
	{
		return new Vector3((float)this.b.X + 0.5f, (float)this.b.Y + 0.5f, 0f);
	}

	// Token: 0x0400075B RID: 1883
	public aud a;

	// Token: 0x0400075C RID: 1884
	public Point b;

	// Token: 0x0400075D RID: 1885
	public SortedList<b0b, b0b> c = new SortedList<b0b, b0b>(cx0.a());

	// Token: 0x0400075E RID: 1886
	private Dictionary<Guid, c3y> d = new Dictionary<Guid, c3y>();

	// Token: 0x0400075F RID: 1887
	private bool e;

	// Token: 0x04000760 RID: 1888
	private Color f = Color.Black;

	// Token: 0x04000761 RID: 1889
	private ayb g = new ayb();

	// Token: 0x04000762 RID: 1890
	internal bjp h = new bjp();

	// Token: 0x04000763 RID: 1891
	private Dictionary<Guid, long> i = new Dictionary<Guid, long>();

	// Token: 0x04000764 RID: 1892
	private bool j;

	// Token: 0x04000765 RID: 1893
	private bjp k = new bjp();

	// Token: 0x04000766 RID: 1894
	public Dictionary<Guid, bjp> l = new Dictionary<Guid, bjp>();

	// Token: 0x04000767 RID: 1895
	[NonSerialized]
	private HashSet<bqt> m = new HashSet<bqt>();

	// Token: 0x04000768 RID: 1896
	[NonSerialized]
	private Dictionary<string, ya> n = new Dictionary<string, ya>();

	// Token: 0x04000769 RID: 1897
	[NonSerialized]
	private Dictionary<Type, List<ya>> o;

	// Token: 0x0400076A RID: 1898
	[CompilerGenerated]
	private EventHandler<a8f> p;

	// Token: 0x0400076B RID: 1899
	[CompilerGenerated]
	private EventHandler<a8f> q;

	// Token: 0x0400076C RID: 1900
	[CompilerGenerated]
	private EventHandler<EventArgs> r;
}
